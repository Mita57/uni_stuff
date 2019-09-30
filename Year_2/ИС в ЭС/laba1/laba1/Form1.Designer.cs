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
            this.DGW1 = new System.Windows.Forms.DataGridView();
            this.critIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.criName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executeButton = new System.Windows.Forms.Button();
            this.renderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IBZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGW2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во показателей";
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
            // DGW1
            // 
            this.DGW1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.score,
            this.IBZ,
            this.finalScore});
            this.DGW1.Location = new System.Drawing.Point(421, 30);
            this.DGW1.Name = "DGW1";
            this.DGW1.Size = new System.Drawing.Size(426, 199);
            this.DGW1.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Баллы 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Баллы 1";
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            // 
            // score
            // 
            this.score.HeaderText = "Баллы";
            this.score.Name = "score";
            // 
            // IBZ
            // 
            this.IBZ.HeaderText = "Индекс балло-значимости";
            this.IBZ.Name = "IBZ";
            // 
            // finalScore
            // 
            this.finalScore.HeaderText = "Взвешенный бал";
            this.finalScore.Name = "finalScore";
            // 
            // DGW2
            // 
            this.DGW2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGW2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DGW2.Location = new System.Drawing.Point(421, 268);
            this.DGW2.Name = "DGW2";
            this.DGW2.Size = new System.Drawing.Size(426, 199);
            this.DGW2.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Баллы";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Индекс балло-значимости";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Взвешенный бал";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 505);
            this.Controls.Add(this.DGW2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.renderButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.DGW1);
            this.Controls.Add(this.inputDGW);
            this.Controls.Add(this.amountUpDown);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.amountUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGW2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown amountUpDown;
        private System.Windows.Forms.DataGridView inputDGW;
        private System.Windows.Forms.DataGridView DGW1;
        private System.Windows.Forms.DataGridViewTextBoxColumn critIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn criName;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn IBZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalScore;
        private System.Windows.Forms.DataGridView DGW2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

