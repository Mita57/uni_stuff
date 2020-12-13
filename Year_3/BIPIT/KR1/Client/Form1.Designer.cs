
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.waybillTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wauBillDate = new System.Windows.Forms.DateTimePicker();
            this.supplierCB = new System.Windows.Forms.ComboBox();
            this.sumTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.supplierGrid = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addSupplier = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.supplierName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waybillTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 547);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.waybillTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(916, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Накладные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.supplierGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(916, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поставщики";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // waybillTable
            // 
            this.waybillTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waybillTable.Location = new System.Drawing.Point(0, 0);
            this.waybillTable.Name = "waybillTable";
            this.waybillTable.RowHeadersWidth = 51;
            this.waybillTable.RowTemplate.Height = 24;
            this.waybillTable.Size = new System.Drawing.Size(916, 408);
            this.waybillTable.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sumTB);
            this.groupBox1.Controls.Add(this.supplierCB);
            this.groupBox1.Controls.Add(this.wauBillDate);
            this.groupBox1.Location = new System.Drawing.Point(8, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление";
            // 
            // wauBillDate
            // 
            this.wauBillDate.Location = new System.Drawing.Point(16, 30);
            this.wauBillDate.Name = "wauBillDate";
            this.wauBillDate.Size = new System.Drawing.Size(200, 22);
            this.wauBillDate.TabIndex = 2;
            // 
            // supplierCB
            // 
            this.supplierCB.FormattingEnabled = true;
            this.supplierCB.Location = new System.Drawing.Point(234, 28);
            this.supplierCB.Name = "supplierCB";
            this.supplierCB.Size = new System.Drawing.Size(344, 24);
            this.supplierCB.TabIndex = 1;
            this.supplierCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sumTB
            // 
            this.sumTB.Location = new System.Drawing.Point(593, 30);
            this.sumTB.Name = "sumTB";
            this.sumTB.Size = new System.Drawing.Size(177, 22);
            this.sumTB.TabIndex = 2;
            this.sumTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поставщик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(652, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сумма";
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(785, 30);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(107, 32);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // supplierGrid
            // 
            this.supplierGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGrid.Location = new System.Drawing.Point(0, 0);
            this.supplierGrid.Name = "supplierGrid";
            this.supplierGrid.RowHeadersWidth = 51;
            this.supplierGrid.RowTemplate.Height = 24;
            this.supplierGrid.Size = new System.Drawing.Size(916, 408);
            this.supplierGrid.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addSupplier);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.supplierName);
            this.groupBox2.Location = new System.Drawing.Point(8, 414);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 90);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление";
            // 
            // addSupplier
            // 
            this.addSupplier.Enabled = false;
            this.addSupplier.Location = new System.Drawing.Point(785, 30);
            this.addSupplier.Name = "addSupplier";
            this.addSupplier.Size = new System.Drawing.Size(107, 32);
            this.addSupplier.TabIndex = 5;
            this.addSupplier.Text = "Добавить";
            this.addSupplier.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Название";
            // 
            // supplierName
            // 
            this.supplierName.Location = new System.Drawing.Point(34, 35);
            this.supplierName.Name = "supplierName";
            this.supplierName.Size = new System.Drawing.Size(745, 22);
            this.supplierName.TabIndex = 2;
            this.supplierName.TextChanged += new System.EventHandler(this.supplierName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 544);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waybillTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView waybillTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox supplierCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sumTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DateTimePicker wauBillDate;
        private System.Windows.Forms.DataGridView supplierGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox supplierName;
    }
}

