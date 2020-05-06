using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class Form2 : Form
    {
        private Form1 mainf;
        public Form2(Form f)
        {
            InitializeComponent();
            mainf = (Form1) f;
        }

        public void action1()
        {
            Color c = BackColor;
            BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);
            BackColor = c;
            Refresh();
            Thread.Sleep(500);
        }

        public void action2()
        {
            
        }
    }
}