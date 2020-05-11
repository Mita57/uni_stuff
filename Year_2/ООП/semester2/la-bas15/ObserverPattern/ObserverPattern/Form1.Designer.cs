namespace ObserverPattern
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addObserverBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(14, 18);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(135, 30);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Событие A";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(14, 81);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(135, 30);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Событие B";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(184, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Подписчиков:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(184, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Подписчиков:";
            // 
            // addObserverBtn
            // 
            this.addObserverBtn.Location = new System.Drawing.Point(12, 192);
            this.addObserverBtn.Name = "addObserverBtn";
            this.addObserverBtn.Size = new System.Drawing.Size(154, 29);
            this.addObserverBtn.TabIndex = 4;
            this.addObserverBtn.Text = "Добавить наблюдателя";
            this.addObserverBtn.UseVisualStyleBackColor = true;
            this.addObserverBtn.Click += new System.EventHandler(this.addObserverBtn_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Всего наблюдателей:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(184, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Подписчиков:";
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(14, 140);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(135, 30);
            this.Button3.TabIndex = 6;
            this.Button3.Text = "Событие С";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(350, 273);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addObserverBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addObserverBtn;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        #endregion
    }
}