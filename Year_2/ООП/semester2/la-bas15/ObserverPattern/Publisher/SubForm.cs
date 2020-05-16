using System.Windows.Forms;

namespace Publisher
{
    public partial class SubForm : Form
    {
        private Form1 parentForm = null;
        public SubForm(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        public override string ToString()
        {
            return "Подписчек " + this.Tag;
        }

        public void fillPubsListBox()
        {
            this.pubsListBox.Items.Clear();
            foreach (Publication pub in Program.pubs)
            {
                pubsListBox.Items.Add(pub.ToString());
            }
        }
    }
}