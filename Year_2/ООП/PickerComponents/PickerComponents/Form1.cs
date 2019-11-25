using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickerComponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            oneNumberRadio.Checked = true;
        }
        
        private void OneNumberRadio_CheckedChanged(object sender, EventArgs e)
        {
            secondNumberGroupBox.Visible = false;
            binaryOpsGroupBox.Visible = false;
            unaryOperationGroupBox.Visible = true;
        }

        private void TwoNumbersRadio_CheckedChanged(object sender, EventArgs e)
        {
            secondNumberGroupBox.Visible = true;
            binaryOpsGroupBox.Visible = true;
            unaryOperationGroupBox.Visible = false;
        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            int lal = getOperandsInput();

            if(lal == -1)
            {
                MessageBox.Show("Выбери количество операндов");
            }
            else
            {
                if(lal == 0)
                {
                    doUnaryOperaion();
                }
                else
                {
                    doBinaryOperaion();
                }
            }
        }


        private void doUnaryOperaion()
        {
            resultLabel.Visible = false;
            int op = getUnaryOperation();
            switch (op)
            {
                case -1:
                    {
                        MessageBox.Show("Выбери унарную операцию");
                        break;
                    }
                case 0:
                    {
                        resultTextBox.Text = Math.Sin(Convert.ToDouble(firstNumberTextBox.Text)).ToString();
                        if (formulaCheckBox.Checked)
                        {
                            resultLabel.Text = "Sin(" + firstNumberTextBox.Text +") = " +resultTextBox.Text;
                            resultLabel.Visible = true;
                        }
                        break;
                    }
                case 1:
                    {
                        resultTextBox.Text = Math.Cos(Convert.ToDouble(firstNumberTextBox.Text)).ToString();
                        if (formulaCheckBox.Checked)
                        {
                            resultLabel.Text = "Cos(" + firstNumberTextBox.Text + ") = " + resultTextBox.Text;
                            resultLabel.Visible = true;
                        }
                        break;
                    }
                case 2:
                    {
                        resultTextBox.Text = Math.Tan(Convert.ToDouble(firstNumberTextBox.Text)).ToString();
                        if (formulaCheckBox.Checked)
                        {
                            resultLabel.Text = "Tan(" + firstNumberTextBox.Text + ") = " + resultTextBox.Text;
                            resultLabel.Visible = true;
                        }
                        break;
                    }
                case 3:
                    {
                        resultTextBox.Text = (Math.Cos(Convert.ToDouble(firstNumberTextBox.Text))/Math.Sin
                            (Convert.ToDouble(firstNumberTextBox.Text))).ToString();
                        if (formulaCheckBox.Checked)
                        {
                            resultLabel.Text = "Ctg(" + firstNumberTextBox.Text + ") = " + resultTextBox.Text;
                            resultLabel.Visible = true;
                        }
                        break;
                    }
            }
        }




        private void doBinaryOperaion()
        {
            resultLabel.Visible = false;
            int op = getBinaryOperation();
            switch (op)
            {
                case -1:
                    {
                        MessageBox.Show("Выбери бинарную операцию");
                        break;
                    }
                case 2:
                    {
                        resultTextBox.Text = (Convert.ToDouble(firstNumberTextBox.Text) +
                            Convert.ToDouble(secondNumberTextBox.Text)).ToString();
                        if (formulaCheckBox.Checked)
                        {
                            resultLabel.Text = firstNumberTextBox.Text + " + " + 
                                secondNumberTextBox.Text + " = " + resultTextBox.Text;
                            resultLabel.Visible = true;
                        }
                        break;
                    }
                case 0:
                    {
                        resultTextBox.Text = (Convert.ToDouble(firstNumberTextBox.Text) - 
                            Convert.ToDouble(secondNumberTextBox.Text)).ToString();
                        if (formulaCheckBox.Checked)
                        {
                            string secondOperand = "";
                            if(Convert.ToDouble(secondNumberTextBox.Text) >= 0)
                            {
                                secondOperand = secondNumberTextBox.Text;
                            }
                            else
                            {
                                secondOperand = "(" + secondNumberTextBox.Text + ")";
                            }
                            resultLabel.Text = firstNumberTextBox.Text + " - " + secondOperand +
                                " = " + resultTextBox.Text;
                            resultLabel.Visible = true;
                        }
                        break;
                    }
                case 1:
                    {
                        resultTextBox.Text = (Convert.ToDouble(firstNumberTextBox.Text) * 
                            Convert.ToDouble(secondNumberTextBox.Text)).ToString();
                        if (formulaCheckBox.Checked)
                        {
                            resultLabel.Text = firstNumberTextBox.Text + " * " +
                                secondNumberTextBox.Text + " = " + resultTextBox.Text;
                            resultLabel.Visible = true;
                        }
                        break;
                    }
                case 3:
                    {
                        {
                            try
                            {
                                resultTextBox.Text = (Convert.ToDouble(firstNumberTextBox.Text) /
                                    Convert.ToDouble(secondNumberTextBox.Text)).ToString();
                                if (formulaCheckBox.Checked)
                                {
                                    resultLabel.Text = firstNumberTextBox.Text + " / " +
                                        secondNumberTextBox.Text + " = " + resultTextBox.Text;
                                    resultLabel.Visible = true;
                                }
                                break;
                            }
                            catch
                            {
                                MessageBox.Show("You cannnot divide by zero in this neighbourhood");
                                break;
                            }
                        }
                    }
            }
        }




        private int getOperandsInput()
        {
            int counter = 2;
            foreach (RadioButton rBtn in this.operandsGroupBox.Controls.OfType<RadioButton>())
            {
                if (rBtn.Checked)
                {
                    counter--;
                    return counter;
                }
                counter--;
            }
            return --counter;
        }

        private int getUnaryOperation()
        {
            int counter = 4;
            foreach (RadioButton rBtn in this.unaryOperationGroupBox.Controls.OfType<RadioButton>())
            {
                if (rBtn.Checked)
                {
                    counter--;
                    return counter;
                }
                counter--;
            }
            return --counter;
        }

        private int getBinaryOperation()
        {
            int counter = 4;
            foreach (RadioButton rBtn in this.binaryOpsGroupBox.Controls.OfType<RadioButton>())
            {
                if (rBtn.Checked)
                {
                    return --counter;
                }
                counter--;
            }
            return -1;
        }

        string lastFirstCorrect = "";
        private void FirstNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            bool correct = double.TryParse(firstNumberTextBox.Text, out double temp) ||
                firstNumberTextBox.Text == "" || firstNumberTextBox.Text == "-";
            if (!correct)
            {
                try
                {
                    int pos = firstNumberTextBox.SelectionStart - 1;
                    firstNumberTextBox.Text = lastFirstCorrect;
                    firstNumberTextBox.Focus();
                    firstNumberTextBox.SelectionStart = pos;
                    firstNumberTextBox.SelectionLength = 0;
                }
                catch
                {
                    firstNumberTextBox.Text = "";
                }
            }
            else
            {
                lastFirstCorrect = temp.ToString();
            }
        }


        string lastSecondCorrect = "";

        private void SecondNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            bool correct = double.TryParse(secondNumberTextBox.Text, out double temp) ||
                secondNumberTextBox.Text == "" || secondNumberTextBox.Text == "-";
            if (!correct)
            {
                try
                {
                    int pos = firstNumberTextBox.SelectionStart - 1;
                    secondNumberTextBox.Text = lastSecondCorrect;
                    secondNumberTextBox.Focus();
                    secondNumberTextBox.SelectionStart = pos;
                    secondNumberTextBox.SelectionLength = 0;
                }
                catch
                {
                    secondNumberTextBox.Text = "";
                }
            }
            else
            {
                lastSecondCorrect = temp.ToString();
            }
        }
    }
}

