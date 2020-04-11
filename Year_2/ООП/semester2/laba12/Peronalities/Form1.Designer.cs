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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.progCafTB = new System.Windows.Forms.TextBox();
            this.groupTB = new System.Windows.Forms.TextBox();
            this.studentRB = new System.Windows.Forms.RadioButton();
            this.tutorRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
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
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(100, 10);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(329, 23);
            this.nameTB.TabIndex = 3;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид персоны";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(182, 240);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(315, 240);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(114, 23);
            this.listButton.TabIndex = 10;
            this.listButton.Text = "Список студентов";
            this.listButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(329, 23);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(100, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(329, 23);
            this.textBox2.TabIndex = 13;
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
            this.yearLabel.Location = new System.Drawing.Point(8, 158);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(90, 18);
            this.yearLabel.TabIndex = 15;
            this.yearLabel.Text = "Год обучения:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(100, 155);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(63, 23);
            this.numericUpDown1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Список всех";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Список преподов";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(182, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Tomato;
            this.button4.Location = new System.Drawing.Point(182, 269);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(182, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Загрузить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 297);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupTB);
            this.Controls.Add(this.progCafTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.progCafLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Peronalities";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RadioButton tutorRB;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label progCafLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
    }
}