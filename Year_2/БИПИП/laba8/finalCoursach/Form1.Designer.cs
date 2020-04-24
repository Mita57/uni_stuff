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
            this.removeKebab = new System.Windows.Forms.Button();
            this.emptyLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.amounTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addTB4 = new System.Windows.Forms.TextBox();
            this.addTB2 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addCodeTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.editTB3 = new System.Windows.Forms.TextBox();
            this.editTB2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.editCodeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize) (this.grid1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.addGroupBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(14, 27);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(906, 479);
            this.grid1.TabIndex = 0;
            this.grid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid1_CellClick);
            // 
            // tables
            // 
            this.tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tables.FormattingEnabled = true;
            this.tables.Items.AddRange(new object[] {"Водители", "Штрафы", "Нарушения", "Общая", "Итоговая"});
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
            // removeKebab
            // 
            this.removeKebab.BackColor = System.Drawing.Color.IndianRed;
            this.removeKebab.Enabled = false;
            this.removeKebab.Location = new System.Drawing.Point(653, 13);
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
            this.addGroupBox.Controls.Add(this.amounTB);
            this.addGroupBox.Controls.Add(this.label4);
            this.addGroupBox.Controls.Add(this.addTB4);
            this.addGroupBox.Controls.Add(this.addTB2);
            this.addGroupBox.Controls.Add(this.addButton);
            this.addGroupBox.Controls.Add(this.label6);
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
            // amounTB
            // 
            this.amounTB.Location = new System.Drawing.Point(480, 54);
            this.amounTB.Name = "amounTB";
            this.amounTB.Size = new System.Drawing.Size(125, 20);
            this.amounTB.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Количество";
            // 
            // addTB4
            // 
            this.addTB4.Location = new System.Drawing.Point(307, 54);
            this.addTB4.Name = "addTB4";
            this.addTB4.Size = new System.Drawing.Size(125, 20);
            this.addTB4.TabIndex = 9;
            this.addTB4.Visible = false;
            // 
            // addTB2
            // 
            this.addTB2.Location = new System.Drawing.Point(139, 54);
            this.addTB2.Name = "addTB2";
            this.addTB2.Size = new System.Drawing.Size(125, 20);
            this.addTB2.TabIndex = 8;
            this.addTB2.Visible = false;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Цена";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Название";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.removeKebab);
            this.groupBox2.Controls.Add(this.changeButton);
            this.groupBox2.Controls.Add(this.editTB3);
            this.groupBox2.Controls.Add(this.editTB2);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Количество";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(653, 50);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(205, 26);
            this.changeButton.TabIndex = 10;
            this.changeButton.Text = "Изменить элемент";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // editTB3
            // 
            this.editTB3.Location = new System.Drawing.Point(307, 54);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цена";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.новыйToolStripMenuItem, this.открытьToolStripMenuItem, this.сохранитьToolStripMenuItem, this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click_1);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML Files|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML Files|*.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(931, 671);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.emptyLabel);
            this.Controls.Add(this.grids);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "СУБД228 ( ͡° ͜ʖ ͡°)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.grid1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addCodeTB;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.TextBox addTB2;
        private System.Windows.Forms.TextBox addTB4;
        private System.Windows.Forms.TextBox amounTB;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox editCodeTB;
        private System.Windows.Forms.TextBox editTB2;
        private System.Windows.Forms.TextBox editTB3;
        private System.Windows.Forms.Label emptyLabel;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Label grids;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button removeKebab;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox tables;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;

        #endregion
    }
}

