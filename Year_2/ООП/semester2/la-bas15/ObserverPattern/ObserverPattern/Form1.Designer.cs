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
            this.eventABtn = new System.Windows.Forms.Button();
            this.eventBBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addObserverBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eventABtn
            // 
            this.eventABtn.Location = new System.Drawing.Point(14, 18);
            this.eventABtn.Name = "eventABtn";
            this.eventABtn.Size = new System.Drawing.Size(135, 30);
            this.eventABtn.TabIndex = 0;
            this.eventABtn.Text = "Событие A";
            this.eventABtn.UseVisualStyleBackColor = true;
            // 
            // eventBBtn
            // 
            this.eventBBtn.Location = new System.Drawing.Point(14, 81);
            this.eventBBtn.Name = "eventBBtn";
            this.eventBBtn.Size = new System.Drawing.Size(135, 30);
            this.eventBBtn.TabIndex = 1;
            this.eventBBtn.Text = "Событие B";
            this.eventBBtn.UseVisualStyleBackColor = true;
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
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Подписчиков:";
            // 
            // addObserverBtn
            // 
            this.addObserverBtn.Location = new System.Drawing.Point(14, 176);
            this.addObserverBtn.Name = "addObserverBtn";
            this.addObserverBtn.Size = new System.Drawing.Size(154, 29);
            this.addObserverBtn.TabIndex = 4;
            this.addObserverBtn.Text = "Добавить наблюдателя";
            this.addObserverBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 273);
            this.Controls.Add(this.addObserverBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eventBBtn);
            this.Controls.Add(this.eventABtn);
            this.Name = "Form1";
            this.Text = "Источник";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addObserverBtn;
        private System.Windows.Forms.Button eventABtn;
        private System.Windows.Forms.Button eventBBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}