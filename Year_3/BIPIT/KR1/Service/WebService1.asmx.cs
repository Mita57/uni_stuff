using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace Service
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        static SqlConnection _connection;

        private static void Connect()
        {
            String connectString = @"workstation id=krwarehouses.mssql.somee.com;packet size=4096;user id=fckinslayer_SQLLogin_1;pwd=dtv5jblqyo;data source=krwarehouses.mssql.somee.com;persist security info=False;initial catalog=krwarehouses";
            _connection = new SqlConnection(connectString);
            _connection.Open();
        }

        private static void Disconnect()
        {
            _connection.Close();
        }

        [WebMethod]
        public string[][] GetData(string table)
        {
            Connect();
            String query = String.Format("SELECT * FROM {0}", table);
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            List<string[]> listGlobal = new List<string[]>();
            if (table == "waybills")
            {
                string[] listLocal = new string[4];

                while (dataReader.Read())
                {
                    listLocal[0] = dataReader.GetValue(0).ToString();
                    listLocal[1] = dataReader.GetValue(1).ToString();
                    listLocal[2] = dataReader.GetValue(2).ToString();
                    listLocal[3] = dataReader.GetValue(3).ToString();
                    listGlobal.Add(listLocal);
                    listLocal = new string[4];
                }
            }
            else
            {
                string[] listLocal = new string[2];
                while (dataReader.Read())
                {
                    listLocal[0] = dataReader.GetValue(0).ToString();
                    listLocal[1] = dataReader.GetValue(1).ToString();
                    listGlobal.Add(listLocal);
                    listLocal = new string[2];
                }
            }
            Disconnect();
            return listGlobal.ToArray();
        }

        [WebMethod]
        public void AddData(string table, List<string> cols, List<string> vals)
        {
            Connect();
            String newValues = "";
            foreach (String str in vals)
            {
                newValues += "'" + str + "', ";
            }
            newValues = newValues.Substring(0, newValues.Length - 2);


            string newCols = "";

            foreach (string str in cols)
            {
                newCols += "" + str + ", ";
            }

            newCols = newCols.Substring(0, newCols.Length - 2);


            String query = String.Format("INSERT INTO {0}({1}) VALUES ({2})", table, newCols, newValues);

            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Disconnect();
        }
    }
}

