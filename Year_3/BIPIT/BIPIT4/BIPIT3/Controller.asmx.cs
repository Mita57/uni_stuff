using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Services;

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
            String connectString = @"Data Source = EquipmentFFS.mssql.somee.com ; Initial Catalog = EquipmentFFS;User ID = dungeonMaster_SQLLogin_1; password = rcct57h98i; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();
        }

        private static void Disconnect()
        {
            _connection.Close();
        }

        [WebMethod]
        public static List<string> GetData(string left, string right, string table)
        {
            Connect();
            String query = String.Format("SELECT * FROM {0}", table);
            if(left != "" && right !="")
            {
                query += String.Format("WHERE Added BETWEEN {0} AND {1}", left, right);
            }
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            List<string> list = new List<string>();
            while (dataReader.Read())
            {
                string res = dataReader.GetValue(0).ToString() + dataReader.GetValue(1).ToString();
                if(table == "Issues")
                {
                    res += dataReader.GetValue(2).ToString();
                }
                list.Add(res);
            }
            Disconnect();
            return list;
        }

        public static void NewRec(List<string> values, List<string> cols, string table)
        {
            Connect();

            String newValues = "";
            foreach (String str in values)
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

        public static void RemoveRec(List<string>vals, string col, string table)
        {
            Connect();
            foreach (string val in vals)
            {
                String query = String.Format("DELETE FROM {0} WHERE {1} = {2}", table, col, val);
                SqlCommand command = new SqlCommand(query, _connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();
                command.Dispose();
            }
            Disconnect();
        }
    }
}
