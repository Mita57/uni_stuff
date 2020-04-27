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
            string newLine = Environment.NewLine;
            foreach (ChildForm child in Program.parentForm.MdiChildren)
            {
                textBox1.Text += "Название" + child.Text + newLine;
                textBox1.Text += "Создана" + child.created + newLine;
                try
                {
                    textBox1.Text += "Последнее сохранение" + child.changed + newLine;
                }
                catch
                {
                    
                }
                
                int stringCounter = 0;
                string strings = "1. ";
                foreach (char rar in child.Controls["textBox1"].Text)
                {
                    if (rar == '\n')
                    {
                        stringCounter++;
                        if (stringCounter <= 4)
                        {
                            strings += newLine + (stringCounter + 1);
                        }
                    }
                    else
                    if(stringCounter < 5)
                    {
                        strings += rar;
                    }
                }

                textBox1.Text += "Кол-во строк:" + newLine;
                if (strings == "1. ")
                {
                    strings = "";
                }
                else
                {
                    textBox1.Text += strings;
                }

                textBox1.Text += "_________________________________________" + newLine;
            }
        }

        private void ListFromOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        
    }
}