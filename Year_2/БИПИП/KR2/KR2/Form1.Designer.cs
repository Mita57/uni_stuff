namespace KR2
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
            this.partsNum = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.threadsNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.partsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.threadsNum)).BeginInit();
            this.SuspendLayout();
            // 
            // partsNum
            // 
            this.partsNum.Location = new System.Drawing.Point(12, 40);
            this.partsNum.Maximum = new decimal(new int[] {276447231, 23283, 0, 0});
            this.partsNum.Name = "partsNum";
            this.partsNum.Size = new System.Drawing.Size(120, 20);
            this.partsNum.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выполнятор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // threadsNum
            // 
            this.threadsNum.Location = new System.Drawing.Point(149, 40);
            this.threadsNum.Name = "threadsNum";
            this.threadsNum.Size = new System.Drawing.Size(120, 20);
            this.threadsNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Разбиения";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Потоки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 71);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.threadsNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.partsNum);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.partsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.threadsNum)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown partsNum;
        private System.Windows.Forms.NumericUpDown threadsNum;

        #endregion
    }
}