using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace BIPIT5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {

        static SqlConnection _connection;

        public void NewRec(List<string> vals, List<string> cols,string table)
        {
            String connectString = @"Data Source = EquipmentFFSVer4.mssql.somee.com ; Initial Catalog = EquipmentFFSVer4;User ID = fckinslayer_SQLLogin_1; password = dtv5jblqyo; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();

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
            _connection.Close();
        }

        List<List<string>> IService1.GetData(string table)
        {
            String connectString = @"Data Source = EquipmentFFSVer4.mssql.somee.com ; Initial Catalog = EquipmentFFSVer4;User ID = fckinslayer_SQLLogin_1; password = dtv5jblqyo; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();
            String query = String.Format("SELECT * FROM {0}", table);
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            List<List<string>> listGlobal = new List<List<string>>();
            List<string> listLocal = new List<string>();
            while (dataReader.Read())
            {
                listLocal.Add(dataReader.GetValue(0).ToString());
                listLocal.Add(dataReader.GetValue(1).ToString());
                listLocal.Add(dataReader.GetValue(2).ToString());
                if(table == "Issues")
                {
                    listLocal.Add(dataReader.GetValue(3).ToString());
                    listLocal.Add(dataReader.GetValue(4).ToString());
                }
                listGlobal.Add(listLocal);
            }
            return listGlobal;
        }
    }
}
