using System;
using System.Windows.Forms;

namespace MDI
{
    public partial class ListFromOrder : Form
    {
        public ListFromOrder()
        {
            InitializeComponent();
        }

        public void ListFromOrder_Load(object sender, EventArgs e)
        {
            foreach (ChildForm child in Program.parentForm.MdiChildren)
            {
                textBox1.Text += "Название" + child.Text + "\n";
                textBox1.Text += "Создана" + child.created + "\n";
                try
                {
                    textBox1.Text += "Последнее сохранение" + child.changed + "\n";
                }
                catch{}
                
                int stringCounter = 0;
                string strings = "1. ";
                foreach (char rar in child.Controls["textBox1"].Text)
                {
                    if (rar == '\n')
                    {
                        stringCounter++;
                        if (stringCounter <= 4)
                        {
                            strings += "\n" + (stringCounter + 1);
                        }
                    }
                    else
                    if(stringCounter < 5)
                    {
                        strings += rar;
                    }
                }

                textBox1.Text += "Кол-во строк:" + "\n";
                if (strings == "1. ")
                {
                    strings = "";
                }
                else
                {
                    textBox1.Text += strings;
                }
            }
        }

        private void ListFromOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}