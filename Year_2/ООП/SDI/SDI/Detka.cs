using System;
using System.Windows.Forms;

namespace SDI
{
    public partial class Detka : Form
    {
        public Detka()
        {
            InitializeComponent();
            Detka_Resize(null, null);
            Form1 mamka = null;
            Aboot aboot = null;
            foreach (Form X in Application.OpenForms)
            {
                if (X is Form1)
                {
                    mamka = (Form1)X;
                }
                if(X is Aboot)
                {
                    aboot = (Aboot)X;
                }
            }
            Mamka_resize(mamka.Width, mamka.Height);
            try
            {
                about_resize(aboot.Width, aboot.Height);
            }
            catch
            {

            }
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
