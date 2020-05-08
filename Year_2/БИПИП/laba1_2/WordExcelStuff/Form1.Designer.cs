namespace WordExcelStuff
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
            this.trapeezeRB = new System.Windows.Forms.RadioButton();
            this.rectangleRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iterationsAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.resultField = new System.Windows.Forms.TextBox();
            this.timeEscalatedField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.executeButton = new System.Windows.Forms.Button();
            this.accuracyTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.iterationsAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trapeezeRB);
            this.groupBox1.Controls.Add(this.rectangleRB);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор метода";
            // 
            // trapeezeRB
            // 
            this.trapeezeRB.AutoSize = true;
            this.trapeezeRB.Location = new System.Drawing.Point(7, 43);
            this.trapeezeRB.Name = "trapeezeRB";
            this.trapeezeRB.Size = new System.Drawing.Size(107, 17);
            this.trapeezeRB.TabIndex = 1;
            this.trapeezeRB.TabStop = true;
            this.trapeezeRB.Text = "Метод трапеций";
            this.trapeezeRB.UseVisualStyleBackColor = true;
            // 
            // rectangleRB
            // 
            this.rectangleRB.AutoSize = true;
            this.rectangleRB.Checked = true;
            this.rectangleRB.Location = new System.Drawing.Point(7, 20);
            this.rectangleRB.Name = "rectangleRB";
            this.rectangleRB.Size = new System.Drawing.Size(150, 17);
            this.rectangleRB.TabIndex = 0;
            this.rectangleRB.TabStop = true;
            this.rectangleRB.Text = "Метод прямоугольников";
            this.rectangleRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество итераций";
            // 
            // iterationsAmount
            // 
            this.iterationsAmount.Location = new System.Drawing.Point(135, 80);
            this.iterationsAmount.Maximum = new decimal(new int[] {100007000, 0, 0, 0});
            this.iterationsAmount.Minimum = new decimal(new int[] {2, 0, 0, 0});
            this.iterationsAmount.Name = "iterationsAmount";
            this.iterationsAmount.Size = new System.Drawing.Size(110, 20);
            this.iterationsAmount.TabIndex = 2;
            this.iterationsAmount.Value = new decimal(new int[] {2, 0, 0, 0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Результат вычислений";
            // 
            // resultField
            // 
            this.resultField.Location = new System.Drawing.Point(135, 114);
            this.resultField.Name = "resultField";
            this.resultField.ReadOnly = true;
            this.resultField.Size = new System.Drawing.Size(110, 20);
            this.resultField.TabIndex = 4;
            // 
            // timeEscalatedField
            // 
            this.timeEscalatedField.Location = new System.Drawing.Point(135, 140);
            this.timeEscalatedField.Name = "timeEscalatedField";
            this.timeEscalatedField.ReadOnly = true;
            this.timeEscalatedField.Size = new System.Drawing.Size(110, 20);
            this.timeEscalatedField.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Потрачено времени";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(79, 208);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(84, 23);
            this.executeButton.TabIndex = 8;
            this.executeButton.Text = "Выполнятор";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // accuracyTextbox
            // 
            this.accuracyTextbox.Location = new System.Drawing.Point(135, 166);
            this.accuracyTextbox.Name = "accuracyTextbox";
            this.accuracyTextbox.ReadOnly = true;
            this.accuracyTextbox.Size = new System.Drawing.Size(110, 20);
            this.accuracyTextbox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Точность";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 243);
            this.Controls.Add(this.accuracyTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.timeEscalatedField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iterationsAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.iterationsAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox accuracyTextbox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown iterationsAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rectangleRB;
        private System.Windows.Forms.TextBox resultField;
        private System.Windows.Forms.TextBox timeEscalatedField;
        private System.Windows.Forms.RadioButton trapeezeRB;

        #endregion
    }
}

