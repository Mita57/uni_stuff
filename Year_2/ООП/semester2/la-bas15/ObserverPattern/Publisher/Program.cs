using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publisher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static List<Publication> pubs = new List<Publication>();

    }

    public class Publication
    {
        private string type = "";
        private string name = "";
        private bool enabled = true;

        public Publication(string type, string name)
        {
            this.type = type;
            this.name = name;
        }

        public void stop()
        {
            this.enabled = false;
        }

        public void start()
        {
            this.enabled = true;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}