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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.yearLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.progCafTB = new System.Windows.Forms.TextBox();
            this.progCafLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(42, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(104, 156);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(63, 23);
            this.numericUpDown1.TabIndex = 36;
            // 
            // yearLabel
            // 
            this.yearLabel.Location = new System.Drawing.Point(12, 159);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(90, 18);
            this.yearLabel.TabIndex = 35;
            this.yearLabel.Text = "Год обучения:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(329, 23);
            this.textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(329, 23);
            this.textBox2.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Имя:";
            // 
            // groupTB
            // 
            this.groupTB.Location = new System.Drawing.Point(104, 127);
            this.groupTB.Name = "groupTB";
            this.groupTB.ReadOnly = true;
            this.groupTB.Size = new System.Drawing.Size(329, 23);
            this.groupTB.TabIndex = 27;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(104, 12);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(329, 23);
            this.nameTB.TabIndex = 25;
            // 
            // groupLabel
            // 
            this.groupLabel.Location = new System.Drawing.Point(12, 130);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(90, 18);
            this.groupLabel.TabIndex = 24;
            this.groupLabel.Text = "Группа: ";
            // 
            // progCafTB
            // 
            this.progCafTB.Location = new System.Drawing.Point(104, 98);
            this.progCafTB.Name = "progCafTB";
            this.progCafTB.ReadOnly = true;
            this.progCafTB.Size = new System.Drawing.Size(329, 23);
            this.progCafTB.TabIndex = 26;
            // 
            // progCafLabel
            // 
            this.progCafLabel.Location = new System.Drawing.Point(12, 103);
            this.progCafLabel.Name = "progCafLabel";
            this.progCafLabel.Size = new System.Drawing.Size(90, 18);
            this.progCafLabel.TabIndex = 23;
            this.progCafLabel.Text = "Направление: ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Фамилия: ";
            // 
            // UpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 255);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.progCafTB);
            this.Controls.Add(this.progCafLabel);
            this.Controls.Add(this.label1);
            this.Name = "UpdatePerson";
            this.Text = "UpdatePerson";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdatePerson_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label progCafLabel;
        private System.Windows.Forms.TextBox progCafTB;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox groupTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}