namespace SDI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.allRb = new System.Windows.Forms.RadioButton();
            this.oneRB = new System.Windows.Forms.RadioButton();
            this.killDetkaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BGColor = new System.Windows.Forms.Label();
            this.widthUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.heightUD = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.Label();
            this.poastionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.detkaVisibilityCB = new System.Windows.Forms.CheckBox();
            this.openDetkaButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.abootVisibilityCB = new System.Windows.Forms.CheckBox();
            this.aboutOpenButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.hdrButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUD)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hdrButton);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.killDetkaButton);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BGColor);
            this.groupBox1.Controls.Add(this.widthUD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.heightUD);
            this.groupBox1.Controls.Add(this.height);
            this.groupBox1.Controls.Add(this.poastionLabel);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.detkaVisibilityCB);
            this.groupBox1.Controls.Add(this.openDetkaButton);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детка";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.allRb);
            this.groupBox5.Controls.Add(this.oneRB);
            this.groupBox5.Location = new System.Drawing.Point(10, 251);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(290, 74);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dungeon Master";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // allRb
            // 
            this.allRb.AutoSize = true;
            this.allRb.Checked = true;
            this.allRb.Location = new System.Drawing.Point(6, 42);
            this.allRb.Name = "allRb";
            this.allRb.Size = new System.Drawing.Size(48, 17);
            this.allRb.TabIndex = 1;
            this.allRb.TabStop = true;
            this.allRb.Text = "Фсе";
            this.allRb.UseVisualStyleBackColor = true;
            this.allRb.CheckedChanged += new System.EventHandler(this.AllRb_CheckedChanged);
            // 
            // oneRB
            // 
            this.oneRB.AutoSize = true;
            this.oneRB.Location = new System.Drawing.Point(6, 19);
            this.oneRB.Name = "oneRB";
            this.oneRB.Size = new System.Drawing.Size(82, 17);
            this.oneRB.TabIndex = 0;
            this.oneRB.Text = "В соляного";
            this.oneRB.UseVisualStyleBackColor = true;
            this.oneRB.CheckedChanged += new System.EventHandler(this.OneRB_CheckedChanged);
            // 
            // killDetkaButton
            // 
            this.killDetkaButton.Location = new System.Drawing.Point(211, 222);
            this.killDetkaButton.Name = "killDetkaButton";
            this.killDetkaButton.Size = new System.Drawing.Size(75, 23);
            this.killDetkaButton.TabIndex = 12;
            this.killDetkaButton.Text = "Kill";
            this.killDetkaButton.UseVisualStyleBackColor = true;
            this.killDetkaButton.Click += new System.EventHandler(this.KillDetkaButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BGColor
            // 
            this.BGColor.AutoSize = true;
            this.BGColor.Location = new System.Drawing.Point(3, 222);
            this.BGColor.Name = "BGColor";
            this.BGColor.Size = new System.Drawing.Size(43, 13);
            this.BGColor.TabIndex = 10;
            this.BGColor.Text = "Bgcolor";
            // 
            // widthUD
            // 
            this.widthUD.Location = new System.Drawing.Point(213, 189);
            this.widthUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthUD.Name = "widthUD";
            this.widthUD.Size = new System.Drawing.Size(74, 20);
            this.widthUD.TabIndex = 9;
            this.widthUD.ValueChanged += new System.EventHandler(this.WidthUD_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Width";
            // 
            // heightUD
            // 
            this.heightUD.Location = new System.Drawing.Point(52, 189);
            this.heightUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightUD.Name = "heightUD";
            this.heightUD.Size = new System.Drawing.Size(74, 20);
            this.heightUD.TabIndex = 7;
            this.heightUD.ValueChanged += new System.EventHandler(this.HeightUD_ValueChanged);
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(5, 191);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(38, 13);
            this.height.TabIndex = 6;
            this.height.Text = "Height";
            // 
            // poastionLabel
            // 
            this.poastionLabel.AutoSize = true;
            this.poastionLabel.Location = new System.Drawing.Point(7, 172);
            this.poastionLabel.Name = "poastionLabel";
            this.poastionLabel.Size = new System.Drawing.Size(28, 13);
            this.poastionLabel.TabIndex = 5;
            this.poastionLabel.Text = "Pos:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Header";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(9, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 42);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "State";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(218, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Full v ls";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(113, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Restored";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Minimized";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // detkaVisibilityCB
            // 
            this.detkaVisibilityCB.AutoSize = true;
            this.detkaVisibilityCB.Location = new System.Drawing.Point(7, 62);
            this.detkaVisibilityCB.Name = "detkaVisibilityCB";
            this.detkaVisibilityCB.Size = new System.Drawing.Size(58, 17);
            this.detkaVisibilityCB.TabIndex = 1;
            this.detkaVisibilityCB.Text = "Visibile";
            this.detkaVisibilityCB.UseVisualStyleBackColor = true;
            this.detkaVisibilityCB.CheckedChanged += new System.EventHandler(this.DetkaVisibilityCB_CheckedChanged);
            // 
            // openDetkaButton
            // 
            this.openDetkaButton.Location = new System.Drawing.Point(6, 19);
            this.openDetkaButton.Name = "openDetkaButton";
            this.openDetkaButton.Size = new System.Drawing.Size(296, 36);
            this.openDetkaButton.TabIndex = 0;
            this.openDetkaButton.Text = "Open this sun of a beach";
            this.openDetkaButton.UseVisualStyleBackColor = true;
            this.openDetkaButton.Click += new System.EventHandler(this.OpenDetkaButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.abootVisibilityCB);
            this.groupBox2.Controls.Add(this.aboutOpenButton);
            this.groupBox2.Location = new System.Drawing.Point(322, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Location = new System.Drawing.Point(7, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 42);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "State";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(217, 18);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(60, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.Text = "Full v ls";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(112, 18);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(68, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Restored";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(71, 17);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.Text = "Minimized";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // abootVisibilityCB
            // 
            this.abootVisibilityCB.AutoSize = true;
            this.abootVisibilityCB.Location = new System.Drawing.Point(7, 62);
            this.abootVisibilityCB.Name = "abootVisibilityCB";
            this.abootVisibilityCB.Size = new System.Drawing.Size(58, 17);
            this.abootVisibilityCB.TabIndex = 2;
            this.abootVisibilityCB.Text = "Visibile";
            this.abootVisibilityCB.UseVisualStyleBackColor = true;
            this.abootVisibilityCB.CheckedChanged += new System.EventHandler(this.AbootVisibilityCB_CheckedChanged);
            // 
            // aboutOpenButton
            // 
            this.aboutOpenButton.Location = new System.Drawing.Point(7, 19);
            this.aboutOpenButton.Name = "aboutOpenButton";
            this.aboutOpenButton.Size = new System.Drawing.Size(296, 36);
            this.aboutOpenButton.TabIndex = 1;
            this.aboutOpenButton.Text = "Aboot";
            this.aboutOpenButton.UseVisualStyleBackColor = true;
            this.aboutOpenButton.Click += new System.EventHandler(this.AboutOpenButton_Click);
            // 
            // hdrButton
            // 
            this.hdrButton.Location = new System.Drawing.Point(211, 141);
            this.hdrButton.Name = "hdrButton";
            this.hdrButton.Size = new System.Drawing.Size(75, 23);
            this.hdrButton.TabIndex = 14;
            this.hdrButton.Text = "Change";
            this.hdrButton.UseVisualStyleBackColor = true;
            this.hdrButton.Click += new System.EventHandler(this.HdrButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Laba hz kakaya";
            this.Resize += new System.EventHandler(this.DetkaVisibilityCB_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox detkaVisibilityCB;
        private System.Windows.Forms.Button openDetkaButton;
        private System.Windows.Forms.CheckBox abootVisibilityCB;
        private System.Windows.Forms.Button aboutOpenButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.NumericUpDown widthUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown heightUD;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label poastionLabel;
        private System.Windows.Forms.Label BGColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button killDetkaButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton allRb;
        private System.Windows.Forms.RadioButton oneRB;
        private System.Windows.Forms.Button hdrButton;
    }
}

