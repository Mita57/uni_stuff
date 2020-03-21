using System;
using System.Windows.Forms;
// ReSharper disable LocalVariableHidesMember
// ReSharper disable All

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

                    Cashier[] cashiers = (Cashier[]) Erm.GetAll("cashiers");
                    ticketsAddCashierCB.Items.AddRange(cashiers);
                    ticketsEditCashierCB.Items.AddRange(cashiers);

                    Session[] sessions = (Session[]) Erm.GetAll("sessions");
                    ticketsAddSessionCB.Items.AddRange(sessions);
                    ticketsEditSessionCB.Items.AddRange(sessions);

                    Ticket[] tickets = (Ticket[]) Erm.GetAll("tickets");
                    ticketsNoEntriesLabel.Visible = false;
                    try
                    {
                        ticketsGrid.RowCount = tickets.Length;
                        for (int i = 0; i < tickets.Length; i++)
                        {
                            ticketsGrid.Rows[i].Cells[0].Value = tickets[i].Id;
                            //search for the session to have a proper display
                            for (int j = 0; j < sessions.Length; i++)
                            {
                                if (tickets[i].SessionId == sessions[i].Id)
                                {
                                    ticketsGrid.Rows[i].Cells[1].Value = sessions[i].ToString();
                                    break;
                                }
                            }
                            ticketsGrid.Rows[i].Cells[2].Value = tickets[i].Cashier;
                            ticketsGrid.Rows[i].Cells[3].Value = tickets[i].Seat;
                            ticketsGrid.Rows[i].Cells[4].Value = tickets[i].Row;
                        }
                        ticketsAddIDField.Text = (tickets[tickets.Length - 1].Id + 1).ToString();
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

                    Film[] films = (Film[]) Erm.GetAll("films");
                    sessionsAddFilmCB.Items.AddRange(films);
                    sessionsEditFilmCB.Items.AddRange(films);

                    Room[] rooms = (Room[]) Erm.GetAll("rooms");
                    sessionsAddRoomCB.Items.AddRange(rooms);
                    sessionsEditRoomCB.Items.AddRange(rooms);


                    Session[] sessions = (Session[]) Erm.GetAll("sessions");
                    sessionsNoEntriesLabel.Visible = false;
                    try
                    {
                        sessionsGrid.RowCount = sessions.Length;
                        for (int i = 0; i < sessions.Length; i++)
                        {
                            sessionsGrid.Rows[i].Cells[0].Value = sessions[i].Id;
                            sessionsGrid.Rows[i].Cells[1].Value = sessions[i].Date.ToString();
                            sessionsGrid.Rows[i].Cells[2].Value = sessions[i].Time.ToString();
                            sessionsGrid.Rows[i].Cells[3].Value = sessions[i].Film;
                            sessionsGrid.Rows[i].Cells[4].Value = sessions[i].Room;
                            sessionsGrid.Rows[i].Cells[5].Value = sessions[i].Type;
                        }
                        sessionsAddIDField.Text = (sessions[sessions.Length - 1].Id + 1).ToString();
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

                    Genre[] genres = (Genre[]) Erm.GetAll("genres");

                    filmsAddGenreCB.Items.AddRange(genres);
                    filmsEditGenreCB.Items.AddRange(genres);

                    filmsNoEntriesLabel.Visible = false;
                    Film[] films = (Film[]) Erm.GetAll("films");
                    try
                    {
                        filmsGrid.RowCount = films.Length;
                        for (int i = 0; i < films.Length; i++)
                        {
                            filmsGrid.Rows[i].Cells[0].Value = films[i].Id;
                            filmsGrid.Rows[i].Cells[1].Value = films[i].Name;
                            filmsGrid.Rows[i].Cells[2].Value = films[i].Genre;
                            filmsGrid.Rows[i].Cells[3].Value = films[i].AgeRest;
                        }
                        filmsAddIDField.Text = (films[films.Length - 1].Id + 1).ToString();
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
                    Cashier[] cashiers = (Cashier[]) Erm.GetAll("cashiers");
                    cashiersNoEntriesLabel.Visible = false;
                    try
                    {
                        cashiersGrid.RowCount = cashiers.Length;
                        for (int i = 0; i < cashiers.Length; i++)
                        {
                            cashiersGrid.Rows[i].Cells[0].Value = cashiers[i].Id;
                            cashiersGrid.Rows[i].Cells[1].Value = cashiers[i].Name;
                        }
                        cashierAddIDField.Text = (cashiers[cashiers.Length - 1].Id + 1).ToString();
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
                    Room[] rooms = (Room[]) Erm.GetAll("rooms");
                    try
                    {
                        roomsGrid.RowCount = rooms.Length;
                        for (int i = 0; i < rooms.Length; i++)
                        {
                            roomsGrid.Rows[i].Cells[0].Value = rooms[i].Id;
                            roomsGrid.Rows[i].Cells[1].Value = rooms[i].Name;
                        }
                        roomsAddIDField.Text = (rooms[rooms.Length - 1].Id + 1).ToString();
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
                    Genre[] genres = (Genre[]) Erm.GetAll("genres");
                    try
                    {
                        genresGrid.RowCount = genres.Length;
                        for (int i = 0; i < genres.Length; i++)
                        {
                            genresGrid.Rows[i].Cells[0].Value = genres[i].Id;
                            genresGrid.Rows[i].Cells[1].Value = genres[i].Name;
                        }
                        genresAddIDField.Text = (genres[genres.Length - 1].Id + 1).ToString();
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


        private void TicketsAddValidation(object sender, EventArgs e)
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

        private void SessionsAddValidation(object sender, EventArgs e)
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


        private void ticketsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ticketsEditGroup.Enabled = true;
            ticketsEditField.Text = ticketsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            for (int j = 0; j < ticketsEditCashierCB.Items.Count; j++)
            {
                if (ticketsEditCashierCB.Items[j].ToString().Split(':') == ticketsGrid.Rows[e.RowIndex].Cells[2].Value)
                {
                    ticketsEditCashierCB.SelectedIndex = j;
                }
            }
            ticketsEditSessionCB.SelectedText = ticketsGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            ticketsEditRow.Value = (int) ticketsGrid.Rows[e.RowIndex].Cells[4].Value;
            ticketsEditSeat.Value = (int) ticketsGrid.Rows[e.RowIndex].Cells[3].Value;
        }
    }
}