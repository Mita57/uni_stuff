
namespace Client
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.employeesPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeAddBtn = new System.Windows.Forms.Button();
            this.employeeBirth = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employeesGrid = new System.Windows.Forms.DataGridView();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipmentPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.equpmentPrice = new System.Windows.Forms.NumericUpDown();
            this.equipmentAddBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.equipmentNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.equipmentGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuesPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.employeesPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).BeginInit();
            this.equipmentPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equpmentPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.employeesPage);
            this.tabControl1.Controls.Add(this.equipmentPage);
            this.tabControl1.Controls.Add(this.issuesPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 499);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // employeesPage
            // 
            this.employeesPage.Controls.Add(this.groupBox1);
            this.employeesPage.Controls.Add(this.employeesGrid);
            this.employeesPage.Location = new System.Drawing.Point(4, 25);
            this.employeesPage.Name = "employeesPage";
            this.employeesPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeesPage.Size = new System.Drawing.Size(862, 470);
            this.employeesPage.TabIndex = 0;
            this.employeesPage.Text = "Сотрудники";
            this.employeesPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employeeAddBtn);
            this.groupBox1.Controls.Add(this.employeeBirth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.employeeNameTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление";
            // 
            // employeeAddBtn
            // 
            this.employeeAddBtn.Location = new System.Drawing.Point(717, 30);
            this.employeeAddBtn.Name = "employeeAddBtn";
            this.employeeAddBtn.Size = new System.Drawing.Size(97, 29);
            this.employeeAddBtn.TabIndex = 4;
            this.employeeAddBtn.Text = "Добавить";
            this.employeeAddBtn.UseVisualStyleBackColor = true;
            this.employeeAddBtn.Click += new System.EventHandler(this.employeeAddBtn_Click);
            // 
            // employeeBirth
            // 
            this.employeeBirth.Location = new System.Drawing.Point(48, 66);
            this.employeeBirth.Name = "employeeBirth";
            this.employeeBirth.Size = new System.Drawing.Size(170, 22);
            this.employeeBirth.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ДР";
            // 
            // employeeNameTB
            // 
            this.employeeNameTB.Location = new System.Drawing.Point(48, 30);
            this.employeeNameTB.Name = "employeeNameTB";
            this.employeeNameTB.Size = new System.Drawing.Size(651, 22);
            this.employeeNameTB.TabIndex = 1;
            this.employeeNameTB.TextChanged += new System.EventHandler(this.employee_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // employeesGrid
            // 
            this.employeesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeName,
            this.employeeBd,
            this.employeeAdded});
            this.employeesGrid.Location = new System.Drawing.Point(9, 9);
            this.employeesGrid.Name = "employeesGrid";
            this.employeesGrid.RowHeadersWidth = 51;
            this.employeesGrid.RowTemplate.Height = 24;
            this.employeesGrid.Size = new System.Drawing.Size(841, 342);
            this.employeesGrid.TabIndex = 0;
            // 
            // employeeName
            // 
            this.employeeName.HeaderText = "Имя";
            this.employeeName.MinimumWidth = 6;
            this.employeeName.Name = "employeeName";
            this.employeeName.Width = 508;
            // 
            // employeeBd
            // 
            this.employeeBd.HeaderText = "Дата рождения";
            this.employeeBd.MinimumWidth = 6;
            this.employeeBd.Name = "employeeBd";
            this.employeeBd.Width = 140;
            // 
            // employeeAdded
            // 
            this.employeeAdded.HeaderText = "Добавлено";
            this.employeeAdded.MinimumWidth = 6;
            this.employeeAdded.Name = "employeeAdded";
            this.employeeAdded.Width = 140;
            // 
            // equipmentPage
            // 
            this.equipmentPage.Controls.Add(this.groupBox2);
            this.equipmentPage.Controls.Add(this.equipmentGrid);
            this.equipmentPage.Location = new System.Drawing.Point(4, 25);
            this.equipmentPage.Name = "equipmentPage";
            this.equipmentPage.Padding = new System.Windows.Forms.Padding(3);
            this.equipmentPage.Size = new System.Drawing.Size(862, 470);
            this.equipmentPage.TabIndex = 1;
            this.equipmentPage.Text = "Оборудование";
            this.equipmentPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.equpmentPrice);
            this.groupBox2.Controls.Add(this.equipmentAddBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.equipmentNameTb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(10, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 96);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление";
            // 
            // equpmentPrice
            // 
            this.equpmentPrice.Location = new System.Drawing.Point(55, 64);
            this.equpmentPrice.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.equpmentPrice.Name = "equpmentPrice";
            this.equpmentPrice.Size = new System.Drawing.Size(128, 22);
            this.equpmentPrice.TabIndex = 5;
            // 
            // equipmentAddBtn
            // 
            this.equipmentAddBtn.Location = new System.Drawing.Point(717, 30);
            this.equipmentAddBtn.Name = "equipmentAddBtn";
            this.equipmentAddBtn.Size = new System.Drawing.Size(97, 29);
            this.equipmentAddBtn.TabIndex = 4;
            this.equipmentAddBtn.Text = "Добавить";
            this.equipmentAddBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // equipmentNameTb
            // 
            this.equipmentNameTb.Location = new System.Drawing.Point(84, 30);
            this.equipmentNameTb.Name = "equipmentNameTb";
            this.equipmentNameTb.Size = new System.Drawing.Size(615, 22);
            this.equipmentNameTb.TabIndex = 1;
            this.equipmentNameTb.TextChanged += new System.EventHandler(this.equipmentNameTb_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Название";
            // 
            // equipmentGrid
            // 
            this.equipmentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.equipmentGrid.Location = new System.Drawing.Point(9, 9);
            this.equipmentGrid.Name = "equipmentGrid";
            this.equipmentGrid.RowHeadersWidth = 51;
            this.equipmentGrid.RowTemplate.Height = 24;
            this.equipmentGrid.Size = new System.Drawing.Size(841, 342);
            this.equipmentGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 508;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Добавлено";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // issuesPage
            // 
            this.issuesPage.Location = new System.Drawing.Point(4, 25);
            this.issuesPage.Name = "issuesPage";
            this.issuesPage.Padding = new System.Windows.Forms.Padding(3);
            this.issuesPage.Size = new System.Drawing.Size(862, 470);
            this.issuesPage.TabIndex = 2;
            this.issuesPage.Text = "Выдача";
            this.issuesPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 496);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.employeesPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesGrid)).EndInit();
            this.equipmentPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equpmentPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage employeesPage;
        private System.Windows.Forms.TabPage equipmentPage;
        private System.Windows.Forms.TabPage issuesPage;
        private System.Windows.Forms.DataGridView employeesGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeBd;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeAdded;
        private System.Windows.Forms.DateTimePicker employeeBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button employeeAddBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button equipmentAddBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox equipmentNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView equipmentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.NumericUpDown equpmentPrice;
    }
}

