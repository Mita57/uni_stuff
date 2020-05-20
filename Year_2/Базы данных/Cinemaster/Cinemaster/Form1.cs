using System;
using System.Collections.Generic;
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

        //selected tab processing

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
                    ticketsAmount.Text = tickets.Length.ToString();
                    try
                    {
                        ticketsGrid.RowCount = tickets.Length;
                        for (int i = 0; i < tickets.Length; i++)
                        {
                            ticketsGrid.Rows[i].Cells[0].Value = tickets[i].Id;
                            //search for the session to have a proper display
                            for (int j = 0; j < sessions.Length; j++)
                            {
                                if (tickets[i].SessionId == sessions[j].Id)
                                {
                                    ticketsGrid.Rows[i].Cells[1].Value = sessions[j].ToString();
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
                    sessionsAmount.Text = sessions.Length.ToString();
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
                    filmsAmount.Text = films.Length.ToString();
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
                    cashiersAmount.Text = cashiers.Length.ToString();
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
                    roomsAmount.Text = rooms.Length.ToString();
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
                    genreAmount.Text = genres.Length.ToString();
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

                case "Билеты Общ":
                {
                    genresNoEntriesLabel.Visible = false;
                    CoolTicket[] tickets = (CoolTicket[]) Erm.GetCoolTickets().ToArray();
                    totalAmount.Text = tickets.Length.ToString();
                    try
                    {
                        coolGrid.RowCount = tickets.Length;
                        for (int i = 0; i < tickets.Length; i++)
                        {
                            coolGrid.Rows[i].Cells[0].Value = tickets[i].ID;
                            coolGrid.Rows[i].Cells[1].Value = tickets[i].film;
                            coolGrid.Rows[i].Cells[2].Value = tickets[i].sessionID;
                            coolGrid.Rows[i].Cells[3].Value = tickets[i].date;
                            coolGrid.Rows[i].Cells[4].Value = tickets[i].time;
                            coolGrid.Rows[i].Cells[5].Value = tickets[i].type;
                            coolGrid.Rows[i].Cells[6].Value = tickets[i].cashier;
                            coolGrid.Rows[i].Cells[7].Value = tickets[i].ageRest;
                            coolGrid.Rows[i].Cells[8].Value = tickets[i].genre;
                            coolGrid.Rows[i].Cells[9].Value = tickets[i].room;
                            coolGrid.Rows[i].Cells[10].Value = tickets[i].seat;
                            coolGrid.Rows[i].Cells[11].Value = tickets[i].row;
                        }
                    }
                    catch
                    {
                        coolTicketsNoEntriesLabel.Visible = true;
                    }

                    break;
                }

                case "Подчиненные":
                {
                    // left
                    Film[] films = (Film[]) Erm.GetAll("films");
                    filmsTicksCB.Items.Clear();
                    for (int i = 0; i < films.Length; i++)
                    {
                        filmsTicksCB.Items.Add(films[i]);
                    }

                    // genres
                    Genre[] genres = (Genre[]) Erm.GetAll("genres");
                    filmsGenresCB.Items.Clear();
                    for (int i = 0; i < genres.Length; i++)
                    {
                        filmsGenresCB.Items.Add(genres[i]);
                    }

                    // sessions

                    Session[] sessions = (Session[]) Erm.GetAll("sessions");
                    ticketsSessionsCB.Items.Clear();
                    for (int i = 0; i < sessions.Length; i++)
                    {
                        ticketsSessionsCB.Items.Add(sessions[i]);
                    }
                    break;
                }
            }
        }

        //adding input validators

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
                addGenreButton.Enabled = false;
            }
            else
            {
                addGenreButton.Enabled = true;
            }
        }

        //enable editing

        private void enableEditAndRemove(object sender, DataGridViewCellEventArgs e)
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

        //adding stuff

        private void addTicketButton_Click(object sender, EventArgs e)
        {
            string cashierId = ticketsAddCashierCB.Text.Split('#')[0];
            string sessionId = ticketsAddSessionCB.Text.Split('#')[0];
            string row = ticketsAddRow.Value.ToString();
            string seat = ticketsAddSeat.Value.ToString();
            ticketsAddSeat.Value++;
            Erm.Insert("tickets", new[] {"sessionID", "cashierID", "row", "seat"},
                new[] {cashierId, sessionId, row, seat});
            TabControl1_Selected(null, null);
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            string name = genresAddNameField.Text;
            genresAddNameField.Text = "";
            Erm.Insert("genres", new[] {"genre"}, new[] {name});
            TabControl1_Selected(null, null);
        }

        private void addRoomButton_Click(object sender, EventArgs e)
        {
            string name = roomsAddNameField.Text;
            roomsAddNameField.Text = "";
            Erm.Insert("rooms", new[] {"room"}, new[] {name});
            TabControl1_Selected(null, null);
        }

        private void addCashierButton_Click(object sender, EventArgs e)
        {
            string name = cashierAddNameField.Text;
            cashierAddNameField.Text = "";
            Erm.Insert("cashiers", new[] {"cashier"}, new[] {name});
            TabControl1_Selected(null, null);
        }

        private void addFilmButton_Click(object sender, EventArgs e)
        {
            string name = filmsAddNameField.Text;
            string genreId = filmsAddGenreCB.Text.Split('#')[0];
            string ageRestr = filmsAddAgeRestr.Value.ToString();
            filmsAddNameField.Text = "";

            Erm.Insert("films", new[] {"name", "genreID", "ageRest"}, new[] {name, genreId, ageRestr});
            TabControl1_Selected(null, null);
        }

        private void addSessionButton_Click(object sender, EventArgs e)
        {
            int year = sessionsAddDatePicker.Value.Year;
            int month = sessionsAddDatePicker.Value.Month;
            int day = sessionsAddDatePicker.Value.Day;
            int hours = sessionsAddTimePicker.Value.Hour;
            int minutes = sessionsAddTimePicker.Value.Minute;

            string filmId = sessionsAddFilmCB.Text.Split('#')[0];
            string roomId = sessionsAddRoomCB.Text.Split('#')[0];
            string type = sessionsAddTypeCB.Text;

            String date = new Date(day, month, year).ToString();
            String time = new Time(hours, minutes).ToString();

            Erm.Insert("sessions", new[] {"roomID", "time", "date", "filmID", "type"},
                new[] {roomId, time, date, filmId, type});
            TabControl1_Selected(null, null);

            //TODO: it's possible to add same things overall
        }

        //validating update input

        private void ticketsEditCashierCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ticketsEditCashierCB.Text) || String.IsNullOrEmpty(ticketsEditSessionCB.Text))
            {
                updateTicketButton.Enabled = false;
            }
            else
            {
                updateTicketButton.Enabled = true;
            }
        }

        private void sessionsEditFilmCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(sessionsEditFilmCB.Text) || String.IsNullOrEmpty(sessionsEditRoomCB.Text) ||
                String.IsNullOrEmpty(sessionsEditCB.Text))
            {
                sessionEditButton.Enabled = false;
            }
            else
            {
                sessionEditButton.Enabled = true;
            }
        }

        private void filmsEditNameField_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filmsEditNameField.Text) || string.IsNullOrEmpty(filmsEditGenreCB.Text))
            {
                changeFilmButton.Enabled = false;
            }
            else
            {
                changeFilmButton.Enabled = true;
            }
        }

        private void updateCashierTB_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cashierEditNameTB.Text))
            {
                updateCashierButton.Enabled = false;
            }
            else
            {
                updateCashierButton.Enabled = true;
            }
        }

        private void roomsEditNameField_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(roomsEditNameField.Text))
            {
                updateRoomButton.Enabled = false;
            }
            else
            {
                updateRoomButton.Enabled = true;
            }
        }

        private void genresEditNameField_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(genresEditNameField.Text))
            {
                changeGenreButton.Enabled = false;
            }
            else
            {
                changeGenreButton.Enabled = true;
            }
        }

        //updating stuff 

        private void updateTicketButton_Click(object sender, EventArgs e)
        {
            string newCashierId = ticketsEditCashierCB.Text.Split('#')[0];
            string newSessionId = ticketsEditSessionCB.Text.Split('#')[0];
            string newRow = ticketsEditRow.Value.ToString();
            string newSeat = ticketsEditSeat.Value.ToString();

            Erm.Update("tickets", new[] {"sessionID", "cashierID", "row", "seat"},
                new[] {newCashierId, newSessionId, newRow, newSeat},
                "ticketID", ticketsEditField.Text);
            TabControl1_Selected(null, null);
        }

        private void sessionEditButton_Click(object sender, EventArgs e)
        {
            int year = sessionsEditDatePicker.Value.Year;
            int month = sessionsEditDatePicker.Value.Month;
            int day = sessionsEditDatePicker.Value.Day;
            int hours = sessionsEditDatePicker.Value.Hour;
            int minutes = sessionsEditDatePicker.Value.Minute;

            string filmId = sessionsEditFilmCB.Text.Split('#')[0];
            string roomId = sessionsEditRoomCB.Text.Split('#')[0];
            string type = sessionsEditCB.Text;

            String date = new Date(day, month, year).ToString();
            String time = new Time(hours, minutes).ToString();

            Erm.Update("sessions", new[] {"roomID", "time", "date", "filmID", "type"},
                new[] {roomId, time, date, filmId, type},
                "sessionID", sessionsEditField.Text);
            TabControl1_Selected(null, null);
        }

        private void changeFilmButton_Click(object sender, EventArgs e)
        {
            string newName = filmsEditNameField.Text;
            string newGenreId = filmsEditGenreCB.Text.Split('#')[0];
            string newAgeRest = filmsEditAgeRestr.Value.ToString();
            Erm.Update("films", new[] {"name", "genreID", "ageRest"}, new[] {newName, newGenreId, newAgeRest},
                "filmID", filmsEditIDField.Text);
            TabControl1_Selected(null, null);
        }

        private void updateCashierButton_Click(object sender, EventArgs e)
        {
            string newName = cashierEditNameTB.Text;

            Erm.Update("cashiers", new[] {"cashier"}, new[] {newName},
                "cashierID", cashierEditIdField.Text);
            TabControl1_Selected(null, null);
        }

        private void updateRoomButton_Click(object sender, EventArgs e)
        {
            string newName = roomsEditNameField.Text;

            Erm.Update("rooms", new[] {"room"}, new[] {newName}, "roomID", roomsEditIDField.Text);
            TabControl1_Selected(null, null);
        }

        private void changeGenreButton_Click(object sender, EventArgs e)
        {
            string newName = genresEditNameField.Text;

            Erm.Update("genres", new[] {"genre"}, new[] {newName}, "genreID", genresEditIDField.Text);
            TabControl1_Selected(null, null);
        }

        //enable delete and chagne buttons and filling fields

        private void ticketsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ticketsEditGroup.Enabled = true;

            ticketsDeleteButton.Enabled = true;

            ticketsEditField.Text = ticketsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            ticketsEditRow.Value = (int) ticketsGrid.Rows[e.RowIndex].Cells[3].Value;
            ticketsEditSeat.Value = (int) ticketsGrid.Rows[e.RowIndex].Cells[4].Value;

            for (int i = 0; i < ticketsEditCashierCB.Items.Count; i++)
            {
                if (ticketsGrid.Rows[e.RowIndex].Cells[2].Value.ToString() ==
                    ticketsEditCashierCB.Items[i].ToString().Split(':')[1].Substring(1))
                {
                    ticketsEditCashierCB.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < ticketsEditSessionCB.Items.Count; i++)
            {
                if (ticketsGrid.Rows[e.RowIndex].Cells[1].Value.ToString() == ticketsEditSessionCB.Items[i].ToString())
                {
                    ticketsEditSessionCB.SelectedIndex = i;
                    break;
                }
            }
        }

        private void genresGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editGenreGroup.Enabled = true;
            deleteGenreButton.Enabled = true;

            genresEditIDField.Text = genresGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            genresEditNameField.Text = genresGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void roomsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editRoomGroup.Enabled = true;
            deleteRoomButton.Enabled = true;

            roomsEditIDField.Text = roomsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            roomsEditNameField.Text = roomsGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void cashiersGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editCashierGroup.Enabled = true;
            removeCashierButton.Enabled = true;

            cashierEditIdField.Text = cashiersGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            cashierEditNameTB.Text = cashiersGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void filmsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filmsEditGroup.Enabled = true;
            filmsDeleteButton.Enabled = true;


            filmsEditIDField.Text = filmsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            filmsEditNameField.Text = filmsGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            for (int i = 0; i < filmsEditGenreCB.Items.Count; i++)
            {
                if (filmsEditGenreCB.Items[i].ToString().Split(':')[1].Substring(1) ==
                    filmsGrid.Rows[e.RowIndex].Cells[2].Value.ToString())
                {
                    filmsEditGenreCB.SelectedIndex = i;
                    break;
                }
            }
        }

        private void sessionsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sessionsEditGroup.Enabled = true;
            sessionsDeleteButton.Enabled = true;

            sessionsEditField.Text = sessionsGrid.Rows[e.RowIndex].Cells[0].Value.ToString();

            string[] date = sessionsGrid.Rows[e.RowIndex].Cells[1].Value.ToString().Split('.');
            sessionsEditDatePicker.Value = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
            string[] time = sessionsGrid.Rows[e.RowIndex].Cells[2].Value.ToString().Split(':');

            for (int i = 0; i < sessionsEditFilmCB.Items.Count; i++)
            {
                if (sessionsEditFilmCB.Items[i].ToString().Split(':')[1].Substring(1) ==
                    sessionsGrid.Rows[e.RowIndex].Cells[3].Value.ToString())
                {
                    sessionsEditFilmCB.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < sessionsEditRoomCB.Items.Count; i++)
            {
                if (sessionsEditRoomCB.Items[i].ToString().Split(':')[1].Substring(1) ==
                    sessionsGrid.Rows[e.RowIndex].Cells[4].Value.ToString())
                {
                    sessionsEditRoomCB.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < sessionsEditCB.Items.Count; i++)
            {
                if (sessionsEditCB.Items[i].ToString() == sessionsGrid.Rows[e.RowIndex].Cells[5].Value.ToString())
                {
                    sessionsEditCB.SelectedIndex = i;
                    break;
                }
            }

            sessionEditTimePicker.Value = new DateTime(1800, 1, 1, int.Parse(time[0]), int.Parse(time[1]), 0);
        }

        //deleting stuff

        private void ticketsDeleteButton_Click(object sender, EventArgs e)
        {
            string id = ticketsGrid.CurrentRow.Cells[0].Value.ToString();
            DialogResult confirmResult = MessageBox.Show("Удалить билет " + id + "?", "Подтвердите действие",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Erm.Delete("tickets", "ticketID", id);
            }

            TabControl1_Selected(null, null);
        }

        private void sessionsDeleteButton_Click(object sender, EventArgs e)
        {
            string id = sessionsGrid.CurrentRow.Cells[0].Value.ToString();
            DialogResult confirmResult = MessageBox.Show("Удалить сеанс " + id + "?", "Подтвердите действие",
                MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Erm.Delete("sessions", "sessionID", id);
            }

            TabControl1_Selected(null, null);
        }

        private void filmsDeleteButton_Click(object sender, EventArgs e)
        {
            string id = filmsGrid.CurrentRow.Cells[0].Value.ToString();
            DialogResult confirmResult =
                MessageBox.Show("Удалить фильм " + id + ": " + filmsGrid.CurrentRow.Cells[1].Value.ToString() + "?",
                    "Подтвердите действие", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Erm.Delete("films", "filmID", id);
            }

            TabControl1_Selected(null, null);
        }

        private void removeCashierButton_Click(object sender, EventArgs e)
        {
            string id = cashiersGrid.CurrentRow.Cells[0].Value.ToString();
            DialogResult confirmResult =
                MessageBox.Show(
                    "Удалить кассира " + id + ": " + cashiersGrid.CurrentRow.Cells[1].Value.ToString() + "?",
                    "Подтвердите действие", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Erm.Delete("cashiers", "cashierID", id);
            }

            TabControl1_Selected(null, null);
        }

        private void deleteRoomButton_Click(object sender, EventArgs e)
        {
            string id = roomsGrid.CurrentRow.Cells[0].Value.ToString();
            DialogResult confirmResult =
                MessageBox.Show("Удалить зал " + id + ": " + roomsGrid.CurrentRow.Cells[1].Value.ToString() + "?",
                    "Подтвердите действие", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Erm.Delete("rooms", "roomID", id);
            }

            TabControl1_Selected(null, null);
        }

        private void deleteGenreButton_Click(object sender, EventArgs e)
        {
            string id = genresGrid.CurrentRow.Cells[0].Value.ToString();
            DialogResult confirmResult =
                MessageBox.Show("Удалить кассира " + id + ": " + genresGrid.CurrentRow.Cells[1].Value.ToString() + "?",
                    "Подтвердите действие", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Erm.Delete("genres", "genreID", id);
            }

            TabControl1_Selected(null, null);
        }

        private void filmsTicksCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmsTicksGrid.Rows.Clear();
            List<SimpleTicket> ticks = Erm.GetSimpleTickets(filmsTicksCB.SelectedItem.ToString().Split('#')[0]);
            try
            {
                filmsTicksGrid.RowCount = ticks.Count;
                for (int i = 0; i < ticks.Count; i++)
                {
                    filmsTicksGrid.Rows[i].Cells[0].Value = ticks[i].Id;
                    filmsTicksGrid.Rows[i].Cells[1].Value = ticks[i].Session;
                    filmsTicksGrid.Rows[i].Cells[2].Value = ticks[i].Seat;
                    filmsTicksGrid.Rows[i].Cells[3].Value = ticks[i].Row;
                }
                filmsTicksNoEntriesLabel.Visible = false;
                filmsTicksAmount.Visible = true;
                filmsTicksAmount.Text = ticks.Count.ToString();
            }
            catch
            {
                filmsTicksNoEntriesLabel.Visible = true;
                filmsTicksAmount.Visible = false;
            }

        }

        private void filmsGenresCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            filmsGenresGrid.Rows.Clear();
            List<SimpleFilm> films = Erm.GetSimpleFilms(filmsGenresCB.SelectedItem.ToString().Split('#')[0]);
            try
            {
                filmsGenresGrid.RowCount = films.Count;
                for(int i = 0; i < films.Count; i++)
                {
                    filmsGenresGrid.Rows[i].Cells[0].Value = films[i].Id;
                    filmsGenresGrid.Rows[i].Cells[1].Value = films[i].Name;
                    filmsGenresGrid.Rows[i].Cells[2].Value = films[i].Rest;
                }
                filmsGenresNoEntriesLabel.Visible = false;
                filmsGenresAmount.Visible = true;
                filmsGenresAmount.Text = films.Count.ToString();
            }
            catch
            {
                filmsGenresNoEntriesLabel.Visible = true;
                filmsGenresAmount.Visible = false;
            }
        }

        private void ticketsSessionsCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}