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

                    Cashier[] cashiers = (Cashier[]) ERM.getAll("cashiers");
                    ticketsAddCashierCB.Items.AddRange(cashiers);
                    ticketsEditCashierCB.Items.AddRange(cashiers);

                    Session[] sessions = (Session[]) ERM.getAll("sessions");
                    ticketsAddSessionCB.Items.AddRange(sessions);
                    ticketsEditSessionCB.Items.AddRange(sessions);

                    Ticket[] tickets = (Ticket[]) ERM.getAll("tickets");
                    ticketsNoEntriesLabel.Visible = false;
                    try
                    {
                        ticketsGrid.RowCount = tickets.Length;
                        for (int i = 0; i < tickets.Length; i++)
                        {
                            ticketsGrid.Rows[i].Cells[0].Value = tickets[i].id;
                            ticketsGrid.Rows[i].Cells[1].Value = tickets[i].sessionID;
                            ticketsGrid.Rows[i].Cells[2].Value = tickets[i].cashier;
                            ticketsGrid.Rows[i].Cells[3].Value = tickets[i].seat;
                            ticketsGrid.Rows[i].Cells[4].Value = tickets[i].row;
                        }
                        ticketsAddIDField.Text = (tickets[tickets.Length - 1].id + 1).ToString();
                    }
                    catch
                    {
                        ticketsNoEntriesLabel.Visible = true;
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

                    Film[] films = (Film[]) ERM.getAll("films");
                    sessionsAddFilmCB.Items.AddRange(films);
                    sessionsEditFilmCB.Items.AddRange(films);

                    Room[] rooms = (Room[]) ERM.getAll("rooms");
                    sessionsAddRoomCB.Items.AddRange(rooms);
                    sessionsEditRoomCB.Items.AddRange(rooms);


                    Session[] sessions = (Session[]) ERM.getAll("sessions");
                    sessionsNoEntriesLabel.Visible = false;
                    try
                    {
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
                        sessionsAddIDField.Text = (sessions[sessions.Length - 1].id + 1).ToString();
                    }
                    catch
                    {
                        sessionsNoEntriesLabel.Visible = true;
                        sessionsAddIDField.Text = "1";
                    }

                    break;
                }

                case "Фильмы":
                {
                    filmsAddGenreCB.Items.Clear();
                    filmsEditGenreCB.Items.Clear();

                    Genre[] genres = (Genre[]) ERM.getAll("genres");

                    filmsAddGenreCB.Items.AddRange(genres);
                    filmsEditGenreCB.Items.AddRange(genres);

                    filmsNoEntriesLabel.Visible = false;
                    Film[] films = (Film[]) ERM.getAll("films");
                    try
                    {
                        filmsGrid.RowCount = films.Length;
                        for (int i = 0; i < films.Length; i++)
                        {
                            filmsGrid.Rows[i].Cells[0].Value = films[i].id;
                            filmsGrid.Rows[i].Cells[1].Value = films[i].name;
                            filmsGrid.Rows[i].Cells[2].Value = films[i].genre;
                            filmsGrid.Rows[i].Cells[3].Value = films[i].ageRest;
                        }
                        filmsAddIDField.Text = (films[films.Length - 1].id + 1).ToString();
                    }
                    catch
                    {
                        filmsNoEntriesLabel.Visible = true;
                        filmsAddIDField.Text = "1";
                    }

                    break;
                }

                case "Кассиры":
                {
                    Cashier[] cashiers = (Cashier[]) ERM.getAll("cashiers");
                    cashiersNoEntriesLabel.Visible = false;
                    try
                    {
                        cashiersGrid.RowCount = cashiers.Length;
                        for (int i = 0; i < cashiers.Length; i++)
                        {
                            filmsGrid.Rows[i].Cells[0].Value = cashiers[i].id;
                            filmsGrid.Rows[i].Cells[0].Value = cashiers[i].name;
                        }
                        cashierAddIDField.Text = (cashiers[cashiers.Length - 1].id + 1).ToString();
                    }
                    catch
                    {
                        cashiersNoEntriesLabel.Visible = true;
                        cashierAddIDField.Text = "1";
                    }

                    break;
                }
                case "Кинозалы":
                {
                    roomsNoEntriesLabel.Visible = false;
                    Room[] rooms = (Room[]) ERM.getAll("rooms");
                    try
                    {
                        roomsGrid.RowCount = rooms.Length;
                        for (int i = 0; i < rooms.Length; i++)
                        {
                            roomsGrid.Rows[i].Cells[0].Value = rooms[i].id;
                            roomsGrid.Rows[i].Cells[1].Value = rooms[i].name;
                        }
                        roomsAddIDField.Text = (rooms[rooms.Length - 1].id + 1).ToString();
                    }
                    catch
                    {
                        roomsNoEntriesLabel.Visible = true;
                        roomsAddIDField.Text = "1";
                    }

                    break;
                }
                case "Жанры":
                {
                    genresNoEntriesLabel.Visible = false;
                    Genre[] genres = (Genre[]) ERM.getAll("genres");
                    try
                    {
                        genresGrid.RowCount = genres.Length;
                        for (int i = 0; i < genres.Length; i++)
                        {
                            genresGrid.Rows[i].Cells[0].Value = genres[i].id;
                            genresGrid.Rows[i].Cells[1].Value = genres[i].name;
                        }
                        genresAddIDField.Text = (genres[genres.Length - 1].id + 1).ToString();
                    }
                    catch
                    {
                        genresNoEntriesLabel.Visible = true;
                        genresAddIDField.Text = "1";
                    }

                    break;
                }
            }
        }


        private void ticketsAddValidation(object sender, EventArgs e)
        {
            bool cashierFlag = false;
            bool sessionsFlag = false;

            if (ticketsAddCashierCB.SelectedIndex != -1)
            {
                cashierFlag = true;
            }

            if (ticketsAddSessionCB.SelectedIndex != -1)
            {
                sessionsFlag = true;
            }

            if (cashierFlag && sessionsFlag)
            {
                addTicketButton.Enabled = true;
            }
            else
            {
                addTicketButton.Enabled = false;
            }
        }

        private void sessionsAddValidation(object sender, EventArgs e)
        {
            bool filmFlag = false;
            bool roomFlag = false;
            bool typeFlag = false;

            if (sessionsAddFilmCB.SelectedIndex != -1)
            {
                filmFlag = true;
            }

            if (sessionsAddRoomCB.SelectedIndex != -1)
            {
                roomFlag = true;
            }

            if (sessionsAddTypeCB.SelectedIndex != -1)
            {
                typeFlag = true;
            }

            if (filmFlag && roomFlag && typeFlag)
            {
                addSessionButton.Enabled = true;
            }
            else
            {
                addSessionButton.Enabled = false;
            }
        }

        private void filmsAddGenreCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool nameFlag = false;
            bool genreFlag = false;

            if (!String.IsNullOrEmpty(filmsAddNameField.Text))
            {
                nameFlag = true;
            }

            if (filmsAddGenreCB.SelectedIndex != -1)
            {
                genreFlag = true;
            }

            if (nameFlag && genreFlag)
            {
                addFilmButton.Enabled = true;
            }
            else
            {
                addFilmButton.Enabled = false;
            }
        }

        private void cashierAddNameField_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cashierAddNameField.Text))
            {
                addCashierButton.Enabled = false;
            }
            else
            {
                addCashierButton.Enabled = true;
            }
        }

        private void roomsAddNameField_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(roomsAddNameField.Text))
            {
                addRoomButton.Enabled = false;
            }
            else
            {
                addRoomButton.Enabled = true;
            }
        }


        private void genresAddNameField_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(genresAddNameField.Text))
            {
                addFilmButton.Enabled = false;
            }
            else
            {
                addFilmButton.Enabled = true;
            }
        }
    }
}