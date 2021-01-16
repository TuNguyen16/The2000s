
namespace The2000s
{
    partial class frmAdmin
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuFeature = new System.Windows.Forms.MenuStrip();
            this.menuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.QL_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.QL_ProductCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.QL_Order = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.QL_Storage = new System.Windows.Forms.ToolStripMenuItem();
            this.QL_Supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.listUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStat = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSuccess = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbProcessing = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEarned = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCancel = new System.Windows.Forms.Label();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.menuFeature.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFeature
            // 
            this.menuFeature.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProduct,
            this.menuOrder,
            this.menuStorage,
            this.menuUser,
            this.menuStat});
            this.menuFeature.Location = new System.Drawing.Point(0, 0);
            this.menuFeature.Name = "menuFeature";
            this.menuFeature.Size = new System.Drawing.Size(923, 24);
            this.menuFeature.TabIndex = 1;
            this.menuFeature.Text = "menuStrip1";
            // 
            // menuProduct
            // 
            this.menuProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QL_Product,
            this.QL_ProductCategory});
            this.menuProduct.Name = "menuProduct";
            this.menuProduct.Size = new System.Drawing.Size(72, 20);
            this.menuProduct.Text = "Sản phẩm";
            // 
            // QL_Product
            // 
            this.QL_Product.Name = "QL_Product";
            this.QL_Product.Size = new System.Drawing.Size(170, 22);
            this.QL_Product.Text = "Quản lý sản phẩm";
            this.QL_Product.Click += new System.EventHandler(this.listProduct_Click);
            // 
            // QL_ProductCategory
            // 
            this.QL_ProductCategory.Name = "QL_ProductCategory";
            this.QL_ProductCategory.Size = new System.Drawing.Size(170, 22);
            this.QL_ProductCategory.Text = "QL loại sản phẩm";
            this.QL_ProductCategory.Click += new System.EventHandler(this.productCategory_Click);
            // 
            // menuOrder
            // 
            this.menuOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QL_Order});
            this.menuOrder.Name = "menuOrder";
            this.menuOrder.Size = new System.Drawing.Size(69, 20);
            this.menuOrder.Text = "Bán hàng";
            // 
            // QL_Order
            // 
            this.QL_Order.Name = "QL_Order";
            this.QL_Order.Size = new System.Drawing.Size(169, 22);
            this.QL_Order.Text = "Quản lý đơn hàng";
            this.QL_Order.Click += new System.EventHandler(this.orderList_Click);
            // 
            // menuStorage
            // 
            this.menuStorage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QL_Storage,
            this.QL_Supplier});
            this.menuStorage.Name = "menuStorage";
            this.menuStorage.Size = new System.Drawing.Size(70, 20);
            this.menuStorage.Text = "Kho hàng";
            // 
            // QL_Storage
            // 
            this.QL_Storage.Name = "QL_Storage";
            this.QL_Storage.Size = new System.Drawing.Size(190, 22);
            this.QL_Storage.Text = "Quản lý kho hàng";
            // 
            // QL_Supplier
            // 
            this.QL_Supplier.Name = "QL_Supplier";
            this.QL_Supplier.Size = new System.Drawing.Size(190, 22);
            this.QL_Supplier.Text = "Quản lý nhà cung cấp";
            // 
            // menuUser
            // 
            this.menuUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listUser});
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(84, 20);
            this.menuUser.Text = "Người Dùng";
            // 
            // listUser
            // 
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(180, 22);
            this.listUser.Text = "Quản lý người dùng";
            this.listUser.Click += new System.EventHandler(this.listUser_Click);
            // 
            // menuStat
            // 
            this.menuStat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStat.Name = "menuStat";
            this.menuStat.Size = new System.Drawing.Size(122, 20);
            this.menuStat.Text = "Tra cứu và thống kê";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbSuccess);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 97);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đơn hàng thành công";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(7, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đơn hàng giao dịch thành công";
            // 
            // lbSuccess
            // 
            this.lbSuccess.AutoSize = true;
            this.lbSuccess.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuccess.Location = new System.Drawing.Point(6, 26);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(54, 22);
            this.lbSuccess.TabIndex = 0;
            this.lbSuccess.Text = "2680";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbProcessing);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(240, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 97);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đơn hàng đang xử lý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng đơn hàng đang xử lý";
            // 
            // lbProcessing
            // 
            this.lbProcessing.AutoSize = true;
            this.lbProcessing.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessing.Location = new System.Drawing.Point(6, 26);
            this.lbProcessing.Name = "lbProcessing";
            this.lbProcessing.Size = new System.Drawing.Size(32, 22);
            this.lbProcessing.TabIndex = 1;
            this.lbProcessing.Text = "10";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lbEarned);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(467, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 97);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Doanh số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doanh số hệ thống";
            // 
            // lbEarned
            // 
            this.lbEarned.AutoSize = true;
            this.lbEarned.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEarned.Location = new System.Drawing.Point(6, 26);
            this.lbEarned.Name = "lbEarned";
            this.lbEarned.Size = new System.Drawing.Size(59, 22);
            this.lbEarned.TabIndex = 2;
            this.lbEarned.Text = "2.5 tỷ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lbCancel);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(694, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 97);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Đơn hàng bị hủy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số đơn bị hủy trong hệ thống";
            // 
            // lbCancel
            // 
            this.lbCancel.AutoSize = true;
            this.lbCancel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancel.Location = new System.Drawing.Point(6, 26);
            this.lbCancel.Name = "lbCancel";
            this.lbCancel.Size = new System.Drawing.Size(43, 22);
            this.lbCancel.TabIndex = 3;
            this.lbCancel.Text = "125";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ID,
            this.CustomerName,
            this.Product,
            this.Amount,
            this.Price,
            this.Status,
            this.DateCreate});
            this.dgvOrderList.Location = new System.Drawing.Point(10, 19);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(888, 279);
            this.dgvOrderList.TabIndex = 4;
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
            this.CustomerName.Width = 135;
            // 
            // Product
            // 
            this.Product.HeaderText = "Sản phẩm";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 160;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Số lượng";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 80;
            // 
            // Price
            // 
            this.Price.HeaderText = "Giá trị";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
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
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Arial", 16F);
            this.lbWelcome.Location = new System.Drawing.Point(12, 24);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(237, 25);
            this.lbWelcome.TabIndex = 5;
            this.lbWelcome.Text = "Chào mừng, Username";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvOrderList);
            this.groupBox5.Location = new System.Drawing.Point(13, 155);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(905, 304);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Đơn hàng mới";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Arial", 16F);
            this.lbRole.Location = new System.Drawing.Point(783, 24);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(132, 25);
            this.lbRole.TabIndex = 7;
            this.lbRole.Text = "Quản trị viên";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 470);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuFeature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuFeature.ResumeLayout(false);
            this.menuFeature.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuFeature;
        private System.Windows.Forms.ToolStripMenuItem menuProduct;
        private System.Windows.Forms.ToolStripMenuItem QL_Product;
        private System.Windows.Forms.ToolStripMenuItem QL_ProductCategory;
        private System.Windows.Forms.ToolStripMenuItem menuOrder;
        private System.Windows.Forms.ToolStripMenuItem QL_Order;
        private System.Windows.Forms.ToolStripMenuItem menuUser;
        private System.Windows.Forms.ToolStripMenuItem listUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbSuccess;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProcessing;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbEarned;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreate;
        private System.Windows.Forms.ToolStripMenuItem menuStorage;
        private System.Windows.Forms.ToolStripMenuItem QL_Storage;
        private System.Windows.Forms.ToolStripMenuItem QL_Supplier;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuStat;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.Label lbRole;
    }
}