using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Length
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool ignoreEvents = false;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (ignoreEvents)
            {
                return;
            }
            try
            {
                TextBox cox = (TextBox)sender;
                double metres = Convert.ToDouble(cox.Text);
                cox.ForeColor = Color.Black;
                ignoreEvents = true;
                sazhenTextBox.Text = (metres / 2.1336).ToString();
                yardsTextBox.Text = (metres / 0.9144).ToString();
                ignoreEvents = false;

            }
            catch
            {
                TextBox cox = (TextBox)sender;
                if (String.IsNullOrEmpty(cox.Text))
                {
                    sazhenTextBox.Text = "";
                    yardsTextBox.Text = "";
                }
                else
                {
                    cox.ForeColor = Color.Red;
                }
            }
        }

        private void SazhenTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ignoreEvents)
            {
                return;
            }
            try
            {
                TextBox cox = (TextBox)sender;
                double SAZHEN = Convert.ToDouble(cox.Text);
                cox.ForeColor = Color.Black;
                ignoreEvents = true;
                metresTextBox.Text = (SAZHEN * 2.1336).ToString();
                yardsTextBox.Text = (SAZHEN * 2.33333333333333333333333).ToString();
                ignoreEvents = false;
            }
            catch
            {
                TextBox cox = (TextBox)sender;
                if (String.IsNullOrEmpty(cox.Text))
                {
                    metresTextBox.Text = "";
                    yardsTextBox.Text = "";
                }
                else
                {
                    cox.ForeColor = Color.Red;
                }
            }
        }

        private void YardsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ignoreEvents)
            {
                return;
            }
            try
            {
                TextBox cox = (TextBox)sender;
                double yard = Convert.ToDouble(cox.Text);
                cox.ForeColor = Color.Black;
                ignoreEvents = true;
                metresTextBox.Text = (yard * 0.9144).ToString();
                yardsTextBox.Text = (yard * 0.42).ToString();
                ignoreEvents = false;
            }
            catch
            {
                TextBox cox = (TextBox)sender;
                if (String.IsNullOrEmpty(cox.Text))
                {
                    sazhenTextBox.Text = "";
                    metresTextBox.Text = "";
                }
                else
                {
                    cox.ForeColor = Color.Red;
                }
            }
        }
    }
}
