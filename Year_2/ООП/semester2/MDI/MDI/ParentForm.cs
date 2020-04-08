using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class FrameForm : Form
    {
        public FrameForm()
        {
            InitializeComponent();
            Program.parentForm = this;
        }

        public void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm();
            child.MdiParent = this;
            child.Text += " " + Program.forms;
            Program.forms++;
            child.Show();
            try
            {
                Program.auxForm.updateCB();
            }
            catch
            {
            }
        }

        private void casccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        private void mnimizeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ChildForm child in MdiChildren)
            {
                child.WindowState = FormWindowState.Minimized;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                this.newToolStripMenuItem_Click(sender, e);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            foreach (ChildForm form in MdiChildren)
            {
                if (String.IsNullOrEmpty((string)form.Tag))
                {
                    form.toolStripMenuItem3_Click(null, null);
                }
                else
                {
                    form.toolStripMenuItem1_Click(null, null);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = openFileDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                ChildForm child = new ChildForm();
                child.MdiParent = this;
                child.Text += " " + Program.forms;
                Program.forms++;
                child.Controls["textBox1"].Text = File.ReadAllText(path);
                child.Controls["label1"].Text = path;
                child.Tag = path;
                child.Show();
                try
                {
                    Program.auxForm.updateCB();
                }
                catch
                {
                }
            }
            
        }

        private void restoreAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ChildForm child in MdiChildren)
            {
                child.WindowState = FormWindowState.Maximized;
            }
        }

        private void ckiseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ChildForm child in MdiChildren)
            {
                child.Close();
            }
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

        private void setRandomColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            foreach (ChildForm child in MdiChildren)
            {
                child.BackColor = Color.FromArgb(rnd.Next(127, 256), rnd.Next(127, 256), rnd.Next(127, 256));
            }
        }

        private void setPinkColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.BackColor = Color.Magenta;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.auxForm == null)
            {
                Program.auxForm = new Auxillary();
                Program.auxForm.Show();
                Program.auxForm.updateCB();
            }
            else
            {
                Program.auxForm.Show();
                Program.auxForm.Focus();
                Program.auxForm.updateCB();
            }
        }

        private void FrameForm_LocationChanged(object sender, EventArgs e)
        {
            try
            {
                Program.auxForm.comboBox1_SelectedIndexChanged(null, null);
            }
            catch (Exception exception)
            {
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Program.list == null)
            {
                ListFromOrder list = new ListFromOrder();
                list.Show();
                Program.list = list;
            }
            else
            {
                Program.list.Show();
                Program.list.Focus();
            }
        }
    }
}
