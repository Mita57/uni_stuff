namespace finalCoursach
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
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.tables = new System.Windows.Forms.ComboBox();
            this.grids = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.editTB3 = new System.Windows.Forms.TextBox();
            this.editTB2 = new System.Windows.Forms.TextBox();
            this.editDTP1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editCodeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.removeKebab = new System.Windows.Forms.Button();
            this.emptyLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.addTB4 = new System.Windows.Forms.TextBox();
            this.addTB2 = new System.Windows.Forms.TextBox();
            this.addDTP2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.addCB3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addCB1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addCodeTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.addGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(14, 7);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(906, 499);
            this.grid1.TabIndex = 0;
            this.grid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellClick);
            // 
            // tables
            // 
            this.tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tables.FormattingEnabled = true;
            this.tables.Items.AddRange(new object[] {
            "Водители",
            "Штрафы",
            "Нарушения",
            "Общая",
            "Итоговая"});
            this.tables.Location = new System.Drawing.Point(937, 37);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(218, 21);
            this.tables.TabIndex = 1;
            this.tables.Visible = false;
            this.tables.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // grids
            // 
            this.grids.AutoSize = true;
            this.grids.Location = new System.Drawing.Point(1017, 21);
            this.grids.Name = "grids";
            this.grids.Size = new System.Drawing.Size(52, 13);
            this.grids.TabIndex = 2;
            this.grids.Text = "Таблицы";
            this.grids.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.changeButton);
            this.groupBox2.Controls.Add(this.editTB3);
            this.groupBox2.Controls.Add(this.editTB2);
            this.groupBox2.Controls.Add(this.editDTP1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.editCodeTB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 82);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение элементов";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(653, 31);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(205, 39);
            this.changeButton.TabIndex = 10;
            this.changeButton.Text = "Изменить элемент";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // editTB3
            // 
            this.editTB3.Location = new System.Drawing.Point(307, 56);
            this.editTB3.Name = "editTB3";
            this.editTB3.Size = new System.Drawing.Size(125, 20);
            this.editTB3.TabIndex = 9;
            this.editTB3.Visible = false;
            // 
            // editTB2
            // 
            this.editTB2.Location = new System.Drawing.Point(139, 54);
            this.editTB2.Name = "editTB2";
            this.editTB2.Size = new System.Drawing.Size(125, 20);
            this.editTB2.TabIndex = 8;
            this.editTB2.Visible = false;
            // 
            // editDTP1
            // 
            this.editDTP1.Location = new System.Drawing.Point(466, 51);
            this.editDTP1.Name = "editDTP1";
            this.editDTP1.Size = new System.Drawing.Size(117, 20);
            this.editDTP1.TabIndex = 7;
            this.editDTP1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата нарушения";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Код нарушения";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Код водителя";
            this.label2.Visible = false;
            // 
            // editCodeTB
            // 
            this.editCodeTB.Location = new System.Drawing.Point(19, 54);
            this.editCodeTB.Name = "editCodeTB";
            this.editCodeTB.ReadOnly = true;
            this.editCodeTB.Size = new System.Drawing.Size(86, 20);
            this.editCodeTB.TabIndex = 1;
            this.editCodeTB.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код";
            this.label1.Visible = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(653, 31);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(205, 39);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить элемент";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(522, 518);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(163, 25);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // removeKebab
            // 
            this.removeKebab.BackColor = System.Drawing.Color.IndianRed;
            this.removeKebab.Enabled = false;
            this.removeKebab.Location = new System.Drawing.Point(716, 512);
            this.removeKebab.Name = "removeKebab";
            this.removeKebab.Size = new System.Drawing.Size(204, 31);
            this.removeKebab.TabIndex = 7;
            this.removeKebab.Text = "Удалить элемент";
            this.removeKebab.UseVisualStyleBackColor = false;
            this.removeKebab.Visible = false;
            this.removeKebab.Click += new System.EventHandler(this.RemoveKebab_Click);
            // 
            // emptyLabel
            // 
            this.emptyLabel.AutoSize = true;
            this.emptyLabel.Location = new System.Drawing.Point(416, 262);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(89, 13);
            this.emptyLabel.TabIndex = 8;
            this.emptyLabel.Text = "В таблице пусто";
            this.emptyLabel.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 542);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 130);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 104);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Изменение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(914, 104);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.addTB4);
            this.addGroupBox.Controls.Add(this.addTB2);
            this.addGroupBox.Controls.Add(this.addDTP2);
            this.addGroupBox.Controls.Add(this.label5);
            this.addGroupBox.Controls.Add(this.addButton);
            this.addGroupBox.Controls.Add(this.addCB3);
            this.addGroupBox.Controls.Add(this.label6);
            this.addGroupBox.Controls.Add(this.addCB1);
            this.addGroupBox.Controls.Add(this.label7);
            this.addGroupBox.Controls.Add(this.addCodeTB);
            this.addGroupBox.Controls.Add(this.label8);
            this.addGroupBox.Location = new System.Drawing.Point(8, 12);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(900, 82);
            this.addGroupBox.TabIndex = 5;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Добавление элементов";
            // 
            // addTB4
            // 
            this.addTB4.Location = new System.Drawing.Point(298, 54);
            this.addTB4.Name = "addTB4";
            this.addTB4.Size = new System.Drawing.Size(125, 20);
            this.addTB4.TabIndex = 9;
            this.addTB4.Visible = false;
            // 
            // addTB2
            // 
            this.addTB2.Location = new System.Drawing.Point(147, 54);
            this.addTB2.Name = "addTB2";
            this.addTB2.Size = new System.Drawing.Size(125, 20);
            this.addTB2.TabIndex = 8;
            this.addTB2.Visible = false;
            // 
            // addDTP2
            // 
            this.addDTP2.Location = new System.Drawing.Point(466, 51);
            this.addDTP2.Name = "addDTP2";
            this.addDTP2.Size = new System.Drawing.Size(117, 20);
            this.addDTP2.TabIndex = 7;
            this.addDTP2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Дата нарушения";
            this.label5.Visible = false;
            // 
            // addCB3
            // 
            this.addCB3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCB3.FormattingEnabled = true;
            this.addCB3.Location = new System.Drawing.Point(296, 53);
            this.addCB3.Name = "addCB3";
            this.addCB3.Size = new System.Drawing.Size(127, 21);
            this.addCB3.TabIndex = 5;
            this.addCB3.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Код нарушения";
            this.label6.Visible = false;
            // 
            // addCB1
            // 
            this.addCB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addCB1.FormattingEnabled = true;
            this.addCB1.Location = new System.Drawing.Point(145, 53);
            this.addCB1.Name = "addCB1";
            this.addCB1.Size = new System.Drawing.Size(127, 21);
            this.addCB1.TabIndex = 3;
            this.addCB1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Код водителя";
            this.label7.Visible = false;
            // 
            // addCodeTB
            // 
            this.addCodeTB.Location = new System.Drawing.Point(19, 54);
            this.addCodeTB.Name = "addCodeTB";
            this.addCodeTB.ReadOnly = true;
            this.addCodeTB.Size = new System.Drawing.Size(86, 20);
            this.addCodeTB.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Код";
            this.label8.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(931, 671);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.emptyLabel);
            this.Controls.Add(this.removeKebab);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.grids);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.grid1);
            this.Name = "Form1";
            this.Text = "СУБД228 ( ͡° ͜ʖ ͡°)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.ComboBox tables;
        private System.Windows.Forms.Label grids;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editCodeTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker editDTP1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox editTB3;
        private System.Windows.Forms.TextBox editTB2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button removeKebab;
        private System.Windows.Forms.Label emptyLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.TextBox addTB4;
        private System.Windows.Forms.TextBox addTB2;
        private System.Windows.Forms.DateTimePicker addDTP2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addCB3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addCB1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addCodeTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button changeButton;
    }
}

