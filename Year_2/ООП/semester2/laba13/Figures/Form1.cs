using System;
using System.Collections.Generic;
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

        Random rnd = new Random();
        private static List<Figure> list = new List<Figure>();

        private void createButton_Click(object sender, EventArgs e)
        {
            list.Clear();
            int amount = (int) amountNumeric.Value;
            for (int i = 0; i < amount; i++)
            {
                int figure = rnd.Next(0, 3);
                switch (figure)
                {
                    case 0:
                    {
                        int x = rnd.Next(-8, 9);
                        int y = rnd.Next(-8, 9);
                        int r = rnd.Next(1, 6);
                        list.Add(new Circle(x, y, r));
                        break;
                    }
                    case 1:
                    {
                        int x = rnd.Next(-8, 9);
                        int y = rnd.Next(-8, 9);
                        list.Add(new Point(x, y));
                        break;
                    }

                    case 2:
                    {
                        int x = rnd.Next(-8, 9);
                        int y = rnd.Next(-8, 9);
                        int a = rnd.Next(1, 11);
                        list.Add(new Square(x, y, a));
                        break;
                    }
                }
            }

            drawStuff();

            fillFields();
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
                switch (methodsCB.SelectedIndex)
                {
                    case 0:
                    {
                        paramNumber.Maximum = 10;
                        break;
                    }
                    case 1:
                    {
                        paramNumber.Maximum = 5;
                        break;
                    }
                    case 2:
                    {
                        paramNumber.Maximum = 100;
                        break;
                    }
                }
            }
        }

        private Bitmap DrawArea;

        private void drawStuff()
        {
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            Random rnd = new Random();
            Graphics g;
            g = Graphics.FromImage(DrawArea);

            Pen mypen = new Pen(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255)));
            mypen.Color = Color.Black;
            
            SolidBrush myBrush = new SolidBrush(Color.Blue);
            
            SolidBrush pointBrish = new SolidBrush(Color.Black);
            
            g.DrawLine(mypen, new System.Drawing.Point(DrawArea.Width / 2, 0),
                new System.Drawing.Point(DrawArea.Width / 2, DrawArea.Height));
            g.DrawLine(mypen, new System.Drawing.Point(0, DrawArea.Height / 2),
                new System.Drawing.Point(DrawArea.Width, DrawArea.Height / 2));

            for (int y = 0; y <= 400; y += 10)
            {
                g.FillEllipse(pointBrish,
                    new System.Drawing.Rectangle((pictureBox1.Width / 2) - 2, y,
                        4,
                        4));
                
                g.FillEllipse(pointBrish, new System.Drawing.Rectangle(y, pictureBox1.Width / 2,
                    4,
                    4));
            }
            
            
            
            Font font = new Font(FontFamily.GenericSerif, 10);

            int i = 1;
            foreach (Figure fig in list)
            {
                mypen.Color = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                myBrush.Color = mypen.Color;
                if (fig is Square)
                {
                    Square sqr = (Square) fig;
                    int x = sqr.X * 10;
                    int y = -sqr.Y * 10;
                    int a = (int) Math.Round(sqr.A) * 10;

                    g.DrawString(i.ToString(), font, myBrush, new PointF(pictureBox1.Width / 2 + (x - a / 2), pictureBox1.Width / 2 + (y - a / 2)));
                    
                    g.DrawRectangle(mypen, pictureBox1.Width / 2 + (x - a / 2), pictureBox1.Width / 2 + (y - a / 2), a,
                        a);
                }
                else if (fig is Circle)
                {
                    Circle crq = (Circle) fig;
                    int x = crq.X * 10;
                    int y = -crq.Y * 10;
                    int r = (int) Math.Round(crq.R) * 10;

                    g.DrawString(i.ToString(), font, myBrush,
                        new PointF(pictureBox1.Width / 2 + (x - r / 2), pictureBox1.Width / 2 + (y - r / 2)));
                    g.DrawEllipse(mypen,
                        new System.Drawing.Rectangle(pictureBox1.Width / 2 + (x - r),
                            pictureBox1.Width / 2 + (y - r), r * 2, r * 2));
                }
                else
                {
                    int x = fig.X * 10;
                    int y = -fig.Y * 10;
                    g.DrawString(i.ToString(), font, myBrush,
                        new PointF(pictureBox1.Width / 2 + (x / 2) + 5, pictureBox1.Width / 2 + (y / 2) + 5));
                    g.FillEllipse(myBrush,
                        new System.Drawing.Rectangle(pictureBox1.Width / 2 + x, pictureBox1.Width / 2 + y,
                            5,
                            5));
                }

                i++;
            }

            pictureBox1.Image = DrawArea;
            g.Dispose();
        }

        private void fillFields()
        {
            string figs = "";
            int i = 0;
            foreach (Figure fig in list)
            {
                i++;
                if (fig is Point)
                {
                    figs += i + ". Point;x=" + fig.X + "; y=" + fig.Y + "; S=" + fig.S + "; zeroIn " + fig.ZeroIn();
                    figs += "\n";
                }
                else if (fig is Square)
                {
                    figs += i + ". Square; x=" + fig.X + "; y=" + fig.Y + "; s=" + fig.S + "; zeroIn " + fig.ZeroIn() +
                            "; A=" + ((Square) fig).A;
                    figs += "\n";
                }
                else if (fig is Circle)
                {
                    figs += i + ". Circle; x=" + fig.X + "; y=" + fig.Y + "; s=" + fig.S + "; zeroIn " + fig.ZeroIn() +
                            "; R=" + ((Circle) fig).R;
                    figs += "\n";
                }
            }

            figsTB.Text = figs;
        }

        private void chagneButton_Click(object sender, EventArgs e)
        {
            switch (methodsCB.SelectedIndex)
            {
                case 0:
                {
                    aEquals();
                    break;
                }
                case 1:
                {
                    rEquals();
                    break;
                }
                case 2:
                {
                    sEquals();
                    break;
                }
                case 3:
                {
                    moveTo();
                    break;
                }
                case 4:
                {
                    moveRel();
                    break;
                }
            }

            fillFields();
            drawStuff();
        }

        private void aEquals()
        {
            foreach (Figure fig in list)
            {
                if (fig is Square)
                {
                    if (paramsCB.SelectedIndex == 0)
                    {
                        (fig as Square).A = rnd.Next(0, 11);
                    }
                    else
                    {
                        (fig as Square).A = (int) paramNumber.Value;
                    }
                }
            }
        }

        private void rEquals()
        {
            foreach (Figure fig in list)
            {
                if (fig is Circle)
                {
                    if (paramsCB.SelectedIndex == 0)
                    {
                        (fig as Circle).R = rnd.Next(0, 6);
                    }
                    else
                    {
                        (fig as Circle).R = (int) paramNumber.Value;
                    }
                }
            }
        }

        private void sEquals()
        {
            if (paramsCB.SelectedIndex == 0)
            {
                foreach (Figure fig in list)
                {
                    fig.S = rnd.Next(0, 101);
                }
            }
            else
            {
                foreach (Figure fig in list)
                {
                    fig.S = (double) paramNumber.Value;
                }
            }
        }

        private void moveTo()
        {
        }

        private void moveRel()
        {
        }
    }
}