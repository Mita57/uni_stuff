using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace KR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double func(double arg)
        {
            return (arg * arg);
        }

        private static List<double> vals = new List<double>();
        private static double littlePartition = 0;
        private static int partition = 0;

        private static double sum = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int partsAmount = (int) partsNum.Value;
            int threadsAmount = (int) threadsNum.Value;
            partition = partsAmount / threadsAmount;
            littlePartition = (double) 2 / partsAmount;
            for (double i = 0; i < 2; i += littlePartition)
            {
                vals.Add(func(i));
            }
            
            for (int i = 0; i < partsAmount; i += partition)
            {
                Parallel.Invoke(() =>
                {
                    run(i + 1, i + partition);
                });
            }

            MessageBox.Show(littlePartition.ToString());
        }

        private void run(int left, int right)
        {
            for (int i = left; i < right; i ++)
            {
                double val = ((vals[i - 1] + vals[i]) / (double) 2) * littlePartition;
                sum += val;
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("result.xml");
                XmlElement xRoot = xDoc.DocumentElement;
                XmlElement driverElem = xDoc.CreateElement("driver");
                XmlElement driverCode = xDoc.CreateElement("arg");
                XmlElement driverName = xDoc.CreateElement("val");
                XmlText codeText = xDoc.CreateTextNode(i.ToString());
                XmlText nameText = xDoc.CreateTextNode(val.ToString());
                driverCode.AppendChild(codeText);
                driverName.AppendChild(nameText);
                driverElem.AppendChild(driverCode);
                driverElem.AppendChild(driverName);
                xRoot.AppendChild(driverElem);
                xDoc.Save("result.xml");
            }
        }
        
    }
}