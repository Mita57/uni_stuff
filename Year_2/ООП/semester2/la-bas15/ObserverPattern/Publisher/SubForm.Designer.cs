using System.ComponentModel;

namespace Publisher
{
    partial class SubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pubsListBox = new System.Windows.Forms.ListBox();
            this.subBtn = new System.Windows.Forms.Button();
            this.unsubBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(483, 300);
            this.textBox1.TabIndex = 0;
            // 
            // pubsListBox
            // 
            this.pubsListBox.FormattingEnabled = true;
            this.pubsListBox.Location = new System.Drawing.Point(6, 305);
            this.pubsListBox.Name = "pubsListBox";
            this.pubsListBox.Size = new System.Drawing.Size(282, 238);
            this.pubsListBox.TabIndex = 1;
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(294, 316);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(182, 23);
            this.subBtn.TabIndex = 2;
            this.subBtn.Text = "Подписка";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // unsubBtn
            // 
            this.unsubBtn.Location = new System.Drawing.Point(294, 345);
            this.unsubBtn.Name = "unsubBtn";
            this.unsubBtn.Size = new System.Drawing.Size(182, 23);
            this.unsubBtn.TabIndex = 3;
            this.unsubBtn.Text = "Дизлайк и отписка";
            this.unsubBtn.UseVisualStyleBackColor = true;
            this.unsubBtn.Click += new System.EventHandler(this.unsubBtn_Click);
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(482, 558);
            this.Controls.Add(this.unsubBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.pubsListBox);
            this.Controls.Add(this.textBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "SubForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox pubsListBox;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button unsubBtn;

        #endregion
    }
}