using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace laba18
{
    
    class MyThread
    {
        public int Count = 0;
        private Thread Thread;
        public bool ThStop = false;
        public MyThread()
        {
            Count = 0;
        }
        
        public MyThread(int x, int y)
        {
            Count = 0;
        }

        public void Execute(Action goAction)
        {
            while (true)
            {
                if (!ThStop)
                {
                    goAction();
                }
                else
                {
                    Thread.Sleep(10);
                }
            }
        }

        public void Sleep(int time)
        {
            Thread.Sleep(time);
        }

        public void Go(Action goAction)
        {
            Thread = new Thread(new ThreadStart(() => Execute(goAction)));
            Thread.Start();
        }
        public void Join()
        {
            Thread.Join();
        }

        public void Break()
        {
            ThStop = true;
        }

        public void Continue()
        {
            ThStop = false;
        }

        public void Stop()
        {
            Thread.Abort();
        }
        public ThreadPriority Priority​
        {
            get { return Thread.Priority; }
            set
            {
                if (Thread != null)
                {
                    Thread.Priority = value;
                }
            }

        }
    }
}
