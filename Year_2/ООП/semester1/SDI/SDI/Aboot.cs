using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SDI
{
    public partial class Aboot : Form
    {
        public Aboot()
        {
            InitializeComponent();
        }

        private void Aboot_Resize(object sender, EventArgs e)
        {
            List<Detka> kids = new List<Detka>();
            for(int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i] is Detka)
                {
                    Detka cock = (Detka)Application.OpenForms[i];
                    cock.about_resize(this.Width, this.Height);
                }
            }
        }

        private void Aboot_Load(object sender, EventArgs e)
        {
            List<Detka> kids = new List<Detka>();
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i] is Detka)
                {
                    Detka cock = (Detka)Application.OpenForms[i];
                    cock.about_resize(this.Width, this.Height);
                }
            }
        }
    }
}
