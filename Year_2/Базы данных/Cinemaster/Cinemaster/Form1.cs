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
                        break;
                    }

                case "Сеансы":
                    {
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
                        break;
                    }

                case "Фильмы":
                    {
                        Film[] films = (Film[])ERM.getAll("films");
                        filmsGrid.RowCount = films.Length;
                        for (int i = 0; i < films.Length; i++)
                        {
                            filmsGrid.Rows[i].Cells[0].Value = films[i].id;
                            filmsGrid.Rows[i].Cells[1].Value = films[i].name;
                            filmsGrid.Rows[i].Cells[2].Value = films[i].genre;
                            filmsGrid.Rows[i].Cells[3].Value = films[i].ageRest;
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
                        break;
                    }
            }
        }


    }
}
