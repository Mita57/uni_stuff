using System.ComponentModel;

namespace Peronalities
{
    partial class AddPerson
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.yearNum = new System.Windows.Forms.NumericUpDown();
            this.yearLabel = new System.Windows.Forms.Label();
            this.parTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentRB = new System.Windows.Forms.RadioButton();
            this.tutorRB = new System.Windows.Forms.RadioButton();
            this.groupTB = new System.Windows.Forms.TextBox();
            this.surnameTB = new System.Windows.Forms.TextBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.progCafTB = new System.Windows.Forms.TextBox();
            this.progCafLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.debtsProgsTB = new System.Windows.Forms.TextBox();
            this.debtsProgsLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize) (this.yearNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(318, 283);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 23);
            this.cancelButton.TabIndex = 41;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // yearNum
            // 
            this.yearNum.Location = new System.Drawing.Point(104, 192);
            this.yearNum.Name = "yearNum";
            this.yearNum.Size = new System.Drawing.Size(63, 23);
            this.yearNum.TabIndex = 36;
            this.yearNum.ValueChanged += new System.EventHandler(this.surnameTB_TextChanged);
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(12, 193);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(90, 18);
            this.yearLabel.TabIndex = 35;
            this.yearLabel.Text = "Год обучения:";
            // 
            // parTB
            // 
            this.parTB.Location = new System.Drawing.Point(104, 74);
            this.parTB.Name = "parTB";
            this.parTB.Size = new System.Drawing.Size(329, 23);
            this.parTB.TabIndex = 34;
            this.parTB.TextChanged += new System.EventHandler(this.surnameTB_TextChanged);
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(104, 45);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(329, 23);
            this.nameTB.TabIndex = 33;
            this.nameTB.TextChanged += new System.EventHandler(this.surnameTB_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Имя:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentRB);
            this.groupBox1.Controls.Add(this.tutorRB);
            this.groupBox1.Location = new System.Drawing.Point(17, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 87);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид персоны";
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
            // groupTB
            // 
            this.groupTB.Location = new System.Drawing.Point(104, 132);
            this.groupTB.Name = "groupTB";
            this.groupTB.Size = new System.Drawing.Size(329, 23);
            this.groupTB.TabIndex = 27;
            this.groupTB.TextChanged += new System.EventHandler(this.surnameTB_TextChanged);
            // 
            // surnameTB
            // 
            this.surnameTB.Location = new System.Drawing.Point(104, 16);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(329, 23);
            this.surnameTB.TabIndex = 25;
            this.surnameTB.TextChanged += new System.EventHandler(this.surnameTB_TextChanged);
            // 
            // groupLabel
            // 
            this.groupLabel.Location = new System.Drawing.Point(12, 135);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(90, 18);
            this.groupLabel.TabIndex = 24;
            this.groupLabel.Text = "Группа: ";
            // 
            // progCafTB
            // 
            this.progCafTB.Location = new System.Drawing.Point(104, 103);
            this.progCafTB.Name = "progCafTB";
            this.progCafTB.Size = new System.Drawing.Size(329, 23);
            this.progCafTB.TabIndex = 26;
            this.progCafTB.TextChanged += new System.EventHandler(this.surnameTB_TextChanged);
            // 
            // progCafLabel
            // 
            this.progCafLabel.Location = new System.Drawing.Point(12, 108);
            this.progCafLabel.Name = "progCafLabel";
            this.progCafLabel.Size = new System.Drawing.Size(90, 18);
            this.progCafLabel.TabIndex = 23;
            this.progCafLabel.Text = "Направление: ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Фамилия: ";
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(318, 254);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 23);
            this.addButton.TabIndex = 42;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // debtsProgsTB
            // 
            this.debtsProgsTB.Location = new System.Drawing.Point(104, 162);
            this.debtsProgsTB.Name = "debtsProgsTB";
            this.debtsProgsTB.Size = new System.Drawing.Size(329, 23);
            this.debtsProgsTB.TabIndex = 45;
            this.debtsProgsTB.TextChanged += new System.EventHandler(this.surnameTB_TextChanged);
            // 
            // debtsProgsLabel
            // 
            this.debtsProgsLabel.Location = new System.Drawing.Point(12, 164);
            this.debtsProgsLabel.Name = "debtsProgsLabel";
            this.debtsProgsLabel.Size = new System.Drawing.Size(90, 18);
            this.debtsProgsLabel.TabIndex = 44;
            this.debtsProgsLabel.Text = "Долги:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File | *.txt";
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 330);
            this.Controls.Add(this.debtsProgsTB);
            this.Controls.Add(this.debtsProgsLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.yearNum);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.parTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupTB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.progCafTB);
            this.Controls.Add(this.progCafLabel);
            this.Controls.Add(this.label1);
            this.Name = "AddPerson";
            this.Text = "AddPerson";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPerson_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.yearNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label progCafLabel;
        private System.Windows.Forms.TextBox progCafTB;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.TextBox groupTB;
        private System.Windows.Forms.RadioButton tutorRB;
        private System.Windows.Forms.RadioButton studentRB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox parTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.Label debtsProgsLabel;
        private System.Windows.Forms.TextBox debtsProgsTB;
        private System.Windows.Forms.NumericUpDown yearNum;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}