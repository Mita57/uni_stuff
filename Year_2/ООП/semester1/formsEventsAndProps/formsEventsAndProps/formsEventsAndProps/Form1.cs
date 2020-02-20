using System;
using System.Drawing;
using System.Windows.Forms;

namespace formsEventsAndProps
{
    public partial class Form1 : Form
    {
        bool changeColor = true;
        string header = "Л.Р №2 Мячиков Тимофей";
        bool showColors = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(this, "Моя первая формОчка");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (changeColor)
            {
                var relativePoint = this.PointToClient(Cursor.Position);
                double r = relativePoint.X * ((double)255 / (double)this.Width);
                double b = relativePoint.Y * ((double)255 / (double)this.Height);
                double diagonal = Math.Sqrt((this.Width * this.Width) + (this.Height * this.Height));
                double g = Convert.ToInt32(Math.Round(r * b / 255));
                this.BackColor = Color.FromArgb(Convert.ToInt32(r), Convert.ToInt32(g), Convert.ToInt32(b));

                if (showColors)
                {
                    this.Text = "(" + Math.Round(r).ToString() + ", " + Math.Round(g).ToString() + ", " + Math.Round(b).ToString() + ") "  + header;
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //color stuff
            if(e.KeyCode == Keys.C && Control.ModifierKeys == (Keys.Control | Keys.Alt))
            {
                changeColor = !changeColor;
            }
            //header stuff
            if(e.KeyCode == Keys.D && Control.ModifierKeys == Keys.Control)
            {
                showColors = !showColors;
                if(showColors == false)
                {
                    this.Text = header;
                }
            }
            //closing stuff
            if (e.KeyCode == Keys.X && Control.ModifierKeys == Keys.Alt || e.KeyCode == Keys.F10)
            {
                closeStuff();
            }
            //moving up
            if(e.KeyCode == Keys.Up & Control.ModifierKeys == Keys.None)
            {
                if (this.Top > 0)
                {
                    this.Top -= 5;
                }
            }
            //moving down
            if (e.KeyCode == Keys.Down & Control.ModifierKeys == Keys.None)
            {
                if(this.Top < Screen.PrimaryScreen.Bounds.Height - this.Height)
                this.Top += 5;
            }
            //moving left
            if (e.KeyCode == Keys.Left & Control.ModifierKeys == Keys.None)
            {
                if (this.Left > 0)
                {
                    this.Left -= 5;
                }
            }
            //moving right
            if (e.KeyCode == Keys.Right & Control.ModifierKeys == Keys.None)
            {
                if (this.Right < Screen.PrimaryScreen.Bounds.Width)
                {
                    this.Left += 5;
                }
            }
            //moving to the center of the screen
            if(e.KeyCode == Keys.Space & Control.ModifierKeys == Keys.None)
            {
                this.CenterToScreen();
            }
            //moving to the top of the screen
            if (e.KeyCode == Keys.Up && Control.ModifierKeys == Keys.Alt)
            {
                this.Top = 0;
            }
            //moving to the left of the screen
            if (e.KeyCode == Keys.Left && Control.ModifierKeys == Keys.Alt)
            {
                this.Left = 0;
            }
            //moving to the right of the screen
            if (e.KeyCode == Keys.Right && Control.ModifierKeys == Keys.Alt)
            {
                this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
            }
            //moving to the bottom of the screen
            if (e.KeyCode == Keys.Down && Control.ModifierKeys == Keys.Alt)
            {
                this.Top = Screen.PrimaryScreen.Bounds.Height - this.Height;
            }
            //increasing the opacity
            if (e.KeyCode == Keys.Up && Control.ModifierKeys == Keys.Control)
            {
                this.Opacity += 0.05;
            }
            //decreasing the opacity
            if (e.KeyCode == Keys.Down && Control.ModifierKeys == Keys.Control)
            {
                this.Opacity -= 0.05;
            }
        }


        //also closing stuff
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            closeStuff();
        }

        private void closeStuff()
        {
            DialogResult dialogResult = MessageBox.Show("U sure u wanna leave? I no where u live", "TY CHO PES", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //shrinking this MF
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right & Control.ModifierKeys == Keys.None)
            {
                this.Height -= 5;
                this.Width -= 5;
                string cock =" W:"+this.Width + ", H:" + this.Height; 
                this.Text = header + cock;
            }
            //expanding this MF
            if (me.Button == MouseButtons.Right & Control.ModifierKeys == Keys.Shift)
            {
                this.Height += 5;
                this.Width += 5;
                string cock = " W:" + this.Width + ", H:" + this.Height;
                this.Text = header + cock;
            }
            //centering at the pointer
            if (me.Button == MouseButtons.Middle)
            {
                this.Left = Cursor.Position.X - this.Width/2;
                this.Top = Cursor.Position.Y - this.Height/2;
            }
        }
        //painting the color yellow when the mouse leaves
        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            if (changeColor)
            {
                this.BackColor = Color.Yellow;
            }
        }
    }
}
