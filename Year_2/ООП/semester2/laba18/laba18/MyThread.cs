using System;
using System.Threading;

namespace laba18
{
    public class MyThread
    {
        public int Count = 0;
        
        private Thread thr;

        private bool ThStop = false;

        public ThreadPriority Priority
        {
            get
            {
                return thr.Priority;
            }
            set
            {
                thr.Priority = value;
            }
            
        }

        public MyThread()
        {
            Count = 0;
        }

        public void Execute()
        {
            while (!ThStop)
            {
                double s = 0;
                for (int i = 0; i < 100; i++)
                {
                    s += Math.Sin(i);
                    Count++;
                }
            }
        }

        public void go()
        {
            thr = new Thread(new ThreadStart(Execute));
            thr.Start();
        }

        public void stop()
        {
            ThStop = true;
        }

        public void suspend()
        {
            thr.Suspend();
        }

        public void resume()
        {
            thr.Resume();
        }
        
    }
}