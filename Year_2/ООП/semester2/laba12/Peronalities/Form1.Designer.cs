namespace Peronalities
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
            this.label1 = new System.Windows.Forms.Label();
            this.progCafLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.progCafTB = new System.Windows.Forms.TextBox();
            this.groupTB = new System.Windows.Forms.TextBox();
            this.studentRB = new System.Windows.Forms.RadioButton();
            this.tutorRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.listStudents = new System.Windows.Forms.Button();
            this.patTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearNum = new System.Windows.Forms.NumericUpDown();
            this.listAll = new System.Windows.Forms.Button();
            this.listTutors = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.debtsProgsTB = new System.Windows.Forms.TextBox();
            this.debtsProgsLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.yearNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия: ";
            // 
            // progCafLabel
            // 
            this.progCafLabel.Location = new System.Drawing.Point(8, 102);
            this.progCafLabel.Name = "progCafLabel";
            this.progCafLabel.Size = new System.Drawing.Size(90, 18);
            this.progCafLabel.TabIndex = 1;
            this.progCafLabel.Text = "Направление: ";
            // 
            // groupLabel
            // 
            this.groupLabel.Location = new System.Drawing.Point(8, 129);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(90, 18);
            this.groupLabel.TabIndex = 2;
            this.groupLabel.Text = "Группа: ";
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(100, 10);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.ReadOnly = true;
            this.surnameTB.Size = new System.Drawing.Size(329, 23);
            this.surnameTB.TabIndex = 3;
            // 
            // progCafTB
            // 
            this.progCafTB.Location = new System.Drawing.Point(100, 97);
            this.progCafTB.Name = "progCafTB";
            this.progCafTB.ReadOnly = true;
            this.progCafTB.Size = new System.Drawing.Size(329, 23);
            this.progCafTB.TabIndex = 4;
            // 
            // groupTB
            // 
            this.groupTB.Location = new System.Drawing.Point(100, 126);
            this.groupTB.Name = "groupTB";
            this.groupTB.ReadOnly = true;
            this.groupTB.Size = new System.Drawing.Size(329, 23);
            this.groupTB.TabIndex = 5;
            // 
            // studentRB
            // 
            this.studentRB.Checked = true;
            this.studentRB.Enabled = false;
            this.studentRB.Location = new System.Drawing.Point(6, 22);
            this.studentRB.Name = "studentRB";
            this.studentRB.Size = new System.Drawing.Size(114, 28);
            this.studentRB.TabIndex = 6;
            this.studentRB.TabStop = true;
            this.studentRB.Text = "Студент";
            this.studentRB.UseVisualStyleBackColor = true;
            this.studentRB.CheckedChanged += new System.EventHandler(this.studentRB_CheckedChanged);
            // 
            // tutorRB
            // 
            this.tutorRB.Enabled = false;
            this.tutorRB.Location = new System.Drawing.Point(6, 53);
            this.tutorRB.Name = "tutorRB";
            this.tutorRB.Size = new System.Drawing.Size(114, 28);
            this.tutorRB.TabIndex = 7;
            this.tutorRB.Text = "Преподаватель";
            this.tutorRB.UseVisualStyleBackColor = true;
            this.tutorRB.CheckedChanged += new System.EventHandler(this.tutorRB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentRB);
            this.groupBox1.Controls.Add(this.tutorRB);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(8, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид персоны";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(178, 253);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // listStudents
            // 
            this.listStudents.Location = new System.Drawing.Point(311, 253);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(114, 23);
            this.listStudents.TabIndex = 10;
            this.listStudents.Text = "Список студентов";
            this.listStudents.UseVisualStyleBackColor = true;
            this.listStudents.Click += new System.EventHandler(this.listStudents_Click);
            // 
            // patTB
            // 
            this.patTB.Location = new System.Drawing.Point(100, 68);
            this.patTB.Name = "patTB";
            this.patTB.ReadOnly = true;
            this.patTB.Size = new System.Drawing.Size(329, 23);
            this.patTB.TabIndex = 14;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(100, 39);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(329, 23);
            this.nameTB.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Имя:";
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(8, 190);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(90, 18);
            this.yearLabel.TabIndex = 15;
            this.yearLabel.Text = "Год обучения:";
            // 
            // yearNum
            // 
            this.yearNum.Location = new System.Drawing.Point(100, 187);
            this.yearNum.Name = "yearNum";
            this.yearNum.ReadOnly = true;
            this.yearNum.Size = new System.Drawing.Size(63, 23);
            this.yearNum.TabIndex = 16;
            // 
            // listAll
            // 
            this.listAll.Location = new System.Drawing.Point(311, 224);
            this.listAll.Name = "listAll";
            this.listAll.Size = new System.Drawing.Size(114, 23);
            this.listAll.TabIndex = 17;
            this.listAll.Text = "Список всех";
            this.listAll.UseVisualStyleBackColor = true;
            this.listAll.Click += new System.EventHandler(this.listAll_Click);
            // 
            // listTutors
            // 
            this.listTutors.Location = new System.Drawing.Point(311, 280);
            this.listTutors.Name = "listTutors";
            this.listTutors.Size = new System.Drawing.Size(114, 23);
            this.listTutors.TabIndex = 18;
            this.listTutors.Text = "Список преподов";
            this.listTutors.UseVisualStyleBackColor = true;
            this.listTutors.Click += new System.EventHandler(this.listTutors_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(178, 224);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(114, 23);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Изменить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Tomato;
            this.removeButton.Enabled = false;
            this.removeButton.Location = new System.Drawing.Point(178, 282);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(114, 23);
            this.removeButton.TabIndex = 20;
            this.removeButton.Text = "Удалить";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(178, 195);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(114, 23);
            this.loadButton.TabIndex = 21;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(310, 195);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(31, 21);
            this.startButton.TabIndex = 22;
            this.startButton.Text = "<<";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(346, 195);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(21, 21);
            this.prevButton.TabIndex = 23;
            this.prevButton.Text = "<";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(398, 195);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(31, 21);
            this.lastButton.TabIndex = 25;
            this.lastButton.Text = ">>";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(371, 195);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(21, 21);
            this.nextButton.TabIndex = 26;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // debtsProgsTB
            // 
            this.debtsProgsTB.Location = new System.Drawing.Point(100, 155);
            this.debtsProgsTB.Name = "debtsProgsTB";
            this.debtsProgsTB.ReadOnly = true;
            this.debtsProgsTB.Size = new System.Drawing.Size(329, 23);
            this.debtsProgsTB.TabIndex = 29;
            // 
            // debtsProgsLabel
            // 
            this.debtsProgsLabel.Location = new System.Drawing.Point(8, 160);
            this.debtsProgsLabel.Name = "debtsProgsLabel";
            this.debtsProgsLabel.Size = new System.Drawing.Size(90, 18);
            this.debtsProgsLabel.TabIndex = 27;
            this.debtsProgsLabel.Text = "Долги";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text File | *.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 315);
            this.Controls.Add(this.debtsProgsTB);
            this.Controls.Add(this.debtsProgsLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.listTutors);
            this.Controls.Add(this.listAll);
            this.Controls.Add(this.yearNum);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.patTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listStudents);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupTB);
            this.Controls.Add(this.progCafTB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.progCafLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Peronalities";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.yearNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox groupTB;
        private System.Windows.Forms.TextBox progCafTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton studentRB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RadioButton tutorRB;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label progCafLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button listAll;
        private System.Windows.Forms.Button listTutors;
        private System.Windows.Forms.Button listStudents;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox patTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.Label debtsProgsLabel;
        private System.Windows.Forms.TextBox debtsProgsTB;
        private System.Windows.Forms.NumericUpDown yearNum;
    }
}