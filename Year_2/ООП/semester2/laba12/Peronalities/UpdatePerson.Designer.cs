using System.ComponentModel;

namespace Peronalities
{
    partial class UpdatePerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.yearNum = new System.Windows.Forms.NumericUpDown();
            this.yearLabel = new System.Windows.Forms.Label();
            this.papaTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.progCafTB = new System.Windows.Forms.TextBox();
            this.progCafLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.debtsProgsTB = new System.Windows.Forms.TextBox();
            this.debtsProgsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentRB = new System.Windows.Forms.RadioButton();
            this.tutorRB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize) (this.yearNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 20);
            this.button3.TabIndex = 39;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 20);
            this.button1.TabIndex = 37;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yearNum
            // 
            this.yearNum.Location = new System.Drawing.Point(89, 167);
            this.yearNum.Name = "yearNum";
            this.yearNum.ReadOnly = true;
            this.yearNum.Size = new System.Drawing.Size(54, 20);
            this.yearNum.TabIndex = 36;
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(10, 170);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(77, 16);
            this.yearLabel.TabIndex = 35;
            this.yearLabel.Text = "Год обучения:";
            // 
            // papaTB
            // 
            this.papaTB.Location = new System.Drawing.Point(89, 60);
            this.papaTB.Name = "papaTB";
            this.papaTB.Size = new System.Drawing.Size(283, 20);
            this.papaTB.TabIndex = 34;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(89, 35);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(283, 20);
            this.nameTB.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Имя:";
            // 
            // groupTB
            // 
            this.groupTB.Location = new System.Drawing.Point(89, 110);
            this.groupTB.Name = "groupTB";
            this.groupTB.Size = new System.Drawing.Size(283, 20);
            this.groupTB.TabIndex = 27;
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(89, 10);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(283, 20);
            this.surnameTB.TabIndex = 25;
            // 
            // groupLabel
            // 
            this.groupLabel.Location = new System.Drawing.Point(10, 113);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(77, 16);
            this.groupLabel.TabIndex = 24;
            this.groupLabel.Text = "Группа: ";
            // 
            // progCafTB
            // 
            this.progCafTB.Location = new System.Drawing.Point(89, 85);
            this.progCafTB.Name = "progCafTB";
            this.progCafTB.Size = new System.Drawing.Size(283, 20);
            this.progCafTB.TabIndex = 26;
            // 
            // progCafLabel
            // 
            this.progCafLabel.Location = new System.Drawing.Point(10, 89);
            this.progCafLabel.Name = "progCafLabel";
            this.progCafLabel.Size = new System.Drawing.Size(77, 16);
            this.progCafLabel.TabIndex = 23;
            this.progCafLabel.Text = "Направление: ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Фамилия: ";
            // 
            // debtsProgsTB
            // 
            this.debtsProgsTB.Location = new System.Drawing.Point(89, 135);
            this.debtsProgsTB.Name = "debtsProgsTB";
            this.debtsProgsTB.Size = new System.Drawing.Size(283, 20);
            this.debtsProgsTB.TabIndex = 41;
            // 
            // debtsProgsLabel
            // 
            this.debtsProgsLabel.Location = new System.Drawing.Point(10, 138);
            this.debtsProgsLabel.Name = "debtsProgsLabel";
            this.debtsProgsLabel.Size = new System.Drawing.Size(77, 16);
            this.debtsProgsLabel.TabIndex = 40;
            this.debtsProgsLabel.Text = "Долги: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentRB);
            this.groupBox1.Controls.Add(this.tutorRB);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(148, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 75);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид персоны";
            // 
            // studentRB
            // 
            this.studentRB.Checked = true;
            this.studentRB.Enabled = false;
            this.studentRB.Location = new System.Drawing.Point(5, 19);
            this.studentRB.Name = "studentRB";
            this.studentRB.Size = new System.Drawing.Size(98, 24);
            this.studentRB.TabIndex = 6;
            this.studentRB.TabStop = true;
            this.studentRB.Text = "Студент";
            this.studentRB.UseVisualStyleBackColor = true;
            this.studentRB.CheckedChanged += new System.EventHandler(this.studentRB_CheckedChanged);
            // 
            // tutorRB
            // 
            this.tutorRB.Enabled = false;
            this.tutorRB.Location = new System.Drawing.Point(5, 46);
            this.tutorRB.Name = "tutorRB";
            this.tutorRB.Size = new System.Drawing.Size(98, 24);
            this.tutorRB.TabIndex = 7;
            this.tutorRB.Text = "Преподаватель";
            this.tutorRB.UseVisualStyleBackColor = true;
            this.tutorRB.CheckedChanged += new System.EventHandler(this.tutorRB_CheckedChanged);
            // 
            // UpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 242);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.debtsProgsTB);
            this.Controls.Add(this.debtsProgsLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yearNum);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.papaTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupTB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.progCafTB);
            this.Controls.Add(this.progCafLabel);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePerson";
            this.Text = "UpdatePerson";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdatePerson_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.yearNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label debtsProgsLabel;
        private System.Windows.Forms.TextBox debtsProgsTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.TextBox groupTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox papaTB;
        private System.Windows.Forms.Label progCafLabel;
        private System.Windows.Forms.TextBox progCafTB;
        private System.Windows.Forms.RadioButton studentRB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.RadioButton tutorRB;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.NumericUpDown yearNum;

        #endregion
    }
}