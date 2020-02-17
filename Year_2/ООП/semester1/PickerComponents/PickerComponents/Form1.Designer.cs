namespace PickerComponents
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
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.unaryOperationGroupBox = new System.Windows.Forms.GroupBox();
            this.cotangentRadio = new System.Windows.Forms.RadioButton();
            this.tangentRadio = new System.Windows.Forms.RadioButton();
            this.cosineRadio = new System.Windows.Forms.RadioButton();
            this.sineRadio = new System.Windows.Forms.RadioButton();
            this.operandsGroupBox = new System.Windows.Forms.GroupBox();
            this.twoNumbersRadio = new System.Windows.Forms.RadioButton();
            this.oneNumberRadio = new System.Windows.Forms.RadioButton();
            this.binaryOpsGroupBox = new System.Windows.Forms.GroupBox();
            this.divisionRadio = new System.Windows.Forms.RadioButton();
            this.additionRadio = new System.Windows.Forms.RadioButton();
            this.multiplicationRadio = new System.Windows.Forms.RadioButton();
            this.substractionRadio = new System.Windows.Forms.RadioButton();
            this.formulaCheckBox = new System.Windows.Forms.CheckBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.computeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.secondNumberGroupBox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.unaryOperationGroupBox.SuspendLayout();
            this.operandsGroupBox.SuspendLayout();
            this.binaryOpsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstNumberTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Первое число";
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(6, 19);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNumberTextBox.TabIndex = 0;
            this.firstNumberTextBox.Text = "0";
            this.firstNumberTextBox.TextChanged += new System.EventHandler(this.FirstNumberTextBox_TextChanged);
            // 
            // secondNumberGroupBox
            // 
            this.secondNumberGroupBox.Controls.Add(this.secondNumberTextBox);
            this.secondNumberGroupBox.Location = new System.Drawing.Point(231, 9);
            this.secondNumberGroupBox.Name = "secondNumberGroupBox";
            this.secondNumberGroupBox.Size = new System.Drawing.Size(213, 50);
            this.secondNumberGroupBox.TabIndex = 1;
            this.secondNumberGroupBox.TabStop = false;
            this.secondNumberGroupBox.Text = "Второе число";
            this.secondNumberGroupBox.Visible = false;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(5, 19);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.secondNumberTextBox.TabIndex = 1;
            this.secondNumberTextBox.Text = "0";
            this.secondNumberTextBox.TextChanged += new System.EventHandler(this.SecondNumberTextBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resultTextBox);
            this.groupBox3.Location = new System.Drawing.Point(450, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 50);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(5, 19);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(200, 20);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.Text = "0";
            // 
            // unaryOperationGroupBox
            // 
            this.unaryOperationGroupBox.Controls.Add(this.cotangentRadio);
            this.unaryOperationGroupBox.Controls.Add(this.tangentRadio);
            this.unaryOperationGroupBox.Controls.Add(this.cosineRadio);
            this.unaryOperationGroupBox.Controls.Add(this.sineRadio);
            this.unaryOperationGroupBox.Location = new System.Drawing.Point(12, 65);
            this.unaryOperationGroupBox.Name = "unaryOperationGroupBox";
            this.unaryOperationGroupBox.Size = new System.Drawing.Size(213, 114);
            this.unaryOperationGroupBox.TabIndex = 1;
            this.unaryOperationGroupBox.TabStop = false;
            this.unaryOperationGroupBox.Text = "Унарные операции";
            this.unaryOperationGroupBox.Visible = false;
            // 
            // cotangentRadio
            // 
            this.cotangentRadio.AutoSize = true;
            this.cotangentRadio.Location = new System.Drawing.Point(7, 89);
            this.cotangentRadio.Name = "cotangentRadio";
            this.cotangentRadio.Size = new System.Drawing.Size(54, 17);
            this.cotangentRadio.TabIndex = 3;
            this.cotangentRadio.TabStop = true;
            this.cotangentRadio.Text = "Ctg(X)";
            this.cotangentRadio.UseVisualStyleBackColor = true;
            // 
            // tangentRadio
            // 
            this.tangentRadio.AutoSize = true;
            this.tangentRadio.Location = new System.Drawing.Point(7, 66);
            this.tangentRadio.Name = "tangentRadio";
            this.tangentRadio.Size = new System.Drawing.Size(57, 17);
            this.tangentRadio.TabIndex = 2;
            this.tangentRadio.TabStop = true;
            this.tangentRadio.Text = "Tan(X)";
            this.tangentRadio.UseVisualStyleBackColor = true;
            // 
            // cosineRadio
            // 
            this.cosineRadio.AutoSize = true;
            this.cosineRadio.Location = new System.Drawing.Point(6, 43);
            this.cosineRadio.Name = "cosineRadio";
            this.cosineRadio.Size = new System.Drawing.Size(56, 17);
            this.cosineRadio.TabIndex = 1;
            this.cosineRadio.TabStop = true;
            this.cosineRadio.Text = "Cos(X)";
            this.cosineRadio.UseVisualStyleBackColor = true;
            // 
            // sineRadio
            // 
            this.sineRadio.AutoSize = true;
            this.sineRadio.Location = new System.Drawing.Point(7, 20);
            this.sineRadio.Name = "sineRadio";
            this.sineRadio.Size = new System.Drawing.Size(53, 17);
            this.sineRadio.TabIndex = 0;
            this.sineRadio.TabStop = true;
            this.sineRadio.Text = "Sin(X)";
            this.sineRadio.UseVisualStyleBackColor = true;
            // 
            // operandsGroupBox
            // 
            this.operandsGroupBox.Controls.Add(this.twoNumbersRadio);
            this.operandsGroupBox.Controls.Add(this.oneNumberRadio);
            this.operandsGroupBox.Location = new System.Drawing.Point(231, 65);
            this.operandsGroupBox.Name = "operandsGroupBox";
            this.operandsGroupBox.Size = new System.Drawing.Size(213, 69);
            this.operandsGroupBox.TabIndex = 2;
            this.operandsGroupBox.TabStop = false;
            this.operandsGroupBox.Text = "Число операндов";
            // 
            // twoNumbersRadio
            // 
            this.twoNumbersRadio.AutoSize = true;
            this.twoNumbersRadio.Location = new System.Drawing.Point(5, 43);
            this.twoNumbersRadio.Name = "twoNumbersRadio";
            this.twoNumbersRadio.Size = new System.Drawing.Size(78, 17);
            this.twoNumbersRadio.TabIndex = 5;
            this.twoNumbersRadio.TabStop = true;
            this.twoNumbersRadio.Text = "Два числа";
            this.twoNumbersRadio.UseVisualStyleBackColor = true;
            this.twoNumbersRadio.CheckedChanged += new System.EventHandler(this.TwoNumbersRadio_CheckedChanged);
            // 
            // oneNumberRadio
            // 
            this.oneNumberRadio.AutoSize = true;
            this.oneNumberRadio.Location = new System.Drawing.Point(6, 20);
            this.oneNumberRadio.Name = "oneNumberRadio";
            this.oneNumberRadio.Size = new System.Drawing.Size(84, 17);
            this.oneNumberRadio.TabIndex = 4;
            this.oneNumberRadio.TabStop = true;
            this.oneNumberRadio.Text = "Адын число";
            this.oneNumberRadio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.oneNumberRadio.UseVisualStyleBackColor = true;
            this.oneNumberRadio.CheckedChanged += new System.EventHandler(this.OneNumberRadio_CheckedChanged);
            // 
            // binaryOpsGroupBox
            // 
            this.binaryOpsGroupBox.Controls.Add(this.divisionRadio);
            this.binaryOpsGroupBox.Controls.Add(this.additionRadio);
            this.binaryOpsGroupBox.Controls.Add(this.multiplicationRadio);
            this.binaryOpsGroupBox.Controls.Add(this.substractionRadio);
            this.binaryOpsGroupBox.Location = new System.Drawing.Point(450, 65);
            this.binaryOpsGroupBox.Name = "binaryOpsGroupBox";
            this.binaryOpsGroupBox.Size = new System.Drawing.Size(213, 114);
            this.binaryOpsGroupBox.TabIndex = 2;
            this.binaryOpsGroupBox.TabStop = false;
            this.binaryOpsGroupBox.Text = "Бинарные операции";
            this.binaryOpsGroupBox.Visible = false;
            // 
            // divisionRadio
            // 
            this.divisionRadio.AutoSize = true;
            this.divisionRadio.Location = new System.Drawing.Point(6, 88);
            this.divisionRadio.Name = "divisionRadio";
            this.divisionRadio.Size = new System.Drawing.Size(70, 17);
            this.divisionRadio.TabIndex = 7;
            this.divisionRadio.TabStop = true;
            this.divisionRadio.Text = "Деление";
            this.divisionRadio.UseVisualStyleBackColor = true;
            // 
            // additionRadio
            // 
            this.additionRadio.AutoSize = true;
            this.additionRadio.Location = new System.Drawing.Point(6, 19);
            this.additionRadio.Name = "additionRadio";
            this.additionRadio.Size = new System.Drawing.Size(76, 17);
            this.additionRadio.TabIndex = 4;
            this.additionRadio.TabStop = true;
            this.additionRadio.Text = "Сложение";
            this.additionRadio.UseVisualStyleBackColor = true;
            // 
            // multiplicationRadio
            // 
            this.multiplicationRadio.AutoSize = true;
            this.multiplicationRadio.Location = new System.Drawing.Point(6, 65);
            this.multiplicationRadio.Name = "multiplicationRadio";
            this.multiplicationRadio.Size = new System.Drawing.Size(85, 17);
            this.multiplicationRadio.TabIndex = 6;
            this.multiplicationRadio.TabStop = true;
            this.multiplicationRadio.Text = "Умножение";
            this.multiplicationRadio.UseVisualStyleBackColor = true;
            // 
            // substractionRadio
            // 
            this.substractionRadio.AutoSize = true;
            this.substractionRadio.Location = new System.Drawing.Point(5, 42);
            this.substractionRadio.Name = "substractionRadio";
            this.substractionRadio.Size = new System.Drawing.Size(80, 17);
            this.substractionRadio.TabIndex = 5;
            this.substractionRadio.TabStop = true;
            this.substractionRadio.Text = "Вычитание";
            this.substractionRadio.UseVisualStyleBackColor = true;
            // 
            // formulaCheckBox
            // 
            this.formulaCheckBox.AutoSize = true;
            this.formulaCheckBox.Location = new System.Drawing.Point(12, 197);
            this.formulaCheckBox.Name = "formulaCheckBox";
            this.formulaCheckBox.Size = new System.Drawing.Size(74, 17);
            this.formulaCheckBox.TabIndex = 4;
            this.formulaCheckBox.Text = "Формула";
            this.formulaCheckBox.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(92, 198);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(58, 13);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "resultLabel";
            this.resultLabel.Visible = false;
            // 
            // computeButton
            // 
            this.computeButton.Image = ((System.Drawing.Image)(resources.GetObject("computeButton.Image")));
            this.computeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.computeButton.Location = new System.Drawing.Point(231, 140);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(212, 38);
            this.computeButton.TabIndex = 3;
            this.computeButton.Text = "Вычислитб";
            this.computeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 235);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.formulaCheckBox);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.binaryOpsGroupBox);
            this.Controls.Add(this.operandsGroupBox);
            this.Controls.Add(this.unaryOperationGroupBox);
            this.Controls.Add(this.secondNumberGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Лабораторная работа намба 6 Мячикова Тимофея";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.secondNumberGroupBox.ResumeLayout(false);
            this.secondNumberGroupBox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.unaryOperationGroupBox.ResumeLayout(false);
            this.unaryOperationGroupBox.PerformLayout();
            this.operandsGroupBox.ResumeLayout(false);
            this.operandsGroupBox.PerformLayout();
            this.binaryOpsGroupBox.ResumeLayout(false);
            this.binaryOpsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox secondNumberGroupBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox unaryOperationGroupBox;
        private System.Windows.Forms.GroupBox operandsGroupBox;
        private System.Windows.Forms.GroupBox binaryOpsGroupBox;
        private System.Windows.Forms.RadioButton cotangentRadio;
        private System.Windows.Forms.RadioButton tangentRadio;
        private System.Windows.Forms.RadioButton cosineRadio;
        private System.Windows.Forms.RadioButton sineRadio;
        private System.Windows.Forms.RadioButton divisionRadio;
        private System.Windows.Forms.RadioButton additionRadio;
        private System.Windows.Forms.RadioButton multiplicationRadio;
        private System.Windows.Forms.RadioButton substractionRadio;
        private System.Windows.Forms.RadioButton twoNumbersRadio;
        private System.Windows.Forms.RadioButton oneNumberRadio;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.CheckBox formulaCheckBox;
        private System.Windows.Forms.Label resultLabel;
    }
}

