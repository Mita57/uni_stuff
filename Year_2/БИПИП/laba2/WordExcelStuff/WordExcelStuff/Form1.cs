using System;
using System.Diagnostics;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace WordExcelStuff
{
    public partial class Form1 : Form
    {
        static double segmentation = 0;
        static double trapeezeMethod(double[] vals)
        {
            double value = 0;
            for (int i = 1; i < vals.Length; i++)
            {
                value += ((vals[i - 1] + vals[i]) / 2) * segmentation;
            }
            return value;
        }

        static double rectangleMethod(double[] vals)
        {
            double value = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                value += vals[i] * segmentation;
            }
            return value;
        }

        static double fun(double x)
        {
            return (x * x) / (x + 2);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            int iterations = (int)iterationsAmount.Value + 1;
            double result = 0;
            segmentation = (double)1 / iterations;

            double[] args = new double[iterations];
            double[] vals = new double[iterations];

            args[0] = 1;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 1; i < args.Length; i++)
            {
                args[i] = args[i - 1] + segmentation;
            }
            for(int i = 0; i < vals.Length; i++)
            {
                vals[i] = fun(args[i]);
            }

            if(rectangleRB.Checked)
            {
                result = rectangleMethod(vals);
            }
            else
            {
                result = trapeezeMethod(vals);
            }

            sw.Stop();
            resultField.Text = result.ToString();
            timeEscalatedField.Text = sw.ElapsedMilliseconds.ToString();

            if (outputExcel.Checked)
            {
                Excel.Application excel = new Excel.Application();
                object misValue = System.Reflection.Missing.Value;
                Excel.Workbook xlWorkBook = excel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                excel.Workbooks.Add();
                excel.Visible = true;
                excel.Columns[1].AutoFit();
                excel.Range["A1"].Interior.Color =255;
                for(int i = 0; i < iterations; i++)
                {
                    excel.Range["A" + (i + 2)].Value = i;
                    excel.Range["B" + (i + 2)].Value = args[i];
                    excel.Range["C" + (i + 2)].Value = vals[i];
                }
                excel.Range["D2"].Value = result;
                Excel.ChartObjects xlCharts = (Excel.ChartObjects)xlWorkSheet.ChartObjects(Type.Missing);
                Excel.ChartObject myChart = (Excel.ChartObject)xlCharts.Add(10, 80, 300, 250);
                Excel.Chart chartPage = myChart.Chart;
                Excel.Range chartRange = xlWorkSheet.get_Range("C2", "C" + iterations);
                chartPage.SetSourceData(chartRange, misValue);
                chartPage.ChartType = Excel.XlChartType.xlColumnClustered;
            }

            if (outputWord.Checked)
            {
                Word.Application word = new Word.Application();
                word.Visible = true;
                word.Documents.Add();
                word.ActiveDocument.Tables.Add(word.Selection.Range, iterations, 3, 1, 0);
                for(int i = 0; i < iterations; i++)
                {
                    word.ActiveDocument.Tables[1].Cell(i + 1, 1).Range.Text = Convert.ToString(i);
                    word.ActiveDocument.Tables[1].Cell(i + 1, 2).Range.Text = Convert.ToString(args[i]);
                    word.ActiveDocument.Tables[1].Cell(i + 1, 3).Range.Text = Convert.ToString(vals[i]);
                }
                word.ActiveDocument.Content.InsertAfter("Ответ: " + result);
            }
        }
    }
}
