using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
            
            drawStuff();
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

        private Bitmap DrawArea;
        
        private void drawStuff()
        {
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = DrawArea;
            
            Graphics g;
            g = Graphics.FromImage(DrawArea);
                
            Pen mypen = new Pen(Color.Black);

            g.DrawLine(mypen, new System.Drawing.Point(DrawArea.Width/2,0), new System.Drawing.Point(DrawArea.Width/2, DrawArea.Height));
            g.DrawLine(mypen, new System.Drawing.Point(0,DrawArea.Height/2), new System.Drawing.Point(DrawArea.Width, DrawArea.Height / 2));

            int x = -20;
            int y = -10;

            int A = 40;
            g.DrawRectangle(mypen, (x - A / 2) + DrawArea.Width/2 , (y - A/2) + DrawArea.Height / 2,A,A);

            pictureBox1.Image = DrawArea;
            
            g.DrawEllipse(mypen, new System.Drawing.Rectangle((x - A / 2) + DrawArea.Width/2 , (y - A/2) + DrawArea.Height / 2, A, A));

            g.Dispose();
        }
    }
}