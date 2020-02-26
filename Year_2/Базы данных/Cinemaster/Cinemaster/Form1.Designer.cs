namespace Cinemaster
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tickets = new System.Windows.Forms.TabPage();
            this.sessions = new System.Windows.Forms.TabPage();
            this.films = new System.Windows.Forms.TabPage();
            this.cashiers = new System.Windows.Forms.TabPage();
            this.rooms = new System.Windows.Forms.TabPage();
            this.genres = new System.Windows.Forms.TabPage();
            this.ticketsGrid = new System.Windows.Forms.DataGridView();
            this.ticketsDeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ticketsAddCashierCB = new System.Windows.Forms.ComboBox();
            this.ticketsAddTypeCB = new System.Windows.Forms.ComboBox();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.ticketsAddIDField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ticketsAddSessionB = new System.Windows.Forms.ComboBox();
            this.ticketsAddGroup = new System.Windows.Forms.GroupBox();
            this.ticketsEditGroup = new System.Windows.Forms.GroupBox();
            this.ticketsChangeSessionCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ticketsChangeIDField = new System.Windows.Forms.TextBox();
            this.ticketEditButton = new System.Windows.Forms.Button();
            this.ticketsEditTypeCB = new System.Windows.Forms.ComboBox();
            this.ticketsChangeCashierCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionsGrid = new System.Windows.Forms.DataGridView();
            this.sessionsDeleteButton = new System.Windows.Forms.Button();
            this.sessionsAddGroup = new System.Windows.Forms.GroupBox();
            this.sessionsAddFilmCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sessionsAddIDField = new System.Windows.Forms.TextBox();
            this.addSessionButton = new System.Windows.Forms.Button();
            this.sessionsAddRoomCB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sessionsAddDatePicker = new System.Windows.Forms.DateTimePicker();
            this.sessionsAddTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.sessionsEditGroup = new System.Windows.Forms.GroupBox();
            this.sessionEditTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.sessionsEditDatePicker = new System.Windows.Forms.DateTimePicker();
            this.sessionsEditFilmCB = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.sessionsEditField = new System.Windows.Forms.TextBox();
            this.sessionEditButton = new System.Windows.Forms.Button();
            this.sessionsEditRoomCB = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.sessionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.film = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tickets.SuspendLayout();
            this.sessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGrid)).BeginInit();
            this.ticketsAddGroup.SuspendLayout();
            this.ticketsEditGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsGrid)).BeginInit();
            this.sessionsAddGroup.SuspendLayout();
            this.sessionsEditGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tickets);
            this.tabControl1.Controls.Add(this.sessions);
            this.tabControl1.Controls.Add(this.films);
            this.tabControl1.Controls.Add(this.cashiers);
            this.tabControl1.Controls.Add(this.rooms);
            this.tabControl1.Controls.Add(this.genres);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1040, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // tickets
            // 
            this.tickets.Controls.Add(this.ticketsEditGroup);
            this.tickets.Controls.Add(this.ticketsDeleteButton);
            this.tickets.Controls.Add(this.ticketsAddGroup);
            this.tickets.Controls.Add(this.ticketsGrid);
            this.tickets.Location = new System.Drawing.Point(4, 22);
            this.tickets.Name = "tickets";
            this.tickets.Padding = new System.Windows.Forms.Padding(3);
            this.tickets.Size = new System.Drawing.Size(1032, 528);
            this.tickets.TabIndex = 0;
            this.tickets.Text = "Билеты";
            this.tickets.UseVisualStyleBackColor = true;
            // 
            // sessions
            // 
            this.sessions.Controls.Add(this.sessionsEditGroup);
            this.sessions.Controls.Add(this.sessionsAddGroup);
            this.sessions.Controls.Add(this.sessionsDeleteButton);
            this.sessions.Controls.Add(this.sessionsGrid);
            this.sessions.Location = new System.Drawing.Point(4, 22);
            this.sessions.Name = "sessions";
            this.sessions.Padding = new System.Windows.Forms.Padding(3);
            this.sessions.Size = new System.Drawing.Size(1032, 528);
            this.sessions.TabIndex = 1;
            this.sessions.Text = "Сеансы";
            this.sessions.UseVisualStyleBackColor = true;
            // 
            // films
            // 
            this.films.Location = new System.Drawing.Point(4, 22);
            this.films.Name = "films";
            this.films.Size = new System.Drawing.Size(1032, 528);
            this.films.TabIndex = 2;
            this.films.Text = "Фильмы";
            this.films.UseVisualStyleBackColor = true;
            // 
            // cashiers
            // 
            this.cashiers.Location = new System.Drawing.Point(4, 22);
            this.cashiers.Name = "cashiers";
            this.cashiers.Size = new System.Drawing.Size(1032, 528);
            this.cashiers.TabIndex = 3;
            this.cashiers.Text = "Кассиры";
            this.cashiers.UseVisualStyleBackColor = true;
            // 
            // rooms
            // 
            this.rooms.Location = new System.Drawing.Point(4, 22);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(1032, 528);
            this.rooms.TabIndex = 4;
            this.rooms.Text = "Кинозалы";
            this.rooms.UseVisualStyleBackColor = true;
            // 
            // genres
            // 
            this.genres.Location = new System.Drawing.Point(4, 22);
            this.genres.Name = "genres";
            this.genres.Size = new System.Drawing.Size(1032, 528);
            this.genres.TabIndex = 5;
            this.genres.Text = "Жанры";
            this.genres.UseVisualStyleBackColor = true;
            // 
            // ticketsGrid
            // 
            this.ticketsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketID,
            this.session,
            this.cashier,
            this.type});
            this.ticketsGrid.Location = new System.Drawing.Point(6, 5);
            this.ticketsGrid.Name = "ticketsGrid";
            this.ticketsGrid.RowHeadersVisible = false;
            this.ticketsGrid.Size = new System.Drawing.Size(748, 515);
            this.ticketsGrid.TabIndex = 0;
            // 
            // ticketsDeleteButton
            // 
            this.ticketsDeleteButton.BackColor = System.Drawing.Color.Tomato;
            this.ticketsDeleteButton.Location = new System.Drawing.Point(772, 471);
            this.ticketsDeleteButton.Name = "ticketsDeleteButton";
            this.ticketsDeleteButton.Size = new System.Drawing.Size(247, 34);
            this.ticketsDeleteButton.TabIndex = 9;
            this.ticketsDeleteButton.Text = "Удалить билет";
            this.ticketsDeleteButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кассир:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип:";
            // 
            // ticketsAddCashierCB
            // 
            this.ticketsAddCashierCB.FormattingEnabled = true;
            this.ticketsAddCashierCB.Location = new System.Drawing.Point(58, 44);
            this.ticketsAddCashierCB.Name = "ticketsAddCashierCB";
            this.ticketsAddCashierCB.Size = new System.Drawing.Size(186, 21);
            this.ticketsAddCashierCB.TabIndex = 4;
            // 
            // ticketsAddTypeCB
            // 
            this.ticketsAddTypeCB.FormattingEnabled = true;
            this.ticketsAddTypeCB.Items.AddRange(new object[] {
            "2D",
            "3D",
            "IMAX 2D",
            "IMAX 3D"});
            this.ticketsAddTypeCB.Location = new System.Drawing.Point(58, 96);
            this.ticketsAddTypeCB.Name = "ticketsAddTypeCB";
            this.ticketsAddTypeCB.Size = new System.Drawing.Size(186, 21);
            this.ticketsAddTypeCB.TabIndex = 5;
            // 
            // addTicketButton
            // 
            this.addTicketButton.Location = new System.Drawing.Point(10, 130);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(247, 34);
            this.addTicketButton.TabIndex = 6;
            this.addTicketButton.Text = "Добавить билет";
            this.addTicketButton.UseVisualStyleBackColor = true;
            // 
            // ticketsAddIDField
            // 
            this.ticketsAddIDField.Location = new System.Drawing.Point(58, 19);
            this.ticketsAddIDField.Name = "ticketsAddIDField";
            this.ticketsAddIDField.ReadOnly = true;
            this.ticketsAddIDField.Size = new System.Drawing.Size(186, 20);
            this.ticketsAddIDField.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Сеанс:";
            // 
            // ticketsAddSessionB
            // 
            this.ticketsAddSessionB.FormattingEnabled = true;
            this.ticketsAddSessionB.Items.AddRange(new object[] {
            "2D",
            "3D",
            "IMAX 2D",
            "IMAX 3D"});
            this.ticketsAddSessionB.Location = new System.Drawing.Point(58, 70);
            this.ticketsAddSessionB.Name = "ticketsAddSessionB";
            this.ticketsAddSessionB.Size = new System.Drawing.Size(186, 21);
            this.ticketsAddSessionB.TabIndex = 9;
            // 
            // ticketsAddGroup
            // 
            this.ticketsAddGroup.Controls.Add(this.ticketsAddSessionB);
            this.ticketsAddGroup.Controls.Add(this.label8);
            this.ticketsAddGroup.Controls.Add(this.ticketsAddIDField);
            this.ticketsAddGroup.Controls.Add(this.addTicketButton);
            this.ticketsAddGroup.Controls.Add(this.ticketsAddTypeCB);
            this.ticketsAddGroup.Controls.Add(this.ticketsAddCashierCB);
            this.ticketsAddGroup.Controls.Add(this.label3);
            this.ticketsAddGroup.Controls.Add(this.label2);
            this.ticketsAddGroup.Controls.Add(this.label1);
            this.ticketsAddGroup.Location = new System.Drawing.Point(762, 10);
            this.ticketsAddGroup.Name = "ticketsAddGroup";
            this.ticketsAddGroup.Size = new System.Drawing.Size(263, 183);
            this.ticketsAddGroup.TabIndex = 1;
            this.ticketsAddGroup.TabStop = false;
            this.ticketsAddGroup.Text = "Добавить билет";
            // 
            // ticketsEditGroup
            // 
            this.ticketsEditGroup.Controls.Add(this.ticketsChangeSessionCB);
            this.ticketsEditGroup.Controls.Add(this.label4);
            this.ticketsEditGroup.Controls.Add(this.ticketsChangeIDField);
            this.ticketsEditGroup.Controls.Add(this.ticketEditButton);
            this.ticketsEditGroup.Controls.Add(this.ticketsEditTypeCB);
            this.ticketsEditGroup.Controls.Add(this.ticketsChangeCashierCB);
            this.ticketsEditGroup.Controls.Add(this.label5);
            this.ticketsEditGroup.Controls.Add(this.label6);
            this.ticketsEditGroup.Controls.Add(this.label7);
            this.ticketsEditGroup.Location = new System.Drawing.Point(760, 229);
            this.ticketsEditGroup.Name = "ticketsEditGroup";
            this.ticketsEditGroup.Size = new System.Drawing.Size(263, 183);
            this.ticketsEditGroup.TabIndex = 10;
            this.ticketsEditGroup.TabStop = false;
            this.ticketsEditGroup.Text = "Изменить билет";
            // 
            // ticketsChangeSessionCB
            // 
            this.ticketsChangeSessionCB.FormattingEnabled = true;
            this.ticketsChangeSessionCB.Items.AddRange(new object[] {
            "2D",
            "3D",
            "IMAX 2D",
            "IMAX 3D"});
            this.ticketsChangeSessionCB.Location = new System.Drawing.Point(58, 70);
            this.ticketsChangeSessionCB.Name = "ticketsChangeSessionCB";
            this.ticketsChangeSessionCB.Size = new System.Drawing.Size(186, 21);
            this.ticketsChangeSessionCB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Сеанс:";
            // 
            // ticketsChangeIDField
            // 
            this.ticketsChangeIDField.Location = new System.Drawing.Point(58, 19);
            this.ticketsChangeIDField.Name = "ticketsChangeIDField";
            this.ticketsChangeIDField.ReadOnly = true;
            this.ticketsChangeIDField.Size = new System.Drawing.Size(186, 20);
            this.ticketsChangeIDField.TabIndex = 7;
            // 
            // ticketEditButton
            // 
            this.ticketEditButton.Location = new System.Drawing.Point(10, 130);
            this.ticketEditButton.Name = "ticketEditButton";
            this.ticketEditButton.Size = new System.Drawing.Size(247, 34);
            this.ticketEditButton.TabIndex = 6;
            this.ticketEditButton.Text = "Сохранить изменения";
            this.ticketEditButton.UseVisualStyleBackColor = true;
            // 
            // ticketsEditTypeCB
            // 
            this.ticketsEditTypeCB.FormattingEnabled = true;
            this.ticketsEditTypeCB.Items.AddRange(new object[] {
            "2D",
            "3D",
            "IMAX 2D",
            "IMAX 3D"});
            this.ticketsEditTypeCB.Location = new System.Drawing.Point(58, 96);
            this.ticketsEditTypeCB.Name = "ticketsEditTypeCB";
            this.ticketsEditTypeCB.Size = new System.Drawing.Size(186, 21);
            this.ticketsEditTypeCB.TabIndex = 5;
            // 
            // ticketsChangeCashierCB
            // 
            this.ticketsChangeCashierCB.FormattingEnabled = true;
            this.ticketsChangeCashierCB.Location = new System.Drawing.Point(58, 44);
            this.ticketsChangeCashierCB.Name = "ticketsChangeCashierCB";
            this.ticketsChangeCashierCB.Size = new System.Drawing.Size(186, 21);
            this.ticketsChangeCashierCB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Тип:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Кассир:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Номер:";
            // 
            // type
            // 
            this.type.HeaderText = "Тип";
            this.type.Name = "type";
            this.type.Width = 216;
            // 
            // cashier
            // 
            this.cashier.HeaderText = "Кассир";
            this.cashier.Name = "cashier";
            this.cashier.Width = 216;
            // 
            // session
            // 
            this.session.HeaderText = "Сеанс";
            this.session.Name = "session";
            this.session.Width = 216;
            // 
            // ticketID
            // 
            this.ticketID.HeaderText = "ID";
            this.ticketID.Name = "ticketID";
            this.ticketID.Width = 97;
            // 
            // sessionsGrid
            // 
            this.sessionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionID,
            this.date,
            this.time,
            this.film,
            this.room});
            this.sessionsGrid.Location = new System.Drawing.Point(6, 5);
            this.sessionsGrid.Name = "sessionsGrid";
            this.sessionsGrid.RowHeadersVisible = false;
            this.sessionsGrid.Size = new System.Drawing.Size(748, 515);
            this.sessionsGrid.TabIndex = 1;
            // 
            // sessionsDeleteButton
            // 
            this.sessionsDeleteButton.BackColor = System.Drawing.Color.Tomato;
            this.sessionsDeleteButton.Location = new System.Drawing.Point(772, 471);
            this.sessionsDeleteButton.Name = "sessionsDeleteButton";
            this.sessionsDeleteButton.Size = new System.Drawing.Size(247, 34);
            this.sessionsDeleteButton.TabIndex = 10;
            this.sessionsDeleteButton.Text = "Удалить сеанс";
            this.sessionsDeleteButton.UseVisualStyleBackColor = false;
            // 
            // sessionsAddGroup
            // 
            this.sessionsAddGroup.Controls.Add(this.sessionsAddTimePicker);
            this.sessionsAddGroup.Controls.Add(this.label17);
            this.sessionsAddGroup.Controls.Add(this.sessionsAddDatePicker);
            this.sessionsAddGroup.Controls.Add(this.sessionsAddFilmCB);
            this.sessionsAddGroup.Controls.Add(this.label9);
            this.sessionsAddGroup.Controls.Add(this.sessionsAddIDField);
            this.sessionsAddGroup.Controls.Add(this.addSessionButton);
            this.sessionsAddGroup.Controls.Add(this.sessionsAddRoomCB);
            this.sessionsAddGroup.Controls.Add(this.label10);
            this.sessionsAddGroup.Controls.Add(this.label11);
            this.sessionsAddGroup.Controls.Add(this.label12);
            this.sessionsAddGroup.Location = new System.Drawing.Point(762, 10);
            this.sessionsAddGroup.Name = "sessionsAddGroup";
            this.sessionsAddGroup.Size = new System.Drawing.Size(263, 199);
            this.sessionsAddGroup.TabIndex = 11;
            this.sessionsAddGroup.TabStop = false;
            this.sessionsAddGroup.Text = "Добавить сеанс";
            // 
            // sessionsAddFilmCB
            // 
            this.sessionsAddFilmCB.FormattingEnabled = true;
            this.sessionsAddFilmCB.Items.AddRange(new object[] {
            "2D",
            "3D",
            "IMAX 2D",
            "IMAX 3D"});
            this.sessionsAddFilmCB.Location = new System.Drawing.Point(58, 97);
            this.sessionsAddFilmCB.Name = "sessionsAddFilmCB";
            this.sessionsAddFilmCB.Size = new System.Drawing.Size(186, 21);
            this.sessionsAddFilmCB.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Фильм:";
            // 
            // sessionsAddIDField
            // 
            this.sessionsAddIDField.Location = new System.Drawing.Point(58, 19);
            this.sessionsAddIDField.Name = "sessionsAddIDField";
            this.sessionsAddIDField.ReadOnly = true;
            this.sessionsAddIDField.Size = new System.Drawing.Size(186, 20);
            this.sessionsAddIDField.TabIndex = 7;
            // 
            // addSessionButton
            // 
            this.addSessionButton.Location = new System.Drawing.Point(9, 155);
            this.addSessionButton.Name = "addSessionButton";
            this.addSessionButton.Size = new System.Drawing.Size(247, 34);
            this.addSessionButton.TabIndex = 6;
            this.addSessionButton.Text = "Добавить сеанс";
            this.addSessionButton.UseVisualStyleBackColor = true;
            // 
            // sessionsAddRoomCB
            // 
            this.sessionsAddRoomCB.FormattingEnabled = true;
            this.sessionsAddRoomCB.Items.AddRange(new object[] {
            "2D",
            "3D",
            "IMAX 2D",
            "IMAX 3D"});
            this.sessionsAddRoomCB.Location = new System.Drawing.Point(58, 124);
            this.sessionsAddRoomCB.Name = "sessionsAddRoomCB";
            this.sessionsAddRoomCB.Size = new System.Drawing.Size(186, 21);
            this.sessionsAddRoomCB.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Зал:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Дата:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Номер:";
            // 
            // sessionsAddDatePicker
            // 
            this.sessionsAddDatePicker.Location = new System.Drawing.Point(58, 45);
            this.sessionsAddDatePicker.Name = "sessionsAddDatePicker";
            this.sessionsAddDatePicker.Size = new System.Drawing.Size(186, 20);
            this.sessionsAddDatePicker.TabIndex = 10;
            // 
            // sessionsAddTimePicker
            // 
            this.sessionsAddTimePicker.CustomFormat = "HH:mm";
            this.sessionsAddTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sessionsAddTimePicker.Location = new System.Drawing.Point(58, 71);
            this.sessionsAddTimePicker.Name = "sessionsAddTimePicker";
            this.sessionsAddTimePicker.ShowUpDown = true;
            this.sessionsAddTimePicker.Size = new System.Drawing.Size(186, 20);
            this.sessionsAddTimePicker.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Время:";
            // 
            // sessionsEditGroup
            // 
            this.sessionsEditGroup.Controls.Add(this.sessionEditTimePicker);
            this.sessionsEditGroup.Controls.Add(this.label13);
            this.sessionsEditGroup.Controls.Add(this.sessionsEditDatePicker);
            this.sessionsEditGroup.Controls.Add(this.sessionsEditFilmCB);
            this.sessionsEditGroup.Controls.Add(this.label14);
            this.sessionsEditGroup.Controls.Add(this.sessionsEditField);
            this.sessionsEditGroup.Controls.Add(this.sessionEditButton);
            this.sessionsEditGroup.Controls.Add(this.sessionsEditRoomCB);
            this.sessionsEditGroup.Controls.Add(this.label15);
            this.sessionsEditGroup.Controls.Add(this.label16);
            this.sessionsEditGroup.Controls.Add(this.label18);
            this.sessionsEditGroup.Location = new System.Drawing.Point(760, 229);
            this.sessionsEditGroup.Name = "sessionsEditGroup";
            this.sessionsEditGroup.Size = new System.Drawing.Size(263, 199);
            this.sessionsEditGroup.TabIndex = 13;
            this.sessionsEditGroup.TabStop = false;
            this.sessionsEditGroup.Text = "Изменить сеанс";
            // 
            // sessionEditTimePicker
            // 
            this.sessionEditTimePicker.CustomFormat = "HH:mm";
            this.sessionEditTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sessionEditTimePicker.Location = new System.Drawing.Point(58, 71);
            this.sessionEditTimePicker.Name = "sessionEditTimePicker";
            this.sessionEditTimePicker.ShowUpDown = true;
            this.sessionEditTimePicker.Size = new System.Drawing.Size(186, 20);
            this.sessionEditTimePicker.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Время:";
            // 
            // sessionsEditDatePicker
            // 
            this.sessionsEditDatePicker.Location = new System.Drawing.Point(58, 45);
            this.sessionsEditDatePicker.Name = "sessionsEditDatePicker";
            this.sessionsEditDatePicker.Size = new System.Drawing.Size(186, 20);
            this.sessionsEditDatePicker.TabIndex = 10;
            // 
            // sessionsEditFilmCB
            // 
            this.sessionsEditFilmCB.FormattingEnabled = true;
            this.sessionsEditFilmCB.Items.AddRange(new object[] {
            "2D",
            "3D",
            "IMAX 2D",
            "IMAX 3D"});
            this.sessionsEditFilmCB.Location = new System.Drawing.Point(58, 97);
            this.sessionsEditFilmCB.Name = "sessionsEditFilmCB";
            this.sessionsEditFilmCB.Size = new System.Drawing.Size(186, 21);
            this.sessionsEditFilmCB.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Фильм:";
            // 
            // sessionsEditField
            // 
            this.sessionsEditField.Location = new System.Drawing.Point(58, 19);
            this.sessionsEditField.Name = "sessionsEditField";
            this.sessionsEditField.ReadOnly = true;
            this.sessionsEditField.Size = new System.Drawing.Size(186, 20);
            this.sessionsEditField.TabIndex = 7;
            // 
            // sessionEditButton
            // 
            this.sessionEditButton.Location = new System.Drawing.Point(9, 155);
            this.sessionEditButton.Name = "sessionEditButton";
            this.sessionEditButton.Size = new System.Drawing.Size(247, 34);
            this.sessionEditButton.TabIndex = 6;
            this.sessionEditButton.Text = "Добавить сеанс";
            this.sessionEditButton.UseVisualStyleBackColor = true;
            // 
            // sessionsEditRoomCB
            // 
            this.sessionsEditRoomCB.FormattingEnabled = true;
            this.sessionsEditRoomCB.Items.AddRange(new object[] {
            "2D",
            "3D",
            "IMAX 2D",
            "IMAX 3D"});
            this.sessionsEditRoomCB.Location = new System.Drawing.Point(58, 124);
            this.sessionsEditRoomCB.Name = "sessionsEditRoomCB";
            this.sessionsEditRoomCB.Size = new System.Drawing.Size(186, 21);
            this.sessionsEditRoomCB.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Зал:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Дата:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Номер:";
            // 
            // sessionID
            // 
            this.sessionID.HeaderText = "ID";
            this.sessionID.Name = "sessionID";
            this.sessionID.Width = 89;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.Width = 164;
            // 
            // time
            // 
            this.time.HeaderText = "Время";
            this.time.Name = "time";
            this.time.Width = 164;
            // 
            // film
            // 
            this.film.HeaderText = "Фильм";
            this.film.Name = "film";
            this.film.Width = 164;
            // 
            // room
            // 
            this.room.HeaderText = "Зал";
            this.room.Name = "room";
            this.room.Width = 164;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 551);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cinemaster";
            this.tabControl1.ResumeLayout(false);
            this.tickets.ResumeLayout(false);
            this.sessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGrid)).EndInit();
            this.ticketsAddGroup.ResumeLayout(false);
            this.ticketsAddGroup.PerformLayout();
            this.ticketsEditGroup.ResumeLayout(false);
            this.ticketsEditGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsGrid)).EndInit();
            this.sessionsAddGroup.ResumeLayout(false);
            this.sessionsAddGroup.PerformLayout();
            this.sessionsEditGroup.ResumeLayout(false);
            this.sessionsEditGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tickets;
        private System.Windows.Forms.TabPage sessions;
        private System.Windows.Forms.DataGridView ticketsGrid;
        private System.Windows.Forms.TabPage films;
        private System.Windows.Forms.TabPage cashiers;
        private System.Windows.Forms.TabPage rooms;
        private System.Windows.Forms.TabPage genres;
        private System.Windows.Forms.Button ticketsDeleteButton;
        private System.Windows.Forms.GroupBox ticketsAddGroup;
        private System.Windows.Forms.ComboBox ticketsAddSessionB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ticketsAddIDField;
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.ComboBox ticketsAddTypeCB;
        private System.Windows.Forms.ComboBox ticketsAddCashierCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ticketsEditGroup;
        private System.Windows.Forms.ComboBox ticketsChangeSessionCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ticketsChangeIDField;
        private System.Windows.Forms.Button ticketEditButton;
        private System.Windows.Forms.ComboBox ticketsEditTypeCB;
        private System.Windows.Forms.ComboBox ticketsChangeCashierCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketID;
        private System.Windows.Forms.DataGridViewTextBoxColumn session;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashier;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridView sessionsGrid;
        private System.Windows.Forms.Button sessionsDeleteButton;
        private System.Windows.Forms.GroupBox sessionsAddGroup;
        private System.Windows.Forms.ComboBox sessionsAddFilmCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sessionsAddIDField;
        private System.Windows.Forms.Button addSessionButton;
        private System.Windows.Forms.ComboBox sessionsAddRoomCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker sessionsAddDatePicker;
        private System.Windows.Forms.DateTimePicker sessionsAddTimePicker;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox sessionsEditGroup;
        private System.Windows.Forms.DateTimePicker sessionEditTimePicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker sessionsEditDatePicker;
        private System.Windows.Forms.ComboBox sessionsEditFilmCB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox sessionsEditField;
        private System.Windows.Forms.Button sessionEditButton;
        private System.Windows.Forms.ComboBox sessionsEditRoomCB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn film;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
    }
}

