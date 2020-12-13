using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace KR1
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {
        static SqlConnection _connection;

        private static void Connect()
        {
            String connectString = @"workstation id=warehousebipit.mssql.somee.com;packet size=4096;user id=dungeonMaster_SQLLogin_1;pwd=rcct57h98i;data source=warehousebipit.mssql.somee.com;persist security info=False;initial catalog=warehousebipit7";
            _connection = new SqlConnection(connectString);
            _connection.Open();
        }

        private static void Disconnect()
        {
            _connection.Close();
        }

        [WebMethod]
        public List<List<string>> GetData(string table)
        {
            Connect();
            String query = String.Format("SELECT * FROM {0}", table);
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            List<List<string>> listGlobal = new List<List<string>>();
            List<string> listLocal = new List<string>();
            while (dataReader.Read())
            {
                listLocal.Add(dataReader.GetValue(0).ToString());
                listLocal.Add(dataReader.GetValue(1).ToString());
                if (table == "waybills")
                {
                    listLocal.Add(dataReader.GetValue(2).ToString());
                    listLocal.Add(dataReader.GetValue(3).ToString());
                }
                listGlobal.Add(listLocal);
                listLocal = new List<string>();
            }
            Disconnect();
            return listGlobal;
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
