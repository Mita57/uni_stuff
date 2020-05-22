namespace Laba8
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
            this.allDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.latitude = new System.Windows.Forms.TextBox();
            this.coordsDGV = new System.Windows.Forms.DataGridView();
            this.alaskaDGV = new System.Windows.Forms.DataGridView();
            this.southDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.allDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.coordsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.alaskaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.southDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // allDGV
            // 
            this.allDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.allDGV.Location = new System.Drawing.Point(0, 0);
            this.allDGV.Name = "allDGV";
            this.allDGV.RowHeadersVisible = false;
            this.allDGV.Size = new System.Drawing.Size(1277, 276);
            this.allDGV.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // latitude
            // 
            this.latitude.Location = new System.Drawing.Point(698, 445);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(209, 20);
            this.latitude.TabIndex = 0;
            // 
            // coordsDGV
            // 
            this.coordsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.coordsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coordsDGV.Location = new System.Drawing.Point(919, 296);
            this.coordsDGV.Name = "coordsDGV";
            this.coordsDGV.RowHeadersVisible = false;
            this.coordsDGV.Size = new System.Drawing.Size(346, 437);
            this.coordsDGV.TabIndex = 4;
            // 
            // alaskaDGV
            // 
            this.alaskaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.alaskaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alaskaDGV.Location = new System.Drawing.Point(352, 296);
            this.alaskaDGV.Name = "alaskaDGV";
            this.alaskaDGV.RowHeadersVisible = false;
            this.alaskaDGV.Size = new System.Drawing.Size(329, 437);
            this.alaskaDGV.TabIndex = 3;
            // 
            // southDGV
            // 
            this.southDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.southDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.southDGV.Location = new System.Drawing.Point(12, 296);
            this.southDGV.Name = "southDGV";
            this.southDGV.RowHeadersVisible = false;
            this.southDGV.Size = new System.Drawing.Size(316, 437);
            this.southDGV.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 745);
            this.Controls.Add(this.coordsDGV);
            this.Controls.Add(this.alaskaDGV);
            this.Controls.Add(this.southDGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.allDGV);
            this.Controls.Add(this.latitude);
            this.Name = "Form1";
            this.Text = "Laba8";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.allDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.coordsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.alaskaDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.southDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView alaskaDGV;
        private System.Windows.Forms.DataGridView allDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView coordsDGV;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.DataGridView southDGV;

        #endregion
    }
}

