using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;
using System.IO;

namespace BIPIT3
{
    /// <summary>
    /// Summary description for Contoller
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Controller : System.Web.Services.WebService
    {
        static SqlConnection _connection;

        private static void Connect()
        {
            String connectString = @"Data Source = EquipmentFFSVer4.mssql.somee.com ; Initial Catalog = EquipmentFFSVer4;User ID = fckinslayer_SQLLogin_1; password = dtv5jblqyo; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();
        }

        private static void Disconnect()
        {
            _connection.Close();
        }

        [WebMethod]
        public static DataSet GetData(string left, string right, string table)
        {
            DataSet dataSet = new DataSet();
            Connect();
            String query = String.Format("SELECT * FROM {0}", table);
            if (left != "" && right != "")
            {
                query += String.Format("WHERE Added BETWEEN {0} AND {1}", left, right);
            }
            SqlCommand command = new SqlCommand(query, _connection);

            SqlDataAdapter sqa = new SqlDataAdapter(command);
            sqa.Fill(dataSet, table);
            Disconnect();
            return dataSet;
        }

        [WebMethod]
        public static string NewRec(List<string> vals, List<string> cols, string table)
        {
            Connect();
            cols.Add("Added");
            vals.Add(DateTime.Now.ToString());

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
            return query;
        }

        [WebMethod]
        public static string RemoveRec(string val, string col, string table)
        {
            Connect();

            String query = String.Format("DELETE FROM {0} WHERE {1} = '{2}'", table, col, val);
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
            Disconnect();
            return query;
        }
    }
}
