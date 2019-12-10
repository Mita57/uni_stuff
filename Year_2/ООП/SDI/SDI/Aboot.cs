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
    }
}
