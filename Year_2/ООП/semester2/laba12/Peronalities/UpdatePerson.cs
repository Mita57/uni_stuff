using System.Windows.Forms;

namespace Peronalities
{
    public partial class UpdatePerson : Form
    {
        public UpdatePerson()
        {
            InitializeComponent();
        }

        private void UpdatePerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}