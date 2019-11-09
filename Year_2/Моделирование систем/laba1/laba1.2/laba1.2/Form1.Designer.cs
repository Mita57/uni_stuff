namespace laba1._2
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
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.averageTime = new System.Windows.Forms.TextBox();
            this.streamDensity = new System.Windows.Forms.TextBox();
            this.storageVolume = new System.Windows.Forms.TextBox();
            this.lotsAmount = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eightHoursShit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.avgBusyPed = new System.Windows.Forms.TextBox();
            this.avgBusyLots = new System.Windows.Forms.TextBox();
            this.carsWaiting = new System.Windows.Forms.TextBox();
            this.deniedComplelely = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во мест";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кол-во мест на дорожках";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Плотность потока";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Среднее время на стоянке";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.averageTime);
            this.groupBox1.Controls.Add(this.streamDensity);
            this.groupBox1.Controls.Add(this.storageVolume);
            this.groupBox1.Controls.Add(this.lotsAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // averageTime
            // 
            this.averageTime.Location = new System.Drawing.Point(200, 100);
            this.averageTime.Name = "averageTime";
            this.averageTime.Size = new System.Drawing.Size(184, 20);
            this.averageTime.TabIndex = 7;
            // 
            // streamDensity
            // 
            this.streamDensity.Location = new System.Drawing.Point(200, 74);
            this.streamDensity.Name = "streamDensity";
            this.streamDensity.Size = new System.Drawing.Size(184, 20);
            this.streamDensity.TabIndex = 6;
            // 
            // storageVolume
            // 
            this.storageVolume.Location = new System.Drawing.Point(200, 47);
            this.storageVolume.Name = "storageVolume";
            this.storageVolume.Size = new System.Drawing.Size(184, 20);
            this.storageVolume.TabIndex = 5;
            // 
            // lotsAmount
            // 
            this.lotsAmount.Location = new System.Drawing.Point(200, 18);
            this.lotsAmount.Name = "lotsAmount";
            this.lotsAmount.Size = new System.Drawing.Size(184, 20);
            this.lotsAmount.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eightHoursShit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.avgBusyPed);
            this.groupBox2.Controls.Add(this.avgBusyLots);
            this.groupBox2.Controls.Add(this.carsWaiting);
            this.groupBox2.Controls.Add(this.deniedComplelely);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 171);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outputs";
            // 
            // eightHoursShit
            // 
            this.eightHoursShit.Location = new System.Drawing.Point(200, 130);
            this.eightHoursShit.Name = "eightHoursShit";
            this.eightHoursShit.ReadOnly = true;
            this.eightHoursShit.Size = new System.Drawing.Size(184, 20);
            this.eightHoursShit.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(331, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Среднее число посетителей, не нашедших место через 8 часов ";
            // 
            // avgBusyPed
            // 
            this.avgBusyPed.Location = new System.Drawing.Point(200, 81);
            this.avgBusyPed.Name = "avgBusyPed";
            this.avgBusyPed.ReadOnly = true;
            this.avgBusyPed.Size = new System.Drawing.Size(184, 20);
            this.avgBusyPed.TabIndex = 7;
            // 
            // avgBusyLots
            // 
            this.avgBusyLots.Location = new System.Drawing.Point(200, 104);
            this.avgBusyLots.Name = "avgBusyLots";
            this.avgBusyLots.ReadOnly = true;
            this.avgBusyLots.Size = new System.Drawing.Size(184, 20);
            this.avgBusyLots.TabIndex = 6;
            // 
            // carsWaiting
            // 
            this.carsWaiting.Location = new System.Drawing.Point(200, 51);
            this.carsWaiting.Name = "carsWaiting";
            this.carsWaiting.ReadOnly = true;
            this.carsWaiting.Size = new System.Drawing.Size(184, 20);
            this.carsWaiting.TabIndex = 5;
            // 
            // deniedComplelely
            // 
            this.deniedComplelely.Location = new System.Drawing.Point(200, 22);
            this.deniedComplelely.Name = "deniedComplelely";
            this.deniedComplelely.ReadOnly = true;
            this.deniedComplelely.Size = new System.Drawing.Size(184, 20);
            this.deniedComplelely.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ср. число занятых мест на дорожках";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ср число занятых мест на парковке";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ожидают на дорожке";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ищут другое место для парковки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "СМО 2.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox averageTime;
        private System.Windows.Forms.TextBox streamDensity;
        private System.Windows.Forms.TextBox storageVolume;
        private System.Windows.Forms.TextBox lotsAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox avgBusyPed;
        private System.Windows.Forms.TextBox avgBusyLots;
        private System.Windows.Forms.TextBox carsWaiting;
        private System.Windows.Forms.TextBox deniedComplelely;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox eightHoursShit;
        private System.Windows.Forms.Label label9;
    }
}

