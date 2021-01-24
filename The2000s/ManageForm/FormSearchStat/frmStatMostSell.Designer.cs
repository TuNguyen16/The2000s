
namespace The2000s.ManageForm.FormSearchStat
{
    partial class frmStatMostSell
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.numQuarter = new System.Windows.Forms.NumericUpDown();
            this.dtpQYear = new System.Windows.Forms.DateTimePicker();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.optYear = new System.Windows.Forms.RadioButton();
            this.optQuarter = new System.Windows.Forms.RadioButton();
            this.optMonth = new System.Windows.Forms.RadioButton();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuarter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.numQuarter);
            this.groupBox1.Controls.Add(this.dtpQYear);
            this.groupBox1.Controls.Add(this.dtpYear);
            this.groupBox1.Controls.Add(this.dtpMonth);
            this.groupBox1.Controls.Add(this.optYear);
            this.groupBox1.Controls.Add(this.optQuarter);
            this.groupBox1.Controls.Add(this.optMonth);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 9F);
            this.groupBox1.Location = new System.Drawing.Point(224, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn thống kê";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(367, 80);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 25);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "In báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(367, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // numQuarter
            // 
            this.numQuarter.Location = new System.Drawing.Point(194, 58);
            this.numQuarter.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numQuarter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuarter.Name = "numQuarter";
            this.numQuarter.Size = new System.Drawing.Size(29, 24);
            this.numQuarter.TabIndex = 6;
            this.numQuarter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpQYear
            // 
            this.dtpQYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQYear.Location = new System.Drawing.Point(229, 58);
            this.dtpQYear.Name = "dtpQYear";
            this.dtpQYear.Size = new System.Drawing.Size(89, 24);
            this.dtpQYear.TabIndex = 5;
            // 
            // dtpYear
            // 
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(194, 96);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(124, 24);
            this.dtpYear.TabIndex = 4;
            // 
            // dtpMonth
            // 
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(194, 20);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(124, 24);
            this.dtpMonth.TabIndex = 3;
            // 
            // optYear
            // 
            this.optYear.AutoSize = true;
            this.optYear.Location = new System.Drawing.Point(89, 99);
            this.optYear.Name = "optYear";
            this.optYear.Size = new System.Drawing.Size(82, 21);
            this.optYear.TabIndex = 2;
            this.optYear.TabStop = true;
            this.optYear.Text = "Theo năm";
            this.optYear.UseVisualStyleBackColor = true;
            this.optYear.CheckedChanged += new System.EventHandler(this.optYear_CheckedChanged);
            // 
            // optQuarter
            // 
            this.optQuarter.AutoSize = true;
            this.optQuarter.Location = new System.Drawing.Point(89, 61);
            this.optQuarter.Name = "optQuarter";
            this.optQuarter.Size = new System.Drawing.Size(77, 21);
            this.optQuarter.TabIndex = 1;
            this.optQuarter.TabStop = true;
            this.optQuarter.Text = "Theo quý";
            this.optQuarter.UseVisualStyleBackColor = true;
            this.optQuarter.CheckedChanged += new System.EventHandler(this.optQuarter_CheckedChanged);
            // 
            // optMonth
            // 
            this.optMonth.AutoSize = true;
            this.optMonth.Location = new System.Drawing.Point(89, 23);
            this.optMonth.Name = "optMonth";
            this.optMonth.Size = new System.Drawing.Size(89, 21);
            this.optMonth.TabIndex = 0;
            this.optMonth.TabStop = true;
            this.optMonth.Text = "Theo tháng";
            this.optMonth.UseVisualStyleBackColor = true;
            this.optMonth.CheckedChanged += new System.EventHandler(this.optMonth_CheckedChanged);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvProduct.Location = new System.Drawing.Point(12, 163);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(445, 360);
            this.dgvProduct.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã sản phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên sản phẩm";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SL đã bán";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AllowUserToDeleteRows = false;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvCategory.Location = new System.Drawing.Point(463, 163);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.ReadOnly = true;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(445, 360);
            this.dgvCategory.TabIndex = 2;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "#";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 30;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã loại";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tên loại";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 170;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "SL đã bán";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sản phẩm bán chạy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label2.Location = new System.Drawing.Point(736, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại sản phẩm bán chạy";
            // 
            // frmStatMostSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStatMostSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê sản phẩm bán chạy";
            this.Load += new System.EventHandler(this.frmStatMostSell_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuarter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optYear;
        private System.Windows.Forms.RadioButton optQuarter;
        private System.Windows.Forms.RadioButton optMonth;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.NumericUpDown numQuarter;
        private System.Windows.Forms.DateTimePicker dtpQYear;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReport;
    }
}