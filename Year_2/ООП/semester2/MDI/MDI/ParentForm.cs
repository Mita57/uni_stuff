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
    }
}
