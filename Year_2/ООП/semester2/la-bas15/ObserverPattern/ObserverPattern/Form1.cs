using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        List<Form2> Observers = new List<Form2>();
        private int obsCount = 0;

        public Action eventA;
        private int countA = 0;

        public Action eventB;
        private int countB = 0;


        private void addObserverBtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            Observers.Add(f2);
            obsCount++;
            f2.Text = "Наблюдатель " + obsCount;
            f2.Show();
            showInfo();
        }

        private void showInfo()
        {
            label1.Text = "Подписчиков " + countA;
            label2.Text = "Подписчиков " + countB;
            label3.Text = "Подписчиков " + obsCount;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (eventA != null)
            {
                eventA();
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            if(eventB != null)
            {
                eventB();
            }
        }

        public void register(string name, object o, Action method)
        {
            bool done = false;

            switch (name)
            {
                case "A":
                {
                    eventA += method;
                    countA++;
                    done = true;
                    break;
                }
                case "B":
                {
                    eventB += method;
                    countB++;
                    done = true;
                    break;
                }
            }

            if (done)
            {
                MessageBox.Show(string.Format("Объект {0} подписался на событие {1}", o, name));
                showInfo();
            }
        }

        public void unRegister(string name, object o, Action method)
        {
            bool done = false;
            switch (name)
            {
                case "A":
                {
                    eventA -= method;
                    countA--;
                    done = true;
                    break;
                }
                case "B":
                {
                    eventB -= method;
                    countB--;
                    done = true;
                    break;
                }
            }

            if (done)
            {
                MessageBox.Show(string.Format("Объект {0} отписался от события {1}", o, name));
                showInfo();
            }
        }
    }
}