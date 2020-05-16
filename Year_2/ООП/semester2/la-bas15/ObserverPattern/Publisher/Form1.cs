using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;

namespace Publisher
{
    public partial class Form1 : Form
    {
        List<SubForm> forms = new List<SubForm>();
        private int subsCount = 0;

        public void printMagazines(Object source, System.Timers.ElapsedEventArgs e)
        {
            string res = "";
            foreach (Publication pub in Program.pubs)
            {
                res += pub.releaseMagazine();
            }

            this.textBox1.Text += res;
        }

        public void printNewspapers(Object source, System.Timers.ElapsedEventArgs e)
        {
            string res = "";
            foreach (Publication pub in Program.pubs)
            {
                pub.releaseNewspaper();
            }

            this.textBox1.Text += res;
        }


        public Form1()
        {
            InitializeComponent();
            Timer magTimer = new Timer();
            magTimer.Elapsed += printMagazines;
            magTimer.Interval = 2000;
            magTimer.Enabled = true;
            Timer newsTimer = new Timer();
            newsTimer.Elapsed += printNewspapers;
            newsTimer.Interval = 14000;
            newsTimer.Enabled = true;
        }

        private void createSubBtn_Click(object sender, EventArgs e)
        {
            SubForm sub = new SubForm(this);
            subsCount++;
            sub.Text = "Подписчек " + subsCount;
            sub.Tag = subsCount;
            forms.Add(sub);
            sub.Show();
            fillSubsListBox();
        }

        private void fillSubsListBox()
        {
            subsListBox.Items.Clear();
            foreach (SubForm subF in forms)
            {
                subsListBox.Items.Add(subF.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (SubForm subF in forms)
            {
                if (subF.Tag.ToString() == subsListBox.SelectedItem.ToString().Split(' ')[1])
                {
                    forms.Remove(subF);
                    break;
                }
            }

            fillSubsListBox();
        }

        private void createPubBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(pubNameTB.Text))
            {
                string type = newspaperRB.Checked ? "newspaper" : "magazine";
                Publication pub = new Publication(type, pubNameTB.Text);
                Program.pubs.Add(pub);
                fillPubsListBox();
            }
            else
            {
                MessageBox.Show("Fill the field");
            }
        }

        private void fillPubsListBox()
        {
            this.pubsListBox.Items.Clear();
            foreach (Publication pub in Program.pubs)
            {
                pubsListBox.Items.Add(pub.ToString());
            }

            foreach (SubForm sub in forms)
            {
                sub.fillPubsListBox();
            }
        }

        private void cancelProdBtn_Click(object sender, EventArgs e)
        {
            foreach (Publication pub in Program.pubs)
            {
                if (pub.ToString() == pubsListBox.SelectedItem.ToString())
                {
                    Program.pubs.Remove(pub);
                    break;
                }
            }
        }

        private void pauseProdBtn_Click(object sender, EventArgs e)
        {
            foreach (Publication pub in Program.pubs)
            {
                if (pub.ToString() == pubsListBox.SelectedItem.ToString())
                {
                    pub.stop();
                    break;
                }
            }
        }

        private void resumeBtn_Click(object sender, EventArgs e)
        {
            foreach (Publication pub in Program.pubs)
            {
                if (pub.ToString() == pubsListBox.SelectedItem.ToString())
                {
                    pub.start();
                    break;
                }
            }
        }
    }
}