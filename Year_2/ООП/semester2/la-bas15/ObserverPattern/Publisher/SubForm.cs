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
    }
}