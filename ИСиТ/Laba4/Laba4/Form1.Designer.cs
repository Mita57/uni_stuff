namespace Laba4
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
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.power = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amval = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amval)).BeginInit();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AllowUserToDeleteRows = false;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.P});
            this.grid1.Location = new System.Drawing.Point(30, 9);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(304, 438);
            this.grid1.TabIndex = 0;
            this.grid1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellEndEdit);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MaxInputLength = 1;
            this.X.Name = "X";
            this.X.Width = 130;
            // 
            // P
            // 
            this.P.HeaderText = "P";
            this.P.Name = "P";
            this.P.Width = 130;
            // 
            // grid2
            // 
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comb,
            this.prob});
            this.grid2.Location = new System.Drawing.Point(404, 9);
            this.grid2.Name = "grid2";
            this.grid2.ReadOnly = true;
            this.grid2.Size = new System.Drawing.Size(303, 438);
            this.grid2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количетво символов в слове";
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(176, 506);
            this.power.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(158, 20);
            this.power.TabIndex = 3;
            this.power.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(399, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 506);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(307, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comb
            // 
            this.comb.HeaderText = "Комбинация";
            this.comb.Name = "comb";
            this.comb.ReadOnly = true;
            this.comb.Width = 130;
            // 
            // prob
            // 
            this.prob.HeaderText = "Вероятность";
            this.prob.Name = "prob";
            this.prob.ReadOnly = true;
            this.prob.Width = 130;
            // 
            // amval
            // 
            this.amval.Location = new System.Drawing.Point(176, 468);
            this.amval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amval.Name = "amval";
            this.amval.Size = new System.Drawing.Size(158, 20);
            this.amval.TabIndex = 7;
            this.amval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amval.ValueChanged += new System.EventHandler(this.amval_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Количество символов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 556);
            this.Controls.Add(this.amval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.power);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.grid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.DataGridView grid2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown power;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn P;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn comb;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob;
        private System.Windows.Forms.NumericUpDown amval;
        private System.Windows.Forms.Label label2;
    }
}

