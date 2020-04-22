using System;
using System.Collections.Generic;
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
            int amount = (int)amountNumeric.Value;
            for (int i = 0; i < amount; i++)
            {
                int figure = rnd.Next(0, 2);
                if (figure == 0)
                {
                    list.Add(new Circle());
                }

                if (figure == 1)
                {
                    list.Add(new Point());
                }
                else
                {
                    list.Add(new Square());
                }
            }
        }
    }
}