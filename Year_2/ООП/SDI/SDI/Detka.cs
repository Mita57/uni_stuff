using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDI
{
    public partial class Detka : Form
    {
        public Detka()
        {
            InitializeComponent();
        }

        private void Detka_Resize(object sender, EventArgs e)
        {
            textBox2.Text = this.Width.ToString();
            textBox1.Text = this.Height.ToString();
        }

        public void Mamka_resize(int width, int height)
        {
            textBox4.Text = height.ToString();
            textBox3.Text = width.ToString();
        }

        public void about_resize(int width, int height)
        {
            textBox6.Text = height.ToString();
            textBox5.Text = width.ToString();
        }
    }
}
