using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        public void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm();
            child.MdiParent = this;
            child.Text += " " + MdiChildren.Length.ToString();
            child.Show();
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
    }
}
