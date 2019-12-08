using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SDI
{
    public partial class Form1 : Form
    {
        static int amountOfDetkas = 0;
        static List<Detka> detkas = new List<Detka>();
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenDetkaButton_Click(object sender, EventArgs e)
        {
            Detka detka = new Detka();
            detka.Name = "Detka " + amountOfDetkas;
            amountOfDetkas++;
            detka.Show();
            comboBox1.Items.Add(detka.Name);
            detkas.Add(detka);
            textBox1.Text = detka.Name;
            heightUD.Value = detka.Height;
            widthUD.Value = detka.Width;
            detkaVisibilityCB.Checked = true;
        }

        Aboot aboot;

        private void AboutOpenButton_Click(object sender, EventArgs e)
        {
            aboot = new Aboot();
            aboot.ShowDialog();
        }

        private void AbootVisibilityCB_CheckedChanged(object sender, EventArgs e)
        {
            //what's the point of me exsitence if I'm opened in a dialog form?
            try
            {
                aboot.Visible = !aboot.Visible;
            }
            catch
            {

            }
        }

        private void DetkaVisibilityCB_CheckedChanged(object sender, EventArgs e)
        {
            if (allRb.Checked)
            {
                foreach(Detka ded in detkas)
                {
                    ded.Visible = detkaVisibilityCB.Checked;
                }
            }
            else
            {
                int num = Convert.ToInt32(comboBox1.Text.Split(' ')[1]);
                detkas[num].Visible = detkaVisibilityCB.Checked;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (allRb.Checked)
            {
                foreach (Detka ded in detkas)
                {
                    ded.Text = textBox1.Text;
                }
            }
            else
            {
                int num = Convert.ToInt32(comboBox1.Text.Split(' ')[1]);
                detkas[num].Text = textBox1.Text;
            }
        }

        private void HeightUD_ValueChanged(object sender, EventArgs e)
        {
            if (allRb.Checked)
            {
                foreach (Detka ded in detkas)
                {
                    ded.Height = Convert.ToInt32(heightUD.Value);
                }
            }
            else
            {
                int num = Convert.ToInt32(comboBox1.Text.Split(' ')[1]);
                detkas[num].Height = Convert.ToInt32(heightUD.Value);
            }
        }

        private void WidthUD_ValueChanged(object sender, EventArgs e)
        {
            if (allRb.Checked)
            {
                foreach (Detka ded in detkas)
                {
                    ded.Width = Convert.ToInt32(widthUD.Value);
                }
            }
            else
            {
                int num = Convert.ToInt32(comboBox1.Text.Split(' ')[1]);
                detkas[num].Width = Convert.ToInt32(widthUD.Value);
            }
        }

        private void KillDetkaButton_Click(object sender, EventArgs e)
        {
            if (allRb.Checked)
            {
                foreach (Detka ded in detkas)
                {
                    ded.Close();
                    detkas.Remove(ded);
                }
            }
            else
            {
                int num = Convert.ToInt32(comboBox1.Text.Split(' ')[1]);
                detkas[num].Close();
                detkas.Remove(detkas[num]);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Color color = colorDialog1.Color;
            if (allRb.Checked)
            {
                foreach (Detka ded in detkas)
                {
                    ded.BackColor = color;
                }
            }
            else
            {
                int num = Convert.ToInt32(comboBox1.Text.Split(' ')[1]);
                detkas[num].BackColor = color;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(comboBox1.Text.Split(' ')[1]);
            textBox1.Text = detkas[num].Name;
            heightUD.Value = detkas[num].Height;
            widthUD.Value = detkas[num].Width;
            switch (detkas[num].WindowState)
            {
                case FormWindowState.Normal:
                    {
                        radioButton1.Checked = false;
                        radioButton2.Checked = true;
                        radioButton3.Checked = false;
                        break;
                    }
                case FormWindowState.Minimized:
                    {
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton1.Checked = true;
                        break;
                    }
                case FormWindowState.Maximized:
                    {
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = true;
                        break;
                    }
            }
        }

        private void AllRb_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
        }

        private void OneRB_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        private void DetkaVisibilityCB_Resize(object sender, EventArgs e)
        {
            foreach (Detka ded in detkas)
            {
                ded.Mamka_resize(this.Width, this.Height);
            }
        }
    }
}
