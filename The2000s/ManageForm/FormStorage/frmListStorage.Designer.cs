
namespace The2000s.ManageForm.FormStorage
{
    partial class frmListStorage
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
            this.dgvImportList = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvImportList);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 8F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đơn nhập hàng";
            // 
            // dgvImportList
            // 
            this.dgvImportList.AllowUserToAddRows = false;
            this.dgvImportList.AllowUserToDeleteRows = false;
            this.dgvImportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ImportID,
            this.SupName,
            this.TotalMoney,
            this.CreatedAt});
            this.dgvImportList.Location = new System.Drawing.Point(6, 19);
            this.dgvImportList.Name = "dgvImportList";
            this.dgvImportList.ReadOnly = true;
            this.dgvImportList.Size = new System.Drawing.Size(670, 466);
            this.dgvImportList.TabIndex = 0;
            // 
            // No
            // 
            this.No.HeaderText = "#";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 30;
            // 
            // ImportID
            // 
            this.ImportID.HeaderText = "Mã đơn nhập";
            this.ImportID.Name = "ImportID";
            this.ImportID.ReadOnly = true;
            // 
            // SupName
            // 
            this.SupName.HeaderText = "Tên nhà cung cấp";
            this.SupName.Name = "SupName";
            this.SupName.ReadOnly = true;
            this.SupName.Width = 175;
            // 
            // TotalMoney
            // 
            this.TotalMoney.HeaderText = "Tổng tiền";
            this.TotalMoney.Name = "TotalMoney";
            this.TotalMoney.ReadOnly = true;
            this.TotalMoney.Width = 130;
            // 
            // CreatedAt
            // 
            this.CreatedAt.HeaderText = "Ngày tạo";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            this.CreatedAt.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8F);
            this.label1.Location = new System.Drawing.Point(15, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng số";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Open Sans", 8F);
            this.txtTotal.Location = new System.Drawing.Point(68, 508);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(63, 22);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Open Sans", 8F);
            this.btnExit.Location = new System.Drawing.Point(635, 506);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Open Sans", 8F);
            this.btnAdd.Location = new System.Drawing.Point(526, 506);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm đơn nhập";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmListStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 533);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListStorage";
            this.Text = "Quản lý đơn nhập hàng";
            this.Load += new System.EventHandler(this.frmListStorage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvImportList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
    }
}