using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cinemaster
{

    public class Ticket
    {

        public int id { get; set; }

        public int sessionID { get; set; }

        public int cashierID { get; set; }

        public int row { get; set; }

        public int seat { get; set; }

        public Ticket(int id, int sessionID, int cashierID, int row, int seat)
        {
            this.id = id;
            this.sessionID = sessionID;
            this.cashierID = cashierID;
            this.row = row;
            this.seat = seat;
        }

    }

    public class Session
    {
        public int id { get; set; }

        public Date date { get; set; }

        public Time time { get; set; }

        public int film { get; set; }

        public int roomId { get; set; }

        public string type { get; set; }


        public class Time
        {
            public int hours { get; set; }

            public int minutes { get; set; }
        }

        public class Date
        {
            public int day { get; set; }

            public int month { get; set; }

            public int year { get; set; }
        }
    }


    public class Film
    {
        public int id { get; set; }

        public string name { get; set; }

        public int genreID { get; set; }

        public int ageRest { get; set; }

    }

    public class Cashier
    {
        public int id { get; set; }

        public string name { get; set; }
    }

    public class Room
    {
        public int id { get; set; }

        public string name { get; set; }
    }

    public class Genre
    {
        public int id { get; set; }

        public string name { get; set; }
    }

    public class ERM
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
            foreach (String str in values)
            {
                newValues += "'" + str + "', ";
            }
            newValues += ")";
            String query = String.Format("INSERT INTO {0} VALUES {1}", table, newValues);

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
        }

        static void update(String table, String[] cols, String[] values, String[] attrCols, String[] attrVals)
        {
            String newCols = "(";
            foreach (String col in cols)
            {
                newCols += col + ", ";
            }
            newCols += ")";

            String newValues = "(";
            foreach (String str in values)
            {
                newValues += "'" + str + "', ";
            }
            newValues += ")";

            String newAttrCols = "(";
            foreach (String col in attrCols)
            {
                newValues += col + ",";
            }
            newAttrCols += ")";

            String newAttrVals = "(";
            foreach (String val in attrVals)
            {
                newAttrVals += "'" + val + "', ";
            }
            newAttrCols += ")";

            String query = String.Format("UPDATE {0} SET {1} = {2} WHERE {3} = {4}", table, newCols, newValues, newAttrVals, newAttrCols);

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
        }

        //static object[] getByAttrs(String table, String[] cols, String[] colsArgs, String[] vals)
        //{
        //    String newValues = "(";
        //    foreach (String val in vals)
        //    {
        //        newValues += "'" + val + "', ";
        //    }
        //    newValues += ")";

        //    String newCols = "(";
        //    foreach (String col in cols)
        //    {
        //        newCols += col + ", ";
        //    }
        //    newCols += ")";

        //    String newColsArgs = "(";
        //    foreach (String col in colsArgs)
        //    {
        //        newColsArgs += col + ", ";
        //    }
        //    newColsArgs += ")";
        //    String query = String.Format("SELECT {0} FROM {1} WHERE {2} = {3}", newCols, table, newColsArgs, newValues);
        //}


        static List<object> getAll(String table)
        {
            String query = String.Format("SELECT * FROM {0}", table);
            String output = "";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            switch (table)
            {
                case ("tickets"):
                    {
                        return getTickets(dataReader);
                    }
                case ("sessions"):
                    {
                        return getSessions(dataReader);
                    }
                case ("films"):
                    {
                        return getFilms(dataReader);
                    }
                case ("cashiers"):
                    {
                        return getCashiers(dataReader);
                    }
                case ("rooms"):
                    {
                        return getRooms(dataReader);
                    }
                case ("genres"):
                    {
                        return getGenres(dataReader);
                    }
            }
        }

        //methods to get data from the database and convert them to Class ojbects

        static List<Ticket> getTickets(SqlDataReader dataReader)
        {
            List<Ticket> list = new List<Ticket>();
            while(dataReader.Read())
            {
                int id = 0;
                int sessionID = 0;
                int cashierID = 0;
                int row = 0;
                int seat = 0;
                Ticket ticket = new Ticket(id, sessionID, cashierID, row, seat);
                list.Add(ticket);
            }

        }

        static List<Session> getSessions(SqlDataReader dataReader)
        {

        }

        static List<Film> getFilms(SqlDataReader dataReader)
        {

        }

        static List<Cashier> getCashiers(SqlDataReader dataReader)
        {

        }

        static List<Room> getRooms(SqlDataReader dataReader)
        {

        }

        static List<Genre> getGenres(SqlDataReader dataReader)
        {

        }




        static void delete(String table, String[] cols, String[] vals)
        {
            String newCols = "(";
            foreach (String col in cols)
            {
                newCols += col + ", ";
            }
            newCols += ")";

            String newVals = "(";
            foreach (String val in vals)
            {
                newVals += "'" + val + "',";
            }
            newVals += ")";
            String query = String.Format("DELETE FROM {0} WHERE {1} = {2}", table, newCols, newVals);

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();

        }
    }
}
