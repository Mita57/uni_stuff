using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
// Устанавливаем для сокета локальную конечную точку
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);
// Создаем сокет Tcp/Ip
            Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
// Назначаем сокет локальной конечной точке и слушаем входящие сокеты
            try
            {
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);
// Начинаем слушать соединения
                while (true)
                {
                    Console.WriteLine("Ожидаем соединение через порт {0}", ipEndPoint);
// Программа приостанавливается, ожидая входящее соединение
                    Socket handler = sListener.Accept();
                    string data = null;
// Мы дождались клиента, пытающегося с нами соединиться
                    byte[] bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.UTF8.GetString(bytes, 0, bytesRec);
// Показываем данные на консоли
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load("C:\\Users\\57thr\\Documents\\GitHub\\uni_stuff\\Year_2\\БИПИП\\Sockets\\Server\\stuff.xml");
                    XmlElement xRoot = xDoc.DocumentElement;
                    string reply = "";
                    foreach (XmlElement xNode in xRoot)
                    {
                        string name = "";
                        string amount = "";
                        string cost = "";
                        bool matches = false;
                        foreach (XmlNode childnode in xNode.ChildNodes)
                        {
                            if (childnode.Name == "name" && childnode.InnerText.Contains(data))
                            {
                                name = childnode.InnerText;
                                matches = true;
                            }

                            if (childnode.Name == "amount" && matches)
                            {
                                amount = childnode.InnerText;
                            }
                            
                            if (childnode.Name == "price" && matches)
                            {
                                cost = childnode.InnerText;
                            }
                            
                        }

                        if (matches)
                        {
                            reply += "#" + name + "~" + amount + "~" + cost;
                        }
                    }

// Отправляем ответ клиенту\
                    byte[] msg = Encoding.UTF8.GetBytes(reply);
                    handler.Send(msg);
                    if (data.IndexOf("<TheEnd>") > -1)
                    {
                        Console.WriteLine("Сервер завершил соединение с клиентом.");
                        break;
                    }

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}