namespace Figures
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
            this.amountNumeric = new System.Windows.Forms.NumericUpDown();
            this.createButton = new System.Windows.Forms.Button();
            this.methodsCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paramsCB = new System.Windows.Forms.ComboBox();
            this.chagneButton = new System.Windows.Forms.Button();
            this.figsTB = new System.Windows.Forms.RichTextBox();
            this.equalTB = new System.Windows.Forms.RichTextBox();
            this.crossTB = new System.Windows.Forms.RichTextBox();
            this.figuresLabels = new System.Windows.Forms.Label();
            this.Equal = new System.Windows.Forms.Label();
            this.crossLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paramNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize) (this.amountNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.paramNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // amountNumeric
            // 
            this.amountNumeric.Location = new System.Drawing.Point(13, 10);
            this.amountNumeric.Name = "amountNumeric";
            this.amountNumeric.Size = new System.Drawing.Size(133, 20);
            this.amountNumeric.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(13, 35);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(133, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Создать";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // methodsCB
            // 
            this.methodsCB.FormattingEnabled = true;
            this.methodsCB.Items.AddRange(new object[] {"A=", "R=", "S=", "MoveTo()", "MoveRel()"});
            this.methodsCB.Location = new System.Drawing.Point(13, 118);
            this.methodsCB.Name = "methodsCB";
            this.methodsCB.Size = new System.Drawing.Size(131, 21);
            this.methodsCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Метод";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Параметры";
            // 
            // paramsCB
            // 
            this.paramsCB.FormattingEnabled = true;
            this.paramsCB.Items.AddRange(new object[] {"Случайный", "Одинаковый"});
            this.paramsCB.Location = new System.Drawing.Point(13, 185);
            this.paramsCB.Name = "paramsCB";
            this.paramsCB.Size = new System.Drawing.Size(131, 21);
            this.paramsCB.TabIndex = 4;
            this.paramsCB.SelectedIndexChanged += new System.EventHandler(this.paramsCB_SelectedIndexChanged);
            // 
            // chagneButton
            // 
            this.chagneButton.Location = new System.Drawing.Point(20, 244);
            this.chagneButton.Name = "chagneButton";
            this.chagneButton.Size = new System.Drawing.Size(122, 21);
            this.chagneButton.TabIndex = 6;
            this.chagneButton.Text = "Изменить";
            this.chagneButton.UseVisualStyleBackColor = true;
            this.chagneButton.Click += new System.EventHandler(this.chagneButton_Click);
            // 
            // figsTB
            // 
            this.figsTB.Location = new System.Drawing.Point(549, 34);
            this.figsTB.Name = "figsTB";
            this.figsTB.ReadOnly = true;
            this.figsTB.Size = new System.Drawing.Size(234, 92);
            this.figsTB.TabIndex = 7;
            this.figsTB.Text = "";
            // 
            // equalTB
            // 
            this.equalTB.Location = new System.Drawing.Point(549, 149);
            this.equalTB.Name = "equalTB";
            this.equalTB.ReadOnly = true;
            this.equalTB.Size = new System.Drawing.Size(234, 92);
            this.equalTB.TabIndex = 8;
            this.equalTB.Text = "";
            // 
            // crossTB
            // 
            this.crossTB.Location = new System.Drawing.Point(549, 262);
            this.crossTB.Name = "crossTB";
            this.crossTB.ReadOnly = true;
            this.crossTB.Size = new System.Drawing.Size(234, 92);
            this.crossTB.TabIndex = 9;
            this.crossTB.Text = "";
            // 
            // figuresLabels
            // 
            this.figuresLabels.Location = new System.Drawing.Point(549, 12);
            this.figuresLabels.Name = "figuresLabels";
            this.figuresLabels.Size = new System.Drawing.Size(168, 19);
            this.figuresLabels.TabIndex = 10;
            this.figuresLabels.Text = "Фигуры";
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(549, 128);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(176, 20);
            this.Equal.TabIndex = 11;
            this.Equal.Text = "Equal";
            // 
            // crossLabel
            // 
            this.crossLabel.Location = new System.Drawing.Point(549, 240);
            this.crossLabel.Name = "crossLabel";
            this.crossLabel.Size = new System.Drawing.Size(176, 20);
            this.crossLabel.TabIndex = 12;
            this.crossLabel.Text = "Cross";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.Location = new System.Drawing.Point(159, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 347);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // paramNumber
            // 
            this.paramNumber.Location = new System.Drawing.Point(13, 210);
            this.paramNumber.Name = "paramNumber";
            this.paramNumber.Size = new System.Drawing.Size(131, 20);
            this.paramNumber.TabIndex = 14;
            this.paramNumber.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(792, 374);
            this.Controls.Add(this.paramNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crossLabel);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.figuresLabels);
            this.Controls.Add(this.crossTB);
            this.Controls.Add(this.equalTB);
            this.Controls.Add(this.figsTB);
            this.Controls.Add(this.chagneButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paramsCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.methodsCB);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.amountNumeric);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximumSize = new System.Drawing.Size(808, 413);
            this.MinimumSize = new System.Drawing.Size(808, 413);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.amountNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.paramNumber)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown amountNumeric;
        private System.Windows.Forms.Button chagneButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label crossLabel;
        private System.Windows.Forms.RichTextBox crossTB;
        private System.Windows.Forms.Label Equal;
        private System.Windows.Forms.RichTextBox equalTB;
        private System.Windows.Forms.RichTextBox figsTB;
        private System.Windows.Forms.Label figuresLabels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox methodsCB;
        private System.Windows.Forms.NumericUpDown paramNumber;
        private System.Windows.Forms.ComboBox paramsCB;
        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}