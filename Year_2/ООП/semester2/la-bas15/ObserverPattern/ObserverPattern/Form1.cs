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
        private List<Sub> aList = new List<Sub>();

        public Action eventB;
        private int countB = 0;
        private List<Sub> bList = new List<Sub>();

        public Action eventC;
        private int countС = 0;
        private List<Sub> cList = new List<Sub>();


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
            label4.Text = "Подписчиков " + countС;
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
            if (eventB != null)
            {
                eventB();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (eventC != null)
            {
                eventC();
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
                        aList.Add(new Sub(o.ToString().Split(new[] { "Наблюдатель" }, StringSplitOptions.None)[1].Split(',')[0], name));
                        string meme = "";
                        for (int i = 0; i < aList.Count; i++)
                        {
                            Sub sus = aList[i];
                            meme += sus.name + ":" + sus.action;
                        }
                        toolTip1.SetToolTip(Button1, meme);
                        done = true;
                        break;
                    }
                case "B":
                    {
                        eventB += method;
                        countB++;
                        bList.Add(new Sub(o.ToString().Split(new[] { "Наблюдатель" }, StringSplitOptions.None)[1].Split(',')[0], name));
                        string meme = "";
                        for (int i = 0; i < bList.Count; i++)
                        {
                            Sub sus = bList[i];
                            meme += sus.name + ":" + sus.action;
                        }
                        toolTip1.SetToolTip(Button2, meme);
                        done = true;
                        break;
                    }
                case "C":
                    {
                        eventC += method;
                        countС++;
                        cList.Add(new Sub(o.ToString().Split(new[] { "Наблюдатель" }, StringSplitOptions.None)[1].Split(',')[0], name));
                        string meme = "";
                        for (int i = 0; i < cList.Count; i++)
                        {
                            Sub sus = cList[i];
                            meme += sus.name + ":" + sus.action;
                        }
                        toolTip1.SetToolTip(Button3, meme);
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
                        for (int i = 0; i < aList.Count; i++)
                        {
                            Sub sus = aList[i];
                            if (sus.name == o.ToString().Split(new[] { "Наблюдатель" }, StringSplitOptions.None)[1].Split(',')[0])
                            {
                                aList.Remove(sus);
                            }
                        }
                        string meme = "";
                        for (int i = 0; i < aList.Count; i++)
                        {
                            Sub sus = aList[i];
                            meme += sus.name + ":" + sus.action;
                        }
                        toolTip1.SetToolTip(Button1, meme);
                        done = true;
                        break;
                    }
                case "B":
                    {
                        eventB -= method;
                        countB--;
                        for (int i = 0; i < bList.Count; i++)
                        {
                            Sub sus = bList[i];
                            if (sus.name == o.ToString().Split(new[] { "Наблюдатель" }, StringSplitOptions.None)[1].Split(',')[0])
                            {
                                bList.Remove(sus);
                            }
                        }
                        string meme = "";
                        for (int i = 0; i < bList.Count; i++)
                        {
                            Sub sus = bList[i];
                            meme += sus.name + ":" + sus.action;
                        }
                        done = true;
                        break;
                    }
                case "C":
                    {
                        eventC -= method;
                        countС--;
                        for (int i = 0; i < cList.Count; i++)
                        {
                            Sub sus = cList[i];
                            if (sus.name == o.ToString().Split(new[] { "Наблюдатель" }, StringSplitOptions.None)[1].Split(',')[0])
                            {
                                cList.Remove(sus);
                            }
                        }
                        string meme = "";
                        for (int i = 0; i < cList.Count; i++)
                        {
                            Sub sus = cList[i];
                            meme += sus.name + ":" + sus.action;
                        }
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

    class Sub
    {
        public string name;
        public string action;

        public Sub(string name, string action)
        {
            this.name = name;
            this.action = action;
        }
    }

}