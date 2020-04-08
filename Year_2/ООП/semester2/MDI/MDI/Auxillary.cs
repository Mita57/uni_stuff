using System;
using System.Collections.Generic;
using System.Threading;
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

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.parentForm.MdiChildren.Length; i++)
            {
                if (Program.parentForm.MdiChildren[i].Text == comboBox1.SelectedItem.ToString())
                {
                    nameTB.Text = Program.parentForm.MdiChildren[i].Text;
                    sizeTB.Text = Program.parentForm.MdiChildren[i].Size.Height + "; " + Program.parentForm.MdiChildren[i].Size.Width;
                    MDICoordsTB.Text = Program.parentForm.MdiChildren[i].Location.X + "; " + Program.parentForm.MdiChildren[i].Location.Y;
                    scrSizeTB.Text = (Program.parentForm.Location.X + Program.parentForm.MdiChildren[i].Location.X) + "; " 
                        + (Program.parentForm.Location.Y + Program.parentForm.MdiChildren[i].Location.Y); 
                    string cock = (string) Program.parentForm.MdiChildren[i].Tag;
                    try
                    {
                        fileTB.Text = cock.Split('\\')[cock.Split('\\').Length - 1];
                    }
                    catch
                    {
                        fileTB.Text = "Ничего";
                    }

                    int stringCounter = 0;
                    foreach (char rar in Program.parentForm.MdiChildren[i].Controls["textBox1"].Text)
                    {
                        if (rar == '\n')
                        {
                            stringCounter++;
                        }
                    }

                    stringsTB.Text = stringCounter.ToString();
                    break;
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