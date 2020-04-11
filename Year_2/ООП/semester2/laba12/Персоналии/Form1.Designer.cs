namespace Персоналии
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.progCafTB = new System.Windows.Forms.TextBox();
            this.groupTB = new System.Windows.Forms.TextBox();
            this.studentRB = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя: ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Направление: ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Группа: ";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(100, 10);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(329, 23);
            this.nameTB.TabIndex = 3;
            // 
            // progCafTB
            // 
            this.progCafTB.Location = new System.Drawing.Point(100, 43);
            this.progCafTB.Name = "progCafTB";
            this.progCafTB.Size = new System.Drawing.Size(329, 23);
            this.progCafTB.TabIndex = 4;
            // 
            // groupTB
            // 
            this.groupTB.Location = new System.Drawing.Point(100, 77);
            this.groupTB.Name = "groupTB";
            this.groupTB.Size = new System.Drawing.Size(329, 23);
            this.groupTB.TabIndex = 5;
            // 
            // studentRB
            // 
            this.studentRB.Location = new System.Drawing.Point(6, 22);
            this.studentRB.Name = "studentRB";
            this.studentRB.Size = new System.Drawing.Size(114, 28);
            this.studentRB.TabIndex = 6;
            this.studentRB.TabStop = true;
            this.studentRB.Text = "Студент";
            this.studentRB.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(6, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(114, 28);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Преподаватель";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentRB);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вид персоны";
            // 
            // Персоналии
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 224);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupTB);
            this.Controls.Add(this.progCafTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Персоналии";
            this.Text = "Персоналии";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox groupTB;
        private System.Windows.Forms.TextBox progCafTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton studentRB;
    }
}