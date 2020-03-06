using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Cinemaster
{
    public class Date
    {
        public int day { get; set; }

        public int month { get; set; }

        public int year { get; set; }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public string serialize()
        {
            return this.day + "." + this.month + "." + this.year;
        }
    }

    public class Time
    {
        public int hours { get; set; }

        public int minutes { get; set; }

        public Time(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public string serialze()
        {
            return this.hours + ":" + this.minutes;
        }
    }



    public class Ticket
    {

        public int id { get; set; }

        public int sessionID { get; set; }

        public int cashierID { get; set; }

        public string cashier { get; set; }

        public int row { get; set; }

        public int seat { get; set; }

        public Ticket(int id, int sessionID, int cashierID, string cashier, int row, int seat)
        {
            this.id = id;
            this.sessionID = sessionID;
            this.cashierID = cashierID;
            this.cashier = cashier;
            this.row = row;
            this.seat = seat;
        }
    }

    public class Session
    {
        public int id { get; set; }

        public Date date { get; set; }

        public Time time { get; set; }

        public int filmID { get; set; }

        public string film { get; set; }

        public int roomID { get; set; }

        public string room { get; set; }

        public string type { get; set; }

        public Session(int id, Date date, Time time, int filmID, string film, int roomId, string room, string type)
        {
            this.id = id;
            this.date = date;
            this.time = time;
            this.filmID = filmID;
            this.film = film;
            this.roomID = roomID;
            this.room = room;
            this.type = type;
        }

        public string serialize()
        {
            return (this.id + "#:" + this.date.serialize() + ", " + this.time.serialze() + "; " + this.room);
        }
      
    }


    public class Film
    {
        public int id { get; set; }

        public string name { get; set; }

        public int genreID { get; set; }

        public string genre { get; set; }

        public int ageRest { get; set; }

        public Film(int id, string name, int genreID, string genre, int ageRest)
        {
            this.id = id;
            this.name = name;
            this.genreID = genreID;
            this.genre = genre;
            this.ageRest = ageRest;
        }

        public string serialize()
        {
            return (this.id + "#: " + this.name);
        }

    }

    public class Cashier
    {
        public int id { get; set; }

        public string name { get; set; }

        public Cashier(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string serialize()
        {
            return (this.id + "#: " + this.name);
        }
    }

    public class Room
    {
        public int id { get; set; }

        public string name { get; set; }

        public Room(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string serialize()
        {
            return (this.id + "#: " + this.name);
        }
    }

    public class Genre
    {
        public int id { get; set; }

        public string name { get; set; }

        public Genre(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string serialize()
        {
            return (this.id + "#: " + this.name);
        }
    }

    public class ERM
    {
        static SqlConnection connection;

        public static void connect()
        {
            String connectString = @"Data Source = DESKTOP-AEKQ1GD\SQLEXPRESS; Initial Catalog = cinema;User ID = sa; password = 1234; MultipleActiveResultSets=true";
            connection = new SqlConnection(connectString);
            connection.Open();
        }

        public static void disconnect()
        {
            connection.Close();
        }

        public static void insert(String table, String[] values)
        {
            connect();
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
            disconnect();
        }

        public static void update(String table, String[] cols, String[] values, String[] attrCols, String[] attrVals)
        {
            connect();
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
            disconnect();
        }

        


        public static object[] getAll(String table)
        {
            connect();
            String query = String.Format("SELECT * FROM {0}", table);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            switch (table)
            {
                case ("tickets"):
                    {
                        return getTickets().ToArray();
                    }
                case ("sessions"):
                    {
                        return getSessions().ToArray();
                    }
                case ("films"):
                    {
                        return getFilms().ToArray();
                    }
                case ("cashiers"):
                    {
                        return getCashiers(dataReader).ToArray();
                    }
                case ("rooms"):
                    {
                        return getRooms(dataReader).ToArray();
                    }
                case ("genres"):
                    {
                        return getGenres(dataReader).ToArray();
                    }
            }
            disconnect();
            return null;
        }

        static List<Ticket> getTickets()
        {
            List<Ticket> list = new List<Ticket>();
            String query = String.Format("SELECT cashier.name, * FROM tickets INNER JOIN cashiers ON ticket.cashierID = cashier.ID GROUP BY tickets.ID");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string cashierName = (string)dataReader.GetValue(0);
                int id = (int)dataReader.GetValue(1);
                int sessionID = (int)dataReader.GetValue(2);
                int cashierID = (int)dataReader.GetValue(3);
                int row = (int)dataReader.GetValue(4);
                int seat = (int)dataReader.GetValue(5);
                Ticket ticket = new Ticket(id, sessionID, cashierID, cashierName, row, seat);
                list.Add(ticket);
            }
            return list;
        }

        static List<Session> getSessions()
        {
            List<Session> list = new List<Session>();
            String query = String.Format("SELECT films.name, rooms.name, * FROM sessions INNER JOIN films ON sessions.filmID = films.ID INNER JOIN rooms ON sessions.roomID = room.ID GROUP BY sessions.id");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string filmName = (string)dataReader.GetValue(0);
                string roomName = (string)dataReader.GetValue(1);
                int id = (int)dataReader.GetValue(2);
                string dateStr = (string)dataReader.GetValue(3);
                string timeStr = (string)dataReader.GetValue(4);
                int filmID = (int)dataReader.GetValue(5);
                int roomID = (int)dataReader.GetValue(6);
                string type = (string)dataReader.GetValue(7);

                //creating Date instance
                string[] dateParts = dateStr.Split('.');
                string[] timeParts = dateStr.Split(':');
                Date date = new Date(Convert.ToInt32(dateParts[0]), Convert.ToInt32(dateParts[1]), Convert.ToInt32(dateParts[2]));
                Time time = new Time(Convert.ToInt32(timeParts[0]), Convert.ToInt32(timeParts[1]));
                Session session = new Session(id, date, time, filmID, filmName, roomID, roomName, type);
                list.Add(session);
            }
            return list;
        }

        static List<Film> getFilms()
        {
            List<Film> list = new List<Film>();
            String query = String.Format("SELECT genres.name, * FROM films INNER JOIN genres ON films.genreID = genres.ID GROUP BY films.ID");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string genreName = (string)dataReader.GetValue(0);
                int id = (int)dataReader.GetValue(1);
                string name = (string)dataReader.GetValue(2);
                int genreID = (int)dataReader.GetValue(3);
                int ageRest = (int)dataReader.GetValue(4);
                Film film = new Film(id, name, genreID, genreName, ageRest);
                list.Add(film);
            }
            return list;
        }

        static List<Cashier> getCashiers(SqlDataReader dataReader)
        {
            List<Cashier> list = new List<Cashier>();
            while (dataReader.Read())
            {
                int id = (int)dataReader.GetValue(0);
                string name = (string)dataReader.GetValue(1);
                Cashier cashier = new Cashier(id, name);
                list.Add(cashier);
            }
            return list;
        }

        static List<Room> getRooms(SqlDataReader dataReader)
        {
            List<Room> list = new List<Room>();
            while(dataReader.Read())
            {
                int id = (int)dataReader.GetValue(0);
                string name = (string)dataReader.GetValue(1);
                Room room = new Room(id, name);
                list.Add(room);
            }
            return list;
        }

        static List<Genre> getGenres(SqlDataReader dataReader)
        {
            List<Genre> list = new List<Genre>();
            while(dataReader.Read())
            {
                int id = (int)dataReader.GetValue(0);
                string name = (string)dataReader.GetValue(1);
                Genre genre = new Genre(id, name);
                list.Add(genre);
            }
            return list;
        }




        public static void delete(String table, String[] cols, String[] vals)
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
