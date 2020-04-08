using System;
using System.IO;
using System.Windows.Forms;

namespace MDI
{
    public partial class ChildForm : Form
    {
        
        public readonly DateTime created;
        public  DateTime changed;
        
        public ChildForm()
        {
            InitializeComponent();
            created = DateTime.Now;
        }
        
        

        public void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult = saveFileDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                File.WriteAllText(path, textBox1.Text);
                this.Tag = path;
                this.toolStripMenuItem1.Enabled = true;
                this.label1.Text = path.Split('\\')[path.Split('\\').Length - 1];
                ChildForm_ResizeEnd(null, null);
                changed = DateTime.Now;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                Program.auxForm.updateCB();
            }
            catch
            {
            }

            try
            {
                Program.list.ListFromOrder_Load(null, null);
            }
            catch
            {
            }
        }

        public void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            File.WriteAllText((string)this.Tag, textBox1.Text);
            changed = DateTime.Now;
        }


        private void ChildForm_ResizeEnd(object sender, EventArgs e)
        {
            try
            {
                Program.auxForm.comboBox1_SelectedIndexChanged(null, null);
            }
            catch (Exception exception)
            {
            }
            textBox1.Height = this.Height - 90;
            textBox1.Width = this.Width - 16;
        }

        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Program.auxForm.updateCB();
            }
            catch
            {
            }

            try
            {
                Program.list.ListFromOrder_Load(null, null);
            }
            catch
            {
            }
        }
    }
}
