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
            this.room = new System.Windows.Forms.TabPage();
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
            this.tabControl1.SuspendLayout();
            this.tickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGrid)).BeginInit();
            this.ticketsAddGroup.SuspendLayout();
            this.ticketsEditGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tickets);
            this.tabControl1.Controls.Add(this.sessions);
            this.tabControl1.Controls.Add(this.films);
            this.tabControl1.Controls.Add(this.cashiers);
            this.tabControl1.Controls.Add(this.room);
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
            // room
            // 
            this.room.Location = new System.Drawing.Point(4, 22);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(1032, 528);
            this.room.TabIndex = 4;
            this.room.Text = "Кинозал";
            this.room.UseVisualStyleBackColor = true;
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
            this.ticketsGrid.Location = new System.Drawing.Point(6, 5);
            this.ticketsGrid.Name = "ticketsGrid";
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
            ((System.ComponentModel.ISupportInitialize)(this.ticketsGrid)).EndInit();
            this.ticketsAddGroup.ResumeLayout(false);
            this.ticketsAddGroup.PerformLayout();
            this.ticketsEditGroup.ResumeLayout(false);
            this.ticketsEditGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tickets;
        private System.Windows.Forms.TabPage sessions;
        private System.Windows.Forms.DataGridView ticketsGrid;
        private System.Windows.Forms.TabPage films;
        private System.Windows.Forms.TabPage cashiers;
        private System.Windows.Forms.TabPage room;
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
    }
}

