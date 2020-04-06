using System.ComponentModel;

namespace MDI
{
    partial class Auxillary
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.sizeTB = new System.Windows.Forms.TextBox();
            this.MDICoordsTB = new System.Windows.Forms.TextBox();
            this.scrSizeTB = new System.Windows.Forms.TextBox();
            this.stringsTB = new System.Windows.Forms.TextBox();
            this.fileTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(471, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя формы";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Размеры формы";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Коорд в экр";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Коорд в обр";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Кол-во строк";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Имя файла";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(117, 38);
            this.nameTB.Name = "nameTB";
            this.nameTB.ReadOnly = true;
            this.nameTB.Size = new System.Drawing.Size(362, 23);
            this.nameTB.TabIndex = 7;
            // 
            // sizeTB
            // 
            this.sizeTB.Location = new System.Drawing.Point(117, 67);
            this.sizeTB.Name = "sizeTB";
            this.sizeTB.ReadOnly = true;
            this.sizeTB.Size = new System.Drawing.Size(362, 23);
            this.sizeTB.TabIndex = 8;
            // 
            // MDICoordsTB
            // 
            this.MDICoordsTB.Location = new System.Drawing.Point(117, 96);
            this.MDICoordsTB.Name = "MDICoordsTB";
            this.MDICoordsTB.ReadOnly = true;
            this.MDICoordsTB.Size = new System.Drawing.Size(362, 23);
            this.MDICoordsTB.TabIndex = 9;
            // 
            // scrSizeTB
            // 
            this.scrSizeTB.Location = new System.Drawing.Point(117, 125);
            this.scrSizeTB.Name = "scrSizeTB";
            this.scrSizeTB.ReadOnly = true;
            this.scrSizeTB.Size = new System.Drawing.Size(362, 23);
            this.scrSizeTB.TabIndex = 10;
            // 
            // stringsTB
            // 
            this.stringsTB.Location = new System.Drawing.Point(117, 183);
            this.stringsTB.Name = "stringsTB";
            this.stringsTB.ReadOnly = true;
            this.stringsTB.Size = new System.Drawing.Size(362, 23);
            this.stringsTB.TabIndex = 12;
            // 
            // fileTB
            // 
            this.fileTB.Location = new System.Drawing.Point(117, 153);
            this.fileTB.Name = "fileTB";
            this.fileTB.ReadOnly = true;
            this.fileTB.Size = new System.Drawing.Size(362, 23);
            this.fileTB.TabIndex = 11;
            // 
            // Auxillary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.stringsTB);
            this.Controls.Add(this.fileTB);
            this.Controls.Add(this.scrSizeTB);
            this.Controls.Add(this.MDICoordsTB);
            this.Controls.Add(this.sizeTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Auxillary";
            this.Text = "Auxillary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Auxillary_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileTB;
        private System.Windows.Forms.TextBox stringsTB;
        private System.Windows.Forms.TextBox scrSizeTB;
        private System.Windows.Forms.TextBox sizeTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox MDICoordsTB;
    }
}