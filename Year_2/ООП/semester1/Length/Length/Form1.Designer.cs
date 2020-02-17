namespace Length
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metresTextBox = new System.Windows.Forms.TextBox();
            this.sazhenTextBox = new System.Windows.Forms.TextBox();
            this.yardsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Метры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SAZHNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ярды";
            // 
            // metresTextBox
            // 
            this.metresTextBox.Location = new System.Drawing.Point(71, 13);
            this.metresTextBox.Name = "metresTextBox";
            this.metresTextBox.Size = new System.Drawing.Size(189, 20);
            this.metresTextBox.TabIndex = 3;
            this.metresTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // sazhenTextBox
            // 
            this.sazhenTextBox.Location = new System.Drawing.Point(71, 45);
            this.sazhenTextBox.Name = "sazhenTextBox";
            this.sazhenTextBox.Size = new System.Drawing.Size(189, 20);
            this.sazhenTextBox.TabIndex = 4;
            this.sazhenTextBox.TextChanged += new System.EventHandler(this.SazhenTextBox_TextChanged);
            // 
            // yardsTextBox
            // 
            this.yardsTextBox.Location = new System.Drawing.Point(71, 81);
            this.yardsTextBox.Name = "yardsTextBox";
            this.yardsTextBox.Size = new System.Drawing.Size(189, 20);
            this.yardsTextBox.TabIndex = 5;
            this.yardsTextBox.TextChanged += new System.EventHandler(this.YardsTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 113);
            this.Controls.Add(this.yardsTextBox);
            this.Controls.Add(this.sazhenTextBox);
            this.Controls.Add(this.metresTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SAZHEN 228";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox metresTextBox;
        private System.Windows.Forms.TextBox sazhenTextBox;
        private System.Windows.Forms.TextBox yardsTextBox;
    }
}

