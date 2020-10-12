using System;
using System.Threading.Tasks;
using System.Web.Services;
using System.IO;

namespace BIPIT_1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {


        public double a = 1;
        public double b = 2;
        public double h = 0;
        public double summary = 0;
        public int globalN = 0;
        public int globalM = 0;
        Task[] tasks = new Task[0];

        [WebMethod]
        public string Calculate(int n, int m)
        {
            try
            {
                using (StreamWriter w = File.AppendText("C:/Users/57thr/Downloads/BIPIT_1/log.txt"))
                {
                    w.WriteLine(DateTime.Now + " :Info: new connection, n = " + n.ToString() + ", m = " + m.ToString());
                }

                if (n <= 0 || m <= 0)
                {
                    using (StreamWriter w = File.AppendText("C:/Users/57thr/Downloads/BIPIT_1/log.txt"))
                    {
                        w.WriteLine(DateTime.Now + " :Warn: n or m are unvalid");
                    }
                }

                h = (b - a) / (double)n;
                globalN = n;
                globalM = m;

                tasks = new Task[m];

                for (int i = 0; i < m; i++)
                {
                    int localI = i;
                    tasks[i] = Task.Run(() => CalculateStep(localI));
                }
                Task.WaitAll(tasks);
                double result = summary;
                summary = 0;
                using (StreamWriter w = File.AppendText("C:/Users/57thr/Downloads/BIPIT_1/log.txt"))
                {
                    w.WriteLine(DateTime.Now + " :Info: The calculation is finished, result is " + result.ToString());
                }
                return $"{result}";
            }
            catch(Exception ex)
            {
                using (StreamWriter w = File.AppendText("C:/Users/57thr/Downloads/BIPIT_1/log.txt"))
                {
                    w.WriteLine(DateTime.Now + " :Err: " + ex.ToString());
                }
                return "An error occured, F ";
            }
        }

        public void CalculateStep(int num)
        {
            for (int i = num; i < globalN; i += globalM)
            {
                double x = a + (i * h);
                summary += h * ((Math.Pow(x, 2) + Math.Pow(x+h, 2)) / (double)2);
            }

        }
    }
}
