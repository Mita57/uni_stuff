using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
        private List<SubForm> subs = new List<SubForm>();
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

        public void subscribe(SubForm form)
        {
            this.subs.Add(form);
        }

        public void unsubscribe(SubForm form)
        {
            this.subs.Remove(form);
        }

        public string releaseNewspaper()
        {
            string res = "";
            foreach (SubForm sub in subs)
            {
                if (enabled && this.type == "newspaper")
                {
                    sub.getStuff(this);
                }

                res += this.name;
            }

            return res;
        }

        public string releaseMagazine()
        {
            string res = "";
            foreach (SubForm sub in subs)
            {
                if (enabled && this.type == "magazine")
                {
                    sub.getStuff(this);
                }

                res += this.name;
            }

            return res;
        }
    }
}