using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

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
            if (this.Minutes == 0)
            {
                return this.Hours + ":" + this.Minutes + "0";
            }
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
            return (this.Id + "#:" + this.Date + ", " + this.Time + "; " + this.Room) + "; " + this.Film;
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

    public class CoolTicket
    {
        public int ID { get; set; }
        public string sessionID { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string film { get; set; }
        public string type { get; set; }
        public string cashier { get; set; }
        public string genre { get; set; }
        public string room { get; set; }
        public int place { get; set; }
        public int row { get; set; }

        public CoolTicket(int id, string sessionID, string date, string time, string type, string cashier, string genre, string room, int place, int row)
        {
            this.ID = id;
            this.sessionID = sessionID;
            this.date = date;
            this.time = time;
            this.type = type;
            this.cashier = cashier;
            this.genre = genre;
            this.room = room;
            this.place = place;
            this.row = row;
        }

    }

    public class Erm
    {
        static SqlConnection _connection;

        public static void Connect()
        {
            String connectString = @"Data Source = DESKTOP-L0CODJ9\SQLEXPRESS; Initial Catalog = cinema;User ID = sa; password = 1234; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();
        }

        public static void Disconnect()
        {
            _connection.Close();
        }

        public static void Insert(String table, string[] cols, String[] values)
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

        public static void Update(String table, String[] cols, String[] values, string attrCol, string attrVal)
        {
            Connect();

            string qr = "";

            for (int i = 0; i < cols.Length; i++)
            {
                qr += cols[i] + "= '" + values[i] + "'" + ",";
            }
            qr = qr.Substring(0, qr.Length - 1);

            String query = String.Format("UPDATE {0} SET {1} WHERE {2} = {3}", table, qr, attrCol, attrVal);

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
                case ("coolTickets"):
                    {
                        return GetCoolTickets().ToArray();
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
            String query = ("SELECT cashiers.cashier, * FROM tickets INNER JOIN cashiers ON tickets.cashierID = cashiers.cashierID");
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
            String query = ("SELECT genres.genre, * FROM films INNER JOIN genres ON films.genreID = genres.genreID ");
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
                string name = dataReader.GetValue(1).ToString();
                Cashier cashier = new Cashier(id, name);
                list.Add(cashier);
            }
            return list;
        }

        static List<Room> GetRooms(SqlDataReader dataReader)
        {
            List<Room> list = new List<Room>();
            while (dataReader.Read())
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
            while (dataReader.Read())
            {
                int id = (int)dataReader.GetValue(0);
                string name = dataReader.GetValue(1).ToString();
                Genre genre = new Genre(id, name);
                list.Add(genre);
            }
            return list;
        }

        public static List<CoolTicket> GetCoolTickets()
        {
            List<CoolTicket> list = new List<CoolTicket>();
            List<Ticket> ticketList = GetTickets();
            if(ticketList.Count == 0)
            {
                return list;
            }

            foreach (Ticket tick in ticketList)
            {
                int filmID = 0;
                int roomID = 0;
                int genreID = 0;
                int sessionID = 0;

                int ticketID = tick.Id;
                int seat = tick.Seat;
                int row = tick.Row;
                string type = "";
                string session = "";
                string film = "";
                int ageRestr = 0;
                string genre = "";
                string cashier = "";
                string room = "";
                string time = "";
                string date = "";

                string queryCashier = "SELECT cashier FROM cashiers WHERE cashierID = '" + tick.Id + "'";
                SqlCommand command = new SqlCommand(queryCashier, _connection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cashier = dataReader.GetValue(0).ToString();
                }

                string querySession = "SELECT * FROM sessions WHERE sessionID = '" + tick.SessionId + "'";
                command = new SqlCommand(queryCashier, _connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    sessionID = (int)dataReader.GetValue(0);
                    time = dataReader.GetValue(2).ToString();
                    date = dataReader.GetValue(3).ToString();
                    roomID = (int)dataReader.GetValue(1);
                    filmID = (int)dataReader.GetValue(4);
                    type = dataReader.GetValue(5).ToString();
                    session = sessionID + ": " + date + " " + time;
                }

                string queryFilm = "SELECT * FROM films WHERE filmID = '" + filmID + "'";
                command = new SqlCommand(queryFilm, _connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    film = dataReader.GetValue(1).ToString();
                    genreID = (int)dataReader.GetValue(2);
                    ageRestr = (int)dataReader.GetValue(3);
                }

                string queryGenre = "SELECT genre FROM genres WHERE genreID = '" + genreID +  "'";
                command = new SqlCommand(queryGenre, _connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    genre = dataReader.GetValue(1).ToString();
                }

                string queryRoom = "SELECT room FROM rooms WHERE roomID = '" + roomID + "'";
                command = new SqlCommand(queryRoom, _connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    room = dataReader.GetValue(1).ToString();
                }

                CoolTicket dick = new CoolTicket(ticketID, session, date, time, type, cashier, genre, room, seat, row);
                list.Add(dick);
            }
            return list;
        }

        public static void Delete(String table, string col, string val)
        {
            String query = String.Format("DELETE FROM {0} WHERE {1} = {2}", table, col, val);

            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();

        }
    }
}
