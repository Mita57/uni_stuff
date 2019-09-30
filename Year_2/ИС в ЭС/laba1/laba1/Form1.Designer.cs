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
            this.amountUpDown = new System.Windows.Forms.NumericUpDown();
            this.inputDGW = new System.Windows.Forms.DataGridView();
            this.autoDGW = new System.Windows.Forms.DataGridView();
            this.manDGW = new System.Windows.Forms.DataGridView();
            this.critIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executeButton = new System.Windows.Forms.Button();
            this.renderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manDGW)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во показаелей";
            // 
            // amountUpDown
            // 
            this.amountUpDown.Location = new System.Drawing.Point(122, 7);
            this.amountUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountUpDown.Name = "amountUpDown";
            this.amountUpDown.Size = new System.Drawing.Size(120, 20);
            this.amountUpDown.TabIndex = 1;
            this.amountUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inputDGW
            // 
            this.inputDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputDGW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.critIndex,
            this.criName});
            this.inputDGW.Location = new System.Drawing.Point(12, 30);
            this.inputDGW.Name = "inputDGW";
            this.inputDGW.RowHeadersVisible = false;
            this.inputDGW.Size = new System.Drawing.Size(379, 437);
            this.inputDGW.TabIndex = 2;
            // 
            // autoDGW
            // 
            this.autoDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autoDGW.Location = new System.Drawing.Point(421, 16);
            this.autoDGW.Name = "autoDGW";
            this.autoDGW.Size = new System.Drawing.Size(426, 236);
            this.autoDGW.TabIndex = 3;
            // 
            // manDGW
            // 
            this.manDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manDGW.Location = new System.Drawing.Point(421, 261);
            this.manDGW.Name = "manDGW";
            this.manDGW.Size = new System.Drawing.Size(426, 236);
            this.manDGW.TabIndex = 4;
            // 
            // critIndex
            // 
            this.critIndex.HeaderText = " ";
            this.critIndex.Name = "critIndex";
            this.critIndex.Width = 20;
            // 
            // criName
            // 
            this.criName.HeaderText = "Показатель";
            this.criName.Name = "criName";
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(151, 474);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 5;
            this.executeButton.Text = "Вычислить";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // renderButton
            // 
            this.renderButton.Location = new System.Drawing.Point(259, 4);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(75, 23);
            this.renderButton.TabIndex = 6;
            this.renderButton.Text = "Render";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 505);
            this.Controls.Add(this.renderButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.manDGW);
            this.Controls.Add(this.autoDGW);
            this.Controls.Add(this.inputDGW);
            this.Controls.Add(this.amountUpDown);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manDGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown amountUpDown;
        private System.Windows.Forms.DataGridView inputDGW;
        private System.Windows.Forms.DataGridView autoDGW;
        private System.Windows.Forms.DataGridView manDGW;
        private System.Windows.Forms.DataGridViewTextBoxColumn critIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn criName;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button renderButton;
    }
}

