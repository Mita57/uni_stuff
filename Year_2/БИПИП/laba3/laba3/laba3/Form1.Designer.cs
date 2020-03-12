namespace laba3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rectangleRB = new System.Windows.Forms.RadioButton();
            this.trapeezeRB = new System.Windows.Forms.RadioButton();
            this.execButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iterationsAmount = new System.Windows.Forms.NumericUpDown();
            this.threadsAmount = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.iterationsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.threadsAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trapeezeRB);
            this.groupBox1.Controls.Add(this.rectangleRB);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Метод";
            // 
            // rectangleRB
            // 
            this.rectangleRB.Checked = true;
            this.rectangleRB.Location = new System.Drawing.Point(13, 20);
            this.rectangleRB.Name = "rectangleRB";
            this.rectangleRB.Size = new System.Drawing.Size(187, 24);
            this.rectangleRB.TabIndex = 0;
            this.rectangleRB.TabStop = true;
            this.rectangleRB.Text = "Прямоугольник";
            this.rectangleRB.UseVisualStyleBackColor = true;
            // 
            // trapeezeRB
            // 
            this.trapeezeRB.Location = new System.Drawing.Point(13, 50);
            this.trapeezeRB.Name = "trapeezeRB";
            this.trapeezeRB.Size = new System.Drawing.Size(187, 24);
            this.trapeezeRB.TabIndex = 1;
            this.trapeezeRB.Text = "Трапеция";
            this.trapeezeRB.UseVisualStyleBackColor = true;
            // 
            // execButton
            // 
            this.execButton.Location = new System.Drawing.Point(52, 192);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(130, 31);
            this.execButton.TabIndex = 1;
            this.execButton.Text = "Выполнятор";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Число разбиений";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Число потоков";
            // 
            // iterationsAmount
            // 
            this.iterationsAmount.Location = new System.Drawing.Point(126, 110);
            this.iterationsAmount.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.iterationsAmount.Minimum = new decimal(new int[] {5, 0, 0, 0});
            this.iterationsAmount.Name = "iterationsAmount";
            this.iterationsAmount.Size = new System.Drawing.Size(99, 23);
            this.iterationsAmount.TabIndex = 4;
            this.iterationsAmount.Value = new decimal(new int[] {5, 0, 0, 0});
            // 
            // threadsAmount
            // 
            this.threadsAmount.Location = new System.Drawing.Point(126, 137);
            this.threadsAmount.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.threadsAmount.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.threadsAmount.Name = "threadsAmount";
            this.threadsAmount.Size = new System.Drawing.Size(99, 23);
            this.threadsAmount.TabIndex = 5;
            this.threadsAmount.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(237, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(331, 241);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Laba3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 264);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.threadsAmount);
            this.Controls.Add(this.iterationsAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Laba3";
            this.Text = "Laba3";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.iterationsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.threadsAmount)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown threadsAmount;
        private System.Windows.Forms.NumericUpDown iterationsAmount;
        private System.Windows.Forms.RadioButton rectangleRB;
        private System.Windows.Forms.RadioButton trapeezeRB;
    }
}