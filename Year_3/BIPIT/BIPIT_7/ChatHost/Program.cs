using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data;
using System.Data.SqlClient;
namespace ChatHost
{
    class Program
    {
        
        static void Main(string[] args)
        {
            using(var host = new ServiceHost(typeof(WCF_CHAT.ServiceChat)))
            {
                host.Open();
                Console.WriteLine("Le host marche");
                Console.ReadLine();
            }
        }
        
    }
}
