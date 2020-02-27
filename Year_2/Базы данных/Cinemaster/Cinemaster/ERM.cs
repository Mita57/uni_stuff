using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cinemaster
{
    class ERM
    {
        static SqlConnection connection;

        static void connect()
        {
            String connectString = @"Data Source = LALTOP Initial Catalog = cinema";
            connection = new SqlConnection(connectString);
        }

        static void disconnect()
        {
            connection.Close();
        }

        static void insert(String table, String[] values)
        {
            String newValues = "(";
            foreach(String str in values)
            {
                newValues += "'" + str + "', ";
            }
            newValues += ")";
            String query = String.Format("INSERT INTO {0} VALUES {1}", table, newValues);
        }

        static void update(String table, String[] cols, String[] values, String[] attrCols, String[] attrVals)
        {
            String newCols = "(";
            foreach(String col in cols)
            {
                newCols += col + ", ";
            }
            newCols += ")";

            String newValues = "(";
            foreach(String str in values)
            {
                newValues += "'" + str + "', ";
            }
            newValues += ")";

            String newAttrCols = "(";
            foreach(String col in attrCols)
            {
                newValues += col + ",";
            }
            newAttrCols += ")";

            String newAttrVals = "(";
            foreach(String val in attrVals)
            {
                newAttrVals += "'" + val + "', ";
            }
            newAttrCols += ")";

            String query = String.Format("UPDATE {0} SET {1} = {2} WHERE {3} = {4}", table, newCols, newValues, newAttrVals, newAttrCols);
        }

        static void getByAttrs(String table, String[] cols, String[] colsArgs, String[] vals)
        {
            String newValues = "(";
            foreach(String val in vals)
            {
                newValues += "'" + val + "', ";
            }
            newValues += ")";

            String newCols = "(";
            foreach(String col in cols)
            {
                newCols += col + ", ";
            }
            newCols += ")";

            String newColsArgs = "(";
            foreach(String col in colsArgs)
            {
                newColsArgs += col + ", ";
            }
            newColsArgs += ")";
            String query = String.Format("SELECT {0} FROM {1} WHERE {2} = {3}", newCols, table, newColsArgs, newValues);
        }

        static void getAll(String table)
        {
            String query = String.Format("SELECT * FROM {0}", table);
        }
        
        static void delete(String table, String[] cols, String[] vals)
        {
            String newCols = "(";
            foreach(String col in cols)
            {
                newCols += col + ", ";
            }
            newCols += ")";

            String newVals = "(";
            foreach(String val in vals)
            {
                newVals += "'" + val + "',"; 
            }
            newVals += ")";
            String query = String.Format("DELETE FROM {0} WHERE {1} = {2}", table, newCols, newVals);
        }
    }
}
