using System;
using System.Windows.Forms;

namespace Cinemaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TabControl1_Selected(sender, null);
        }


        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            string tab = tabControl.SelectedTab.Text;
            switch (tab)
            {
                case "Билеты":
                    {
                        ticketsEditCashierCB.Items.Clear();
                        ticketsEditSessionCB.Items.Clear();
                        ticketsAddCashierCB.Items.Clear();
                        ticketsAddSessionCB.Items.Clear();

                        Cashier[] cashiers = (Cashier[])ERM.getAll("cashiers");
                        ticketsAddCashierCB.Items.AddRange(cashiers);
                        ticketsEditCashierCB.Items.AddRange(cashiers);

                        Session[] sessions = (Session[])ERM.getAll("sessions");
                        ticketsAddSessionCB.Items.AddRange(sessions);
                        ticketsEditSessionCB.Items.AddRange(sessions);

                        Ticket[] tickets = (Ticket[])ERM.getAll("tickets");
                        ticketsGrid.RowCount = tickets.Length;
                        for (int i = 0; i < tickets.Length; i++)
                        {
                            ticketsGrid.Rows[i].Cells[0].Value = tickets[i].id;
                            ticketsGrid.Rows[i].Cells[1].Value = tickets[i].sessionID;
                            ticketsGrid.Rows[i].Cells[2].Value = tickets[i].cashier;
                            ticketsGrid.Rows[i].Cells[3].Value = tickets[i].seat;
                            ticketsGrid.Rows[i].Cells[4].Value = tickets[i].row;
                        }

                        try
                        {
                            ticketsAddIDField.Text = (tickets[tickets.Length - 1].id + 1).ToString();
                        }
                        catch
                        {
                            ticketsAddIDField.Text = "1";
                        }

                        break;
                    }

                case "Сеансы":
                    {
                        sessionsAddFilmCB.Items.Clear();
                        sessionsAddRoomCB.Items.Clear();
                        sessionsEditFilmCB.Items.Clear();
                        sessionsEditRoomCB.Items.Clear();

                        Film[] films = (Film[])ERM.getAll("films");
                        sessionsAddFilmCB.Items.AddRange(films);
                        sessionsEditFilmCB.Items.AddRange(films);

                        Room[] rooms = (Room[])ERM.getAll("rooms");
                        sessionsAddRoomCB.Items.AddRange(rooms);
                        sessionsEditRoomCB.Items.AddRange(rooms);


                        Session[] sessions = (Session[])ERM.getAll("sessions");
                        sessionsGrid.RowCount = sessions.Length;
                        for (int i = 0; i < sessions.Length; i++)
                        {
                            sessionsGrid.Rows[i].Cells[0].Value = sessions[i].id;
                            sessionsGrid.Rows[i].Cells[1].Value = sessions[i].date.serialize();
                            sessionsGrid.Rows[i].Cells[2].Value = sessions[i].time.serialze();
                            sessionsGrid.Rows[i].Cells[3].Value = sessions[i].film;
                            sessionsGrid.Rows[i].Cells[4].Value = sessions[i].room;
                            sessionsGrid.Rows[i].Cells[5].Value = sessions[i].type;
                        }

                        try
                        {
                            sessionsAddIDField.Text = (sessions[sessions.Length - 1].id + 1).ToString();
                        }
                        catch
                        {
                            sessionsAddIDField.Text = "1";
                        }

                        break;
                    }

                case "Фильмы":
                    {
                        filmsAddGenreCB.Items.Clear();
                        filmsEditGenreCB.Items.Clear();

                        Genre[] genres = (Genre[])ERM.getAll("genres");

                        filmsAddGenreCB.Items.AddRange(genres);
                        filmsEditGenreCB.Items.AddRange(genres);

                        Film[] films = (Film[])ERM.getAll("films");
                        filmsGrid.RowCount = films.Length;
                        for (int i = 0; i < films.Length; i++)
                        {
                            filmsGrid.Rows[i].Cells[0].Value = films[i].id;
                            filmsGrid.Rows[i].Cells[1].Value = films[i].name;
                            filmsGrid.Rows[i].Cells[2].Value = films[i].genre;
                            filmsGrid.Rows[i].Cells[3].Value = films[i].ageRest;
                        }

                        try
                        {
                            filmsAddIDField.Text = (films[films.Length - 1].id + 1).ToString();
                        }
                        catch
                        {
                            filmsAddIDField.Text = "1";
                        }

                        break;
                    }

                case "Кассиры":
                    {
                        Cashier[] cashiers = (Cashier[])ERM.getAll("cashiers");
                        cashiersGrid.RowCount = cashiers.Length;
                        for (int i = 0; i < cashiers.Length; i++)
                        {
                            filmsGrid.Rows[i].Cells[0].Value = cashiers[i].id;
                            filmsGrid.Rows[i].Cells[0].Value = cashiers[i].name;
                        }

                        try
                        {
                            cashierAddIDField.Text = (cashiers[cashiers.Length - 1].id + 1).ToString();
                        }
                        catch
                        {
                            cashierAddIDField.Text = "1";
                        }

                        break;
                    }
                case "Кинозалы":
                    {
                        Room[] rooms = (Room[])ERM.getAll("rooms");
                        roomsGrid.RowCount = rooms.Length;
                        for (int i = 0; i < rooms.Length; i++)
                        {
                            roomsGrid.Rows[i].Cells[0].Value = rooms[i].id;
                            roomsGrid.Rows[i].Cells[1].Value = rooms[i].name;
                        }

                        try
                        {
                            roomsAddIDField.Text = (rooms[rooms.Length - 1].id + 1).ToString();
                        }
                        catch
                        {
                            roomsAddIDField.Text = "1";
                        }

                        break;
                    }
                case "Жанры":
                    {
                        Genre[] genres = (Genre[])ERM.getAll("genres");
                        genresGrid.RowCount = genres.Length;
                        for (int i = 0; i < genres.Length; i++)
                        {
                            genresGrid.Rows[i].Cells[0].Value = genres[i].id;
                            genresGrid.Rows[i].Cells[1].Value = genres[i].name;
                        }

                        try
                        {
                            genresAddIDField.Text = (genres[genres.Length - 1].id + 1).ToString();
                        }
                        catch
                        {
                            genresAddIDField.Text = "1";
                        }

                        break;
                    }
            }
        }
    }
}
