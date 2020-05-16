namespace Publisher
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createPubBtn = new System.Windows.Forms.Button();
            this.magazineRB = new System.Windows.Forms.RadioButton();
            this.newspaperRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pubNameTB = new System.Windows.Forms.TextBox();
            this.pubsListBox = new System.Windows.Forms.ListBox();
            this.subsListBox = new System.Windows.Forms.ListBox();
            this.subButton = new System.Windows.Forms.Button();
            this.unsubBtn = new System.Windows.Forms.Button();
            this.createSubBtn = new System.Windows.Forms.Button();
            this.pauseProdBtn = new System.Windows.Forms.Button();
            this.cancelProdBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            this.textBox1.Location = new System.Drawing.Point(0, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(801, 223);
            this.textBox1.TabIndex = 0;
            this.groupBox1.Controls.Add(this.createPubBtn);
            this.groupBox1.Controls.Add(this.magazineRB);
            this.groupBox1.Controls.Add(this.newspaperRB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pubNameTB);
            this.groupBox1.Location = new System.Drawing.Point(11, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Новое издание";
            this.createPubBtn.Location = new System.Drawing.Point(88, 80);
            this.createPubBtn.Name = "createPubBtn";
            this.createPubBtn.Size = new System.Drawing.Size(75, 23);
            this.createPubBtn.TabIndex = 4;
            this.createPubBtn.Text = "Запилить";
            this.createPubBtn.UseVisualStyleBackColor = true;
            this.createPubBtn.Click += new System.EventHandler(this.createPubBtn_Click);
            this.magazineRB.Location = new System.Drawing.Point(169, 52);
            this.magazineRB.Name = "magazineRB";
            this.magazineRB.Size = new System.Drawing.Size(104, 24);
            this.magazineRB.TabIndex = 3;
            this.magazineRB.Text = "Журналъ";
            this.magazineRB.UseVisualStyleBackColor = true;
            this.newspaperRB.Checked = true;
            this.newspaperRB.Location = new System.Drawing.Point(6, 52);
            this.newspaperRB.Name = "newspaperRB";
            this.newspaperRB.Size = new System.Drawing.Size(104, 24);
            this.newspaperRB.TabIndex = 2;
            this.newspaperRB.TabStop = true;
            this.newspaperRB.Text = "Газета";
            this.newspaperRB.UseVisualStyleBackColor = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            this.pubNameTB.Location = new System.Drawing.Point(71, 24);
            this.pubNameTB.Name = "pubNameTB";
            this.pubNameTB.Size = new System.Drawing.Size(202, 20);
            this.pubNameTB.TabIndex = 0;
            this.pubsListBox.FormattingEnabled = true;
            this.pubsListBox.Location = new System.Drawing.Point(15, 360);
            this.pubsListBox.Name = "pubsListBox";
            this.pubsListBox.Size = new System.Drawing.Size(278, 212);
            this.pubsListBox.TabIndex = 2;
            this.subsListBox.FormattingEnabled = true;
            this.subsListBox.Location = new System.Drawing.Point(510, 360);
            this.subsListBox.Name = "subsListBox";
            this.subsListBox.Size = new System.Drawing.Size(278, 212);
            this.subsListBox.TabIndex = 3;
            this.subButton.Location = new System.Drawing.Point(323, 369);
            this.subButton.Name = "subButton";
            this.subButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subButton.Size = new System.Drawing.Size(139, 24);
            this.subButton.TabIndex = 4;
            this.subButton.Text = "Подписать";
            this.subButton.UseVisualStyleBackColor = true;
            this.unsubBtn.Location = new System.Drawing.Point(323, 399);
            this.unsubBtn.Name = "unsubBtn";
            this.unsubBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.unsubBtn.Size = new System.Drawing.Size(139, 24);
            this.unsubBtn.TabIndex = 5;
            this.unsubBtn.Text = "Дизлайк отписка";
            this.unsubBtn.UseVisualStyleBackColor = true;
            this.createSubBtn.Location = new System.Drawing.Point(502, 269);
            this.createSubBtn.Name = "createSubBtn";
            this.createSubBtn.Size = new System.Drawing.Size(285, 30);
            this.createSubBtn.TabIndex = 6;
            this.createSubBtn.Text = "Создать подиписчека";
            this.createSubBtn.UseVisualStyleBackColor = true;
            this.createSubBtn.Click += new System.EventHandler(this.createSubBtn_Click);
            this.pauseProdBtn.Location = new System.Drawing.Point(15, 578);
            this.pauseProdBtn.Name = "pauseProdBtn";
            this.pauseProdBtn.Size = new System.Drawing.Size(125, 27);
            this.pauseProdBtn.TabIndex = 7;
            this.pauseProdBtn.Text = "Астанавитесь";
            this.pauseProdBtn.UseVisualStyleBackColor = true;
            this.cancelProdBtn.Location = new System.Drawing.Point(168, 578);
            this.cancelProdBtn.Name = "cancelProdBtn";
            this.cancelProdBtn.Size = new System.Drawing.Size(125, 27);
            this.cancelProdBtn.TabIndex = 8;
            this.cancelProdBtn.Text = "РофланПоминки";
            this.cancelProdBtn.UseVisualStyleBackColor = true;
            this.cancelProdBtn.Click += new System.EventHandler(this.cancelProdBtn_Click);
            this.button2.Location = new System.Drawing.Point(503, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Минусануть подписчика";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cancelProdBtn);
            this.Controls.Add(this.pauseProdBtn);
            this.Controls.Add(this.createSubBtn);
            this.Controls.Add(this.unsubBtn);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.subsListBox);
            this.Controls.Add(this.pubsListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cancelProdBtn;
        private System.Windows.Forms.Button createPubBtn;
        private System.Windows.Forms.Button createSubBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton magazineRB;
        private System.Windows.Forms.RadioButton newspaperRB;
        private System.Windows.Forms.Button pauseProdBtn;
        private System.Windows.Forms.TextBox pubNameTB;
        private System.Windows.Forms.ListBox pubsListBox;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.ListBox subsListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button unsubBtn;

        #endregion
    }
}