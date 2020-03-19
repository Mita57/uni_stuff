using System;
using System.Threading;

namespace laba4
{
    class Program
    {
        public static Random rnd = new Random(); //для случайности прихода заявок

        public static Thread
            queue, t1, t2; //потоки: queue: добавление пациента в очередь, t2 и t3: Извлечения клиентов из очереди

        public static Semaphore
            Sem1 = new Semaphore(99999,
                99999); //В задании про очередь ничего  не былр, так что пусть 99999

        public static Semaphore
            Sem2 = new Semaphore(0,
                99999); //Контроль доступа обслуживающих потоков при нуле заявок в очереди - не извлекаем

        public static int index = 0;
        public static int[] arr = new int[99999];

        public static void Insert(int n) //добавляет пациента в очередь
        {
            Thread.Sleep(n); //запись пациента в очередь через то время, через которое он пришел
            index++;
            arr[index - 1] = n; //добавление в массив
        }

        public static int Get() //Метод для извлечения пациента из очереди
        {
            lock (typeof(Program)) //защита от выполнения кода другими потоками, во время выполнения одним из потоков
            {
                int Result = arr[index - 1]; //значение - время прихода извлеченного клиента
                index--;
                return Result;
            }
        }

        public static void ThWriter()//поток-писатель
        {
            while (true)
            {
                Sem1.WaitOne(); //Если очередь полная, прекратить ее пополнение
                int time = rnd.Next(5000); //Создание времени для прихода пациента
                Insert(time); //Записать в очередь число, через которое пациент попал в очередь
                Console.WriteLine(time / 1000 + " мин. - пациент пришел");
                Sem2.Release(); //Извлечь заявку из очереди
            }
        }

        public static void ThReader()
        {
            while (true)
            {
                Sem2.WaitOne(); //Если в очереди 0 заявок, то не извлекаем 
                int time = rnd.Next(10000); //время обслуживания клиента
                Thread.Sleep(time); //обслуживаем какое то время
                Console.WriteLine("Пациент, пришедший через " + Get() / 1000 + " мин. - обслужен за {0} мин.",
                    time / 1000); //извлекаем из очереди число
                Sem1.Release(); //Записать заявку в очередь после освобождения места
            }
        }

        public static void Main()
        {
            queue = new Thread(ThWriter); //поток записи заявок
            t1 = new Thread(ThReader); //поток обслуживания 1
            t2 = new Thread(ThReader); //поток обслуживания 2
            queue.Start();
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}