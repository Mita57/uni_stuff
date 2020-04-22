using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static List<Figure> list = new List<Figure>();

        private void createButton_Click(object sender, EventArgs e)
        {
            list.Clear();
            Random rnd = new Random();
            int amount = (int) amountNumeric.Value;
            for (int i = 0; i < amount; i++)
            {
                int figure = rnd.Next(0, 2);
                if (figure == 0)
                {
                    int x = rnd.Next(0, 8);
                    int y = rnd.Next(0, 8);
                    int r = rnd.Next(0, 5);
                    list.Add(new Circle(x, y, r));
                }

                if (figure == 1)
                {
                    int x = rnd.Next(0, 8);
                    int y = rnd.Next(0, 8);
                    list.Add(new Point(x, y));
                }
                else
                {
                    int x = rnd.Next(0, 8);
                    int y = rnd.Next(0, 8);
                    int a = rnd.Next(0, 5);
                    list.Add(new Square(x, y, a));
                }
            }
        }

        private void paramsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paramsCB.SelectedIndex == 0)
            {
                paramNumber.Visible = false;
            }
            else
            {
                paramNumber.Visible = true;
            }
        }
    }
}