
namespace The2000s.ManageForm.FormSearchStat
{
    partial class frmStatProfit
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbIn = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOut = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbEarned = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numQuarter = new System.Windows.Forms.NumericUpDown();
            this.dtpQYear = new System.Windows.Forms.DateTimePicker();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.optYear = new System.Windows.Forms.RadioButton();
            this.optQuarter = new System.Windows.Forms.RadioButton();
            this.optMonth = new System.Windows.Forms.RadioButton();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.btnStat = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReportAll = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuarter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbIn);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng thu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(7, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng GT các đơn hàng thành công";
            // 
            // lbIn
            // 
            this.lbIn.AutoSize = true;
            this.lbIn.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lbIn.Location = new System.Drawing.Point(6, 26);
            this.lbIn.Name = "lbIn";
            this.lbIn.Size = new System.Drawing.Size(74, 26);
            this.lbIn.TabIndex = 0;
            this.lbIn.Text = "3 triệu";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbOut);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 97);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng chi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng GT các đơn nhập hàng";
            // 
            // lbOut
            // 
            this.lbOut.AutoSize = true;
            this.lbOut.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lbOut.Location = new System.Drawing.Point(6, 26);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(74, 26);
            this.lbOut.TabIndex = 0;
            this.lbOut.Text = "2 triệu";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.groupBox3.Controls.Add(this.lbStatus);
            this.groupBox3.Controls.Add(this.lbEarned);
            this.groupBox3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 97);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lợi nhuận";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lbStatus.Location = new System.Drawing.Point(6, 58);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(57, 18);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Tiền lời";
            // 
            // lbEarned
            // 
            this.lbEarned.AutoSize = true;
            this.lbEarned.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEarned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lbEarned.Location = new System.Drawing.Point(6, 26);
            this.lbEarned.Name = "lbEarned";
            this.lbEarned.Size = new System.Drawing.Size(74, 26);
            this.lbEarned.TabIndex = 2;
            this.lbEarned.Text = "1 triệu";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReportAll);
            this.groupBox4.Controls.Add(this.btnReport);
            this.groupBox4.Controls.Add(this.btnStat);
            this.groupBox4.Controls.Add(this.numQuarter);
            this.groupBox4.Controls.Add(this.dtpQYear);
            this.groupBox4.Controls.Add(this.dtpYear);
            this.groupBox4.Controls.Add(this.dtpMonth);
            this.groupBox4.Controls.Add(this.optYear);
            this.groupBox4.Controls.Add(this.optQuarter);
            this.groupBox4.Controls.Add(this.optMonth);
            this.groupBox4.Font = new System.Drawing.Font("Open Sans", 9F);
            this.groupBox4.Location = new System.Drawing.Point(12, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(254, 198);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tuỳ chọn thống kê";
            // 
            // numQuarter
            // 
            this.numQuarter.Location = new System.Drawing.Point(111, 66);
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
            this.numQuarter.TabIndex = 13;
            this.numQuarter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpQYear
            // 
            this.dtpQYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpQYear.Location = new System.Drawing.Point(146, 65);
            this.dtpQYear.Name = "dtpQYear";
            this.dtpQYear.Size = new System.Drawing.Size(89, 24);
            this.dtpQYear.TabIndex = 12;
            // 
            // dtpYear
            // 
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(111, 103);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(124, 24);
            this.dtpYear.TabIndex = 11;
            // 
            // dtpMonth
            // 
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(111, 27);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(124, 24);
            this.dtpMonth.TabIndex = 10;
            // 
            // optYear
            // 
            this.optYear.AutoSize = true;
            this.optYear.Location = new System.Drawing.Point(16, 107);
            this.optYear.Name = "optYear";
            this.optYear.Size = new System.Drawing.Size(82, 21);
            this.optYear.TabIndex = 9;
            this.optYear.TabStop = true;
            this.optYear.Text = "Theo năm";
            this.optYear.UseVisualStyleBackColor = true;
            this.optYear.CheckedChanged += new System.EventHandler(this.optYear_CheckedChanged);
            // 
            // optQuarter
            // 
            this.optQuarter.AutoSize = true;
            this.optQuarter.Location = new System.Drawing.Point(16, 69);
            this.optQuarter.Name = "optQuarter";
            this.optQuarter.Size = new System.Drawing.Size(77, 21);
            this.optQuarter.TabIndex = 8;
            this.optQuarter.TabStop = true;
            this.optQuarter.Text = "Theo quý";
            this.optQuarter.UseVisualStyleBackColor = true;
            this.optQuarter.CheckedChanged += new System.EventHandler(this.optQuarter_CheckedChanged);
            // 
            // optMonth
            // 
            this.optMonth.AutoSize = true;
            this.optMonth.Location = new System.Drawing.Point(16, 31);
            this.optMonth.Name = "optMonth";
            this.optMonth.Size = new System.Drawing.Size(89, 21);
            this.optMonth.TabIndex = 7;
            this.optMonth.TabStop = true;
            this.optMonth.Text = "Theo tháng";
            this.optMonth.UseVisualStyleBackColor = true;
            this.optMonth.CheckedChanged += new System.EventHandler(this.optMonth_CheckedChanged);
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvOrderList.Location = new System.Drawing.Point(272, 12);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.Size = new System.Drawing.Size(613, 528);
            this.dgvOrderList.TabIndex = 7;
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(40, 134);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(75, 26);
            this.btnStat.TabIndex = 14;
            this.btnStat.Text = "Thống kê";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(121, 134);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 26);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "In báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
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
            this.Column2.HeaderText = "Mã đơn hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên khách hàng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tổng giá trị";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày tạo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // btnReportAll
            // 
            this.btnReportAll.Location = new System.Drawing.Point(66, 166);
            this.btnReportAll.Name = "btnReportAll";
            this.btnReportAll.Size = new System.Drawing.Size(112, 26);
            this.btnReportAll.TabIndex = 16;
            this.btnReportAll.Text = "In báo cáo tất cả";
            this.btnReportAll.UseVisualStyleBackColor = true;
            this.btnReportAll.Click += new System.EventHandler(this.btnReportAll_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Font = new System.Drawing.Font("Open Sans", 9F);
            this.groupBox5.Location = new System.Drawing.Point(12, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 328);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doanh thu toàn hệ thống";
            // 
            // frmStatProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 552);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStatProfit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu, thu chi";
            this.Load += new System.EventHandler(this.frmStatProfit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuarter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbOut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbEarned;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numQuarter;
        private System.Windows.Forms.DateTimePicker dtpQYear;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.RadioButton optYear;
        private System.Windows.Forms.RadioButton optQuarter;
        private System.Windows.Forms.RadioButton optMonth;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnReportAll;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}