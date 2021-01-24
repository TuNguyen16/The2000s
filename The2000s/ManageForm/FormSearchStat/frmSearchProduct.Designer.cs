
namespace The2000s.ManageForm.FormSearchStat
{
    partial class frmSearchProduct
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
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPriceE = new System.Windows.Forms.TextBox();
            this.txtPriceS = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.optPrice = new System.Windows.Forms.RadioButton();
            this.optType = new System.Windows.Forms.RadioButton();
            this.optName = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.pid,
            this.pname,
            this.catname,
            this.price,
            this.createdat,
            this.status});
            this.dgvResult.Location = new System.Drawing.Point(12, 150);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.Size = new System.Drawing.Size(844, 330);
            this.dgvResult.TabIndex = 0;
            // 
            // No
            // 
            this.No.HeaderText = "#";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 30;
            // 
            // pid
            // 
            this.pid.HeaderText = "Mã sản phẩm";
            this.pid.Name = "pid";
            this.pid.ReadOnly = true;
            // 
            // pname
            // 
            this.pname.HeaderText = "Tên sản phẩm";
            this.pname.Name = "pname";
            this.pname.ReadOnly = true;
            this.pname.Width = 180;
            // 
            // catname
            // 
            this.catname.HeaderText = "Loại sản phẩm";
            this.catname.Name = "catname";
            this.catname.ReadOnly = true;
            this.catname.Width = 110;
            // 
            // price
            // 
            this.price.HeaderText = "Giá";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // createdat
            // 
            this.createdat.HeaderText = "Ngày tạo";
            this.createdat.Name = "createdat";
            this.createdat.ReadOnly = true;
            this.createdat.Width = 150;
            // 
            // status
            // 
            this.status.HeaderText = "Trạng thái";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPriceE);
            this.groupBox1.Controls.Add(this.txtPriceS);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.optPrice);
            this.groupBox1.Controls.Add(this.optType);
            this.groupBox1.Controls.Add(this.optName);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 9F);
            this.groupBox1.Location = new System.Drawing.Point(169, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "~";
            // 
            // txtPriceE
            // 
            this.txtPriceE.Location = new System.Drawing.Point(310, 93);
            this.txtPriceE.Name = "txtPriceE";
            this.txtPriceE.Size = new System.Drawing.Size(88, 24);
            this.txtPriceE.TabIndex = 7;
            // 
            // txtPriceS
            // 
            this.txtPriceS.Location = new System.Drawing.Point(191, 92);
            this.txtPriceS.Name = "txtPriceS";
            this.txtPriceS.Size = new System.Drawing.Size(88, 24);
            this.txtPriceS.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(429, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(191, 58);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(207, 25);
            this.cbType.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(191, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 24);
            this.txtName.TabIndex = 3;
            // 
            // optPrice
            // 
            this.optPrice.AutoSize = true;
            this.optPrice.Location = new System.Drawing.Point(36, 93);
            this.optPrice.Name = "optPrice";
            this.optPrice.Size = new System.Drawing.Size(125, 21);
            this.optPrice.TabIndex = 2;
            this.optPrice.TabStop = true;
            this.optPrice.Text = "Tìm kiếm theo giá";
            this.optPrice.UseVisualStyleBackColor = true;
            this.optPrice.CheckedChanged += new System.EventHandler(this.optPrice_CheckedChanged);
            // 
            // optType
            // 
            this.optType.AutoSize = true;
            this.optType.Location = new System.Drawing.Point(36, 59);
            this.optType.Name = "optType";
            this.optType.Size = new System.Drawing.Size(128, 21);
            this.optType.TabIndex = 1;
            this.optType.TabStop = true;
            this.optType.Text = "Tìm kiếm theo loại";
            this.optType.UseVisualStyleBackColor = true;
            this.optType.CheckedChanged += new System.EventHandler(this.optType_CheckedChanged);
            // 
            // optName
            // 
            this.optName.AutoSize = true;
            this.optName.Location = new System.Drawing.Point(36, 23);
            this.optName.Name = "optName";
            this.optName.Size = new System.Drawing.Size(126, 21);
            this.optName.TabIndex = 0;
            this.optName.TabStop = true;
            this.optName.Text = "Tìm kiếm theo tên";
            this.optName.UseVisualStyleBackColor = true;
            this.optName.CheckedChanged += new System.EventHandler(this.optName_CheckedChanged);
            // 
            // frmSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSearchProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm sản phẩm";
            this.Load += new System.EventHandler(this.frmSearchProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton optPrice;
        private System.Windows.Forms.RadioButton optType;
        private System.Windows.Forms.RadioButton optName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPriceE;
        private System.Windows.Forms.TextBox txtPriceS;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pname;
        private System.Windows.Forms.DataGridViewTextBoxColumn catname;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdat;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}