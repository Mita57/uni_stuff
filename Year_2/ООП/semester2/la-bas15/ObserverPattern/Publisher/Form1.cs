using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Publisher
{
    public partial class Form1 : Form
    {
        List<SubForm> forms = new List<SubForm>();
        private int subsCount = 0;


        public Form1()
        {
            InitializeComponent();
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
            }

            fillPubsListBox();
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