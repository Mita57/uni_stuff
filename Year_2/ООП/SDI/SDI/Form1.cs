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
            detka.Text = "Detka " + amountOfDetkas;
            amountOfDetkas++;
            detka.Show();
            comboBox1.Items.Add(detka.Text);
            detkas.Add(detka);
            textBox1.Text = "Detka " + (amountOfDetkas - 1);
            label3.Text = "Позишн " + detka.Left + "; " +  detka.Top;
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
                foreach (Detka ded in detkas)
                {
                    ded.Visible = detkaVisibilityCB.Checked;
                }
            }
            else
            {
                try
                {
                    int num = Convert.ToInt32(comboBox1.Text.Split(' ')[1]);
                    detkas[num].Visible = detkaVisibilityCB.Checked;
                }
                catch { }
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
                try
                {
                    int num = Convert.ToInt32(comboBox1.Text.Split(' ')[1]);
                    detkas[num].Height = Convert.ToInt32(heightUD.Value);
                }
                catch { }
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
                try
                {
                    int num = Convert.ToInt32(comboBox1.Text.Split(' ')[1]);
                    detkas[num].Width = Convert.ToInt32(widthUD.Value);
                }
                catch { }
            }
        }

        private void KillDetkaButton_Click(object sender, EventArgs e)
        {
            if (allRb.Checked)
            {
                for(int i = 0; i < detkas.Count; i++)
                {
                    detkas[i].Close();
                }
                detkas.Clear();
                comboBox1.Items.Clear();
                amountOfDetkas = 0;
            }
            else
            {
                try
                {
                    int num = Convert.ToInt32(comboBox1.Text.Split(' ')[1]);
                    detkas[num].Close();
                    comboBox1.Items.Remove(comboBox1.SelectedItem);
                    comboBox1.SelectedIndex = -1;
                    detkas.Remove(detkas[num]);
                    amountOfDetkas--;
                }
                catch
                {

                }
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
            label3.Text = "Позишн " + detkas[num].Left + "; "+ detkas[num].Top;
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
            try
            {
                label3.Text = "Позишн " + detkas[0].Left + "; " + detkas[0].Top;
            }
            catch
            {

            }
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

        private void HdrButton_Click(object sender, EventArgs e)
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

        public void detkaResize(int left, int top, string cock)
        {
            if (allRb.Checked)
            {
                int num = Convert.ToInt32(cock.Split(' ')[1]);
                if(num == 0)
                {
                    label3.Text = "Позишн: " + left + ", " + top;
                }
            }
            else
            {
                try
                {
                    int numba = Convert.ToInt32(comboBox1.Text.Split(' ')[1]);
                    int num = Convert.ToInt32(cock.Split(' ')[1]);
                    if (num == numba)
                    {
                        label3.Text = "Позишн: " + left + ", " + top;
                    }
                }
                catch { }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to close " + this.Text + "?", "Fucking Slave", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void removeCB(int index)
        {
            try
            {
                comboBox1.Items.RemoveAt(index);
            }
            catch
            {
                comboBox1.Items.Clear();
            }
        }
    }
}
