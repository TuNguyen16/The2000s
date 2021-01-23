
namespace The2000s.ManageForm.FormSearchStat
{
    partial class frmSearchOrder
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpS = new System.Windows.Forms.DateTimePicker();
            this.dtpE = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.optTime = new System.Windows.Forms.RadioButton();
            this.optStatus = new System.Windows.Forms.RadioButton();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Open Sans", 9F);
            this.btnSearch.Location = new System.Drawing.Point(167, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID,
            this.CustomerName,
            this.Status,
            this.DateCreate});
            this.dgvResult.Location = new System.Drawing.Point(12, 127);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(565, 334);
            this.dgvResult.TabIndex = 7;
            // 
            // No
            // 
            this.No.HeaderText = "#";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 30;
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã HĐ";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 80;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Khách hàng";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // DateCreate
            // 
            this.DateCreate.HeaderText = "Thời gian";
            this.DateCreate.Name = "DateCreate";
            this.DateCreate.ReadOnly = true;
            this.DateCreate.Width = 145;
            // 
            // dtpS
            // 
            this.dtpS.Font = new System.Drawing.Font("Open Sans", 9F);
            this.dtpS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpS.Location = new System.Drawing.Point(146, 16);
            this.dtpS.Name = "dtpS";
            this.dtpS.Size = new System.Drawing.Size(121, 24);
            this.dtpS.TabIndex = 8;
            // 
            // dtpE
            // 
            this.dtpE.Font = new System.Drawing.Font("Open Sans", 9F);
            this.dtpE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpE.Location = new System.Drawing.Point(291, 16);
            this.dtpE.Name = "dtpE";
            this.dtpE.Size = new System.Drawing.Size(108, 24);
            this.dtpE.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9F);
            this.label2.Location = new System.Drawing.Point(270, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "~";
            // 
            // optTime
            // 
            this.optTime.AutoSize = true;
            this.optTime.Font = new System.Drawing.Font("Open Sans", 9F);
            this.optTime.Location = new System.Drawing.Point(45, 16);
            this.optTime.Name = "optTime";
            this.optTime.Size = new System.Drawing.Size(77, 21);
            this.optTime.TabIndex = 11;
            this.optTime.TabStop = true;
            this.optTime.Text = "Thời gian";
            this.optTime.UseVisualStyleBackColor = true;
            this.optTime.CheckedChanged += new System.EventHandler(this.optTime_CheckedChanged);
            // 
            // optStatus
            // 
            this.optStatus.AutoSize = true;
            this.optStatus.Font = new System.Drawing.Font("Open Sans", 9F);
            this.optStatus.Location = new System.Drawing.Point(45, 46);
            this.optStatus.Name = "optStatus";
            this.optStatus.Size = new System.Drawing.Size(83, 21);
            this.optStatus.TabIndex = 12;
            this.optStatus.TabStop = true;
            this.optStatus.Text = "Trạng thái";
            this.optStatus.UseVisualStyleBackColor = true;
            this.optStatus.CheckedChanged += new System.EventHandler(this.optStatus_CheckedChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(146, 47);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 25);
            this.cbStatus.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.optStatus);
            this.groupBox1.Controls.Add(this.optTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpE);
            this.groupBox1.Controls.Add(this.dtpS);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 9F);
            this.groupBox1.Location = new System.Drawing.Point(71, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 112);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // frmSearchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSearchOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm đơn hàng";
            this.Load += new System.EventHandler(this.frmSearchOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreate;
        private System.Windows.Forms.DateTimePicker dtpS;
        private System.Windows.Forms.DateTimePicker dtpE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optTime;
        private System.Windows.Forms.RadioButton optStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}