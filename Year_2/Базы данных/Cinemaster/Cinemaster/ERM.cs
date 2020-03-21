using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Cinemaster
{
    public class Date
    {
        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public override string ToString()
        {
            return this.Day + "." + this.Month + "." + this.Year;
        }
    }

    public class Time
    {
        public int Hours { get; set; }

        public int Minutes { get; set; }

        public Time(int hours, int minutes)
        {
            this.Hours = hours;
            this.Minutes = minutes;
        }

        public override string ToString()
        {
            return this.Hours + ":" + this.Minutes;
        }
    }



    public class Ticket
    {

        public int Id { get; set; }

        public int SessionId { get; set; }

        public int CashierId { get; set; }

        public string Cashier { get; set; }

        public int Row { get; set; }

        public int Seat { get; set; }

        public Ticket(int id, int sessionId, int cashierId, string cashier, int row, int seat)
        {
            this.Id = id;
            this.SessionId = sessionId;
            this.CashierId = cashierId;
            this.Cashier = cashier;
            this.Row = row;
            this.Seat = seat;
        }
    }

    public class Session
    {
        public int Id { get; set; }

        public Date Date { get; set; }

        public Time Time { get; set; }

        public int FilmId { get; set; }

        public string Film { get; set; }

        public int RoomId { get; set; }

        public string Room { get; set; }

        public string Type { get; set; }

        public Session(int id, Date date, Time time, int filmId, string film, int roomId, string room, string type)
        {
            this.Id = id;
            this.Date = date;
            this.Time = time;
            this.FilmId = filmId;
            this.Film = film;
            this.RoomId = roomId;
            this.Room = room;
            this.Type = type;
        }

        public override string ToString()
        {
            return (this.Id + "#:" + this.Date.ToString() + ", " + this.Time.ToString() + "; " + this.Room);
        }
      
    }


    public class Film
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int GenreId { get; set; }

        public string Genre { get; set; }

        public int AgeRest { get; set; }

        public Film(int id, string name, int genreId, string genre, int ageRest)
        {
            this.Id = id;
            this.Name = name;
            this.GenreId = genreId;
            this.Genre = genre;
            this.AgeRest = ageRest;
        }

        public override string ToString()
        {
            return (this.Id + "#: " + this.Name);
        }

    }

    public class Cashier
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Cashier(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return (this.Id + "#: " + this.Name);
        }
    }

    public class Room
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Room(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return (this.Id + "#: " + this.Name);
        }
    }

    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Genre(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return (this.Id + "#: " + this.Name);
        }
    }

    public class Erm
    {
        static SqlConnection _connection;

        public static void Connect()
        {
            String connectString = @"Data Source = DESKTOP-AEKQ1GD\SQLEXPRESS; Initial Catalog = cinema;User ID = sa; password = 1234; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();
        }

        public static void Disconnect()
        {
            _connection.Close();
        }

        public static void Insert(String table, String[] values)
        {
            Connect();
            String newValues = "(";
            foreach (String str in values)
            {
                newValues += "'" + str + "', ";
            }
            newValues += ")";
            String query = String.Format("INSERT INTO {0} VALUES {1}", table, newValues);

            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            Disconnect();
        }

        public static void Update(String table, String[] cols, String[] values, String[] attrCols, String[] attrVals)
        {
            Connect();
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

            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
            Disconnect();
        }

        


        public static object[] GetAll(String table)
        {
            Connect();
            String query = String.Format("SELECT * FROM {0}", table);
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            switch (table)
            {
                case ("tickets"):
                    {
                        return GetTickets().ToArray();
                    }
                case ("sessions"):
                    {
                        return GetSessions().ToArray();
                    }
                case ("films"):
                    {
                        return GetFilms().ToArray();
                    }
                case ("cashiers"):
                    {
                        return GetCashiers(dataReader).ToArray();
                    }
                case ("rooms"):
                    {
                        return GetRooms(dataReader).ToArray();
                    }
                case ("genres"):
                    {
                        return GetGenres(dataReader).ToArray();
                    }
            }
            Disconnect();
            return null;
        }

        static List<Ticket> GetTickets()
        {
            List<Ticket> list = new List<Ticket>();
            String query = String.Format("SELECT cashiers.cashier, * FROM tickets INNER JOIN cashiers ON tickets.cashierID = cashiers.cashierID");
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string cashierName = dataReader.GetValue(0).ToString();
                int id = (int)dataReader.GetValue(1);
                int sessionId = (int)dataReader.GetValue(2);
                int cashierId = (int)dataReader.GetValue(3);
                int row = (int)dataReader.GetValue(4);
                int seat = (int)dataReader.GetValue(5);
                Ticket ticket = new Ticket(id, sessionId, cashierId, cashierName, row, seat);
                list.Add(ticket);
            }
            return list;
        }

        static List<Session> GetSessions()
        {
            List<Session> list = new List<Session>();
            String query = ("SELECT films.name, rooms.room, * FROM sessions INNER JOIN films ON sessions.filmID = films.filmID INNER JOIN rooms ON sessions.roomID = rooms.roomID");
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string filmName = dataReader.GetValue(0).ToString();
                string roomName = dataReader.GetValue(1).ToString();
                int id = (int)dataReader.GetValue(2);
                int roomId = (int)dataReader.GetValue(3);
                string timeStr = dataReader.GetValue(4).ToString();
                string dateStr = dataReader.GetValue(5).ToString();
                int filmId = (int)dataReader.GetValue(6);
                string type = dataReader.GetValue(7).ToString();

                //creating Date instance
                string[] dateParts = dateStr.Split('.');
                string[] timeParts = timeStr.Split(':');
                Date date = new Date(Convert.ToInt32(dateParts[0]), Convert.ToInt32(dateParts[1]), Convert.ToInt32(dateParts[2]));
                Time time = new Time(Convert.ToInt32(timeParts[0]), Convert.ToInt32(timeParts[1]));
                Session session = new Session(id, date, time, filmId, filmName, roomId, roomName, type);
                list.Add(session);
            }
            return list;
        }

        static List<Film> GetFilms()
        {
            List<Film> list = new List<Film>();
            String query = String.Format("SELECT genres.name, * FROM films INNER JOIN genres ON films.genreID = genres.genreID ");
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string genreName = dataReader.GetValue(0).ToString();
                int id = (int)dataReader.GetValue(1);
                string name = dataReader.GetValue(2).ToString();
                int genreId = (int)dataReader.GetValue(3);
                int ageRest = (int)dataReader.GetValue(4);
                Film film = new Film(id, name, genreId, genreName, ageRest);
                list.Add(film);
            }
            return list;
        }

        static List<Cashier> GetCashiers(SqlDataReader dataReader)
        {
            List<Cashier> list = new List<Cashier>();
            while (dataReader.Read())
            {
                int id = (int)dataReader.GetValue(0);
                string name = (string)dataReader.GetValue(1).ToString();
                Cashier cashier = new Cashier(id, name);
                list.Add(cashier);
            }
            return list;
        }

        static List<Room> GetRooms(SqlDataReader dataReader)
        {
            List<Room> list = new List<Room>();
            while(dataReader.Read())
            {
                int id = (int)dataReader.GetValue(0);
                string name = dataReader.GetValue(1).ToString();
                Room room = new Room(id, name);
                list.Add(room);
            }
            return list;
        }

        static List<Genre> GetGenres(SqlDataReader dataReader)
        {
            List<Genre> list = new List<Genre>();
            while(dataReader.Read())
            {
                int id = (int)dataReader.GetValue(0);
                string name = dataReader.GetValue(1).ToString();
                Genre genre = new Genre(id, name);
                list.Add(genre);
            }
            return list;
        }




        public static void Delete(String table, String[] cols, String[] vals)
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

            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();

        }
    }
}
