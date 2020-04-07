using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MDI
{
    public partial class Auxillary : Form
    {
        public Auxillary()
        {
            InitializeComponent();
        }

        public void updateCB()
        {
            comboBox1.Items.Clear();
            foreach (ChildForm child in Program.parentForm.MdiChildren)
            {
                comboBox1.Items.Add(child.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ChildForm child in Program.parentForm.MdiChildren)
            {
                if (child.Name == comboBox1.SelectedText)
                {
                    nameTB.Text = child.Text;
                    sizeTB.Text = child.Size.Height + "; " + child.Size.Width;
                    MDICoordsTB.Text = child.Location.X + "; " + child.Location.Y;
                    string cock = (string) child.Tag;
                    this.fileTB.Text = cock.Split('/')[cock.Split('/').Length - 1];
                }
            }
        }

        private void Auxillary_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}