using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
