
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
            this.equipmentPage = new System.Windows.Forms.TabPage();
            this.issuesPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeeAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeBirth = new System.Windows.Forms.DateTimePicker();
            this.employeeAddBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.employeesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // 
            // employeesPage
            // 
            this.employeesPage.Controls.Add(this.groupBox1);
            this.employeesPage.Controls.Add(this.dataGridView1);
            this.employeesPage.Location = new System.Drawing.Point(4, 25);
            this.employeesPage.Name = "employeesPage";
            this.employeesPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeesPage.Size = new System.Drawing.Size(862, 470);
            this.employeesPage.TabIndex = 0;
            this.employeesPage.Text = "Сотрудники";
            this.employeesPage.UseVisualStyleBackColor = true;
            // 
            // equipmentPage
            // 
            this.equipmentPage.Location = new System.Drawing.Point(4, 25);
            this.equipmentPage.Name = "equipmentPage";
            this.equipmentPage.Padding = new System.Windows.Forms.Padding(3);
            this.equipmentPage.Size = new System.Drawing.Size(862, 470);
            this.equipmentPage.TabIndex = 1;
            this.equipmentPage.Text = "Оборудование";
            this.equipmentPage.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeName,
            this.employeeBd,
            this.employeeAdded});
            this.dataGridView1.Location = new System.Drawing.Point(9, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 342);
            this.dataGridView1.TabIndex = 0;
            // 
            // employeeAdded
            // 
            this.employeeAdded.HeaderText = "Добавлено";
            this.employeeAdded.MinimumWidth = 6;
            this.employeeAdded.Name = "employeeAdded";
            this.employeeAdded.Width = 140;
            // 
            // employeeBd
            // 
            this.employeeBd.HeaderText = "Дата рождения";
            this.employeeBd.MinimumWidth = 6;
            this.employeeBd.Name = "employeeBd";
            this.employeeBd.Width = 140;
            // 
            // employeeName
            // 
            this.employeeName.HeaderText = "Имя";
            this.employeeName.MinimumWidth = 6;
            this.employeeName.Name = "employeeName";
            this.employeeName.Width = 508;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // employeeNameTB
            // 
            this.employeeNameTB.Location = new System.Drawing.Point(48, 30);
            this.employeeNameTB.Name = "employeeNameTB";
            this.employeeNameTB.Size = new System.Drawing.Size(621, 22);
            this.employeeNameTB.TabIndex = 1;
            this.employeeNameTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // employeeBirth
            // 
            this.employeeBirth.Location = new System.Drawing.Point(48, 66);
            this.employeeBirth.Name = "employeeBirth";
            this.employeeBirth.Size = new System.Drawing.Size(170, 22);
            this.employeeBirth.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage employeesPage;
        private System.Windows.Forms.TabPage equipmentPage;
        private System.Windows.Forms.TabPage issuesPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeBd;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeAdded;
        private System.Windows.Forms.DateTimePicker employeeBirth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button employeeAddBtn;
    }
}

