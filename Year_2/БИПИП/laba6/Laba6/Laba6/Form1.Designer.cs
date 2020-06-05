namespace Laba6
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
            this.threadsAmountNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.amountNum = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.threadsAmountNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.amountNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число потоков";
            // 
            // threadsAmountNum
            // 
            this.threadsAmountNum.Location = new System.Drawing.Point(105, 16);
            this.threadsAmountNum.Name = "threadsAmountNum";
            this.threadsAmountNum.Size = new System.Drawing.Size(50, 20);
            this.threadsAmountNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(207, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "N";
            // 
            // amountNum
            // 
            this.amountNum.Location = new System.Drawing.Point(233, 16);
            this.amountNum.Maximum = new decimal(new int[] {276447231, 23283, 0, 0});
            this.amountNum.Name = "amountNum";
            this.amountNum.Size = new System.Drawing.Size(70, 20);
            this.amountNum.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Выполнятор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(432, 405);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.amountNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.threadsAmountNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ASYNC";
            ((System.ComponentModel.ISupportInitialize) (this.threadsAmountNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.amountNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.NumericUpDown amountNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown threadsAmountNum;

        #endregion
    }
}