using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}