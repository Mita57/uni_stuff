namespace laba1
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
            this.operatorsAmount = new System.Windows.Forms.TextBox();
            this.streamDensity = new System.Windows.Forms.TextBox();
            this.averageTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGW = new System.Windows.Forms.DataGridView();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.QProbability = new System.Windows.Forms.TextBox();
            this.avgQLength = new System.Windows.Forms.TextBox();
            this.avgQTime = new System.Windows.Forms.TextBox();
            this.avgBusyOps = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.opsRequired = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.probs2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество операторов(n)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Плотность потока(λ)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Мат. ожидание времени(τ0)";
            // 
            // operatorsAmount
            // 
            this.operatorsAmount.Location = new System.Drawing.Point(165, 31);
            this.operatorsAmount.Name = "operatorsAmount";
            this.operatorsAmount.Size = new System.Drawing.Size(117, 20);
            this.operatorsAmount.TabIndex = 3;
            // 
            // streamDensity
            // 
            this.streamDensity.Location = new System.Drawing.Point(165, 54);
            this.streamDensity.Name = "streamDensity";
            this.streamDensity.Size = new System.Drawing.Size(117, 20);
            this.streamDensity.TabIndex = 4;
            // 
            // averageTime
            // 
            this.averageTime.Location = new System.Drawing.Point(165, 80);
            this.averageTime.Name = "averageTime";
            this.averageTime.Size = new System.Drawing.Size(117, 20);
            this.averageTime.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.averageTime);
            this.groupBox1.Controls.Add(this.streamDensity);
            this.groupBox1.Controls.Add(this.operatorsAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 190);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // DGW
            // 
            this.DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amount,
            this.probability});
            this.DGW.Location = new System.Drawing.Point(312, 10);
            this.DGW.Name = "DGW";
            this.DGW.Size = new System.Drawing.Size(519, 474);
            this.DGW.TabIndex = 7;
            // 
            // amount
            // 
            this.amount.HeaderText = "n Операторов";
            this.amount.Name = "amount";
            // 
            // probability
            // 
            this.probability.HeaderText = "Вероятность";
            this.probability.Name = "probability";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вероятность очереди";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Средняя длина очереди";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ср. время ожидания в очереди";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ср. число занятых операторов";
            // 
            // QProbability
            // 
            this.QProbability.Location = new System.Drawing.Point(179, 22);
            this.QProbability.Name = "QProbability";
            this.QProbability.ReadOnly = true;
            this.QProbability.Size = new System.Drawing.Size(100, 20);
            this.QProbability.TabIndex = 12;
            // 
            // avgQLength
            // 
            this.avgQLength.Location = new System.Drawing.Point(179, 48);
            this.avgQLength.Name = "avgQLength";
            this.avgQLength.ReadOnly = true;
            this.avgQLength.Size = new System.Drawing.Size(100, 20);
            this.avgQLength.TabIndex = 13;
            // 
            // avgQTime
            // 
            this.avgQTime.Location = new System.Drawing.Point(179, 73);
            this.avgQTime.Name = "avgQTime";
            this.avgQTime.ReadOnly = true;
            this.avgQTime.Size = new System.Drawing.Size(100, 20);
            this.avgQTime.TabIndex = 14;
            // 
            // avgBusyOps
            // 
            this.avgBusyOps.Location = new System.Drawing.Point(179, 96);
            this.avgBusyOps.Name = "avgBusyOps";
            this.avgBusyOps.ReadOnly = true;
            this.avgBusyOps.Size = new System.Drawing.Size(100, 20);
            this.avgBusyOps.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.probs2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.opsRequired);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.avgBusyOps);
            this.groupBox2.Controls.Add(this.avgQTime);
            this.groupBox2.Controls.Add(this.avgQLength);
            this.groupBox2.Controls.Add(this.QProbability);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 184);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Outputs";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Макс. ожидание (τmax)";
            // 
            // opsRequired
            // 
            this.opsRequired.Location = new System.Drawing.Point(179, 122);
            this.opsRequired.Name = "opsRequired";
            this.opsRequired.ReadOnly = true;
            this.opsRequired.Size = new System.Drawing.Size(100, 20);
            this.opsRequired.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Необходимое кол-во операторов";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Посчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // probs2
            // 
            this.probs2.Location = new System.Drawing.Point(179, 148);
            this.probs2.Name = "probs2";
            this.probs2.ReadOnly = true;
            this.probs2.Size = new System.Drawing.Size(100, 20);
            this.probs2.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Вероятность 1+ своб. операторов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DGW);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Системы массового обслуживания";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGW)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox operatorsAmount;
        private System.Windows.Forms.TextBox streamDensity;
        private System.Windows.Forms.TextBox averageTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox QProbability;
        private System.Windows.Forms.TextBox avgQLength;
        private System.Windows.Forms.TextBox avgQTime;
        private System.Windows.Forms.TextBox avgBusyOps;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn probability;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox opsRequired;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox probs2;
        private System.Windows.Forms.Label label10;
    }
}

