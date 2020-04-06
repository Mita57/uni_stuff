using System;
using System.IO;
using System.Windows.Forms;

namespace MDI
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
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
                this.label1.Text = path;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            File.WriteAllText((string)this.Tag, textBox1.Text);
        }
    }
}
