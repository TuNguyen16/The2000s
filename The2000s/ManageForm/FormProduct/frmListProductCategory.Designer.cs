
namespace The2000s.ManageForm.FormProduct
{
    partial class frmListProductCategory
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
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckIsParent = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.cbParentCat = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCategoryList = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCatID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ckIsParent);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtCatName);
            this.groupBox1.Controls.Add(this.cbParentCat);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 8F);
            this.groupBox1.Location = new System.Drawing.Point(379, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtCatID
            // 
            this.txtCatID.Location = new System.Drawing.Point(98, 24);
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(156, 22);
            this.txtCatID.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã loại";
            // 
            // ckIsParent
            // 
            this.ckIsParent.AutoSize = true;
            this.ckIsParent.Location = new System.Drawing.Point(70, 103);
            this.ckIsParent.Name = "ckIsParent";
            this.ckIsParent.Size = new System.Drawing.Size(123, 19);
            this.ckIsParent.TabIndex = 11;
            this.ckIsParent.Text = "Là loại cấp cha gốc";
            this.ckIsParent.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(179, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(98, 50);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(156, 22);
            this.txtCatName.TabIndex = 7;
            // 
            // cbParentCat
            // 
            this.cbParentCat.FormattingEnabled = true;
            this.cbParentCat.Location = new System.Drawing.Point(98, 76);
            this.cbParentCat.Name = "cbParentCat";
            this.cbParentCat.Size = new System.Drawing.Size(156, 23);
            this.cbParentCat.TabIndex = 3;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(100, 126);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại cấp cha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên loại";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCategoryList);
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 8F);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 475);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgvCategoryList
            // 
            this.dgvCategoryList.AllowUserToAddRows = false;
            this.dgvCategoryList.AllowUserToDeleteRows = false;
            this.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.CatName,
            this.ParentCatName,
            this.catid,
            this.parentid});
            this.dgvCategoryList.Location = new System.Drawing.Point(6, 19);
            this.dgvCategoryList.Name = "dgvCategoryList";
            this.dgvCategoryList.ReadOnly = true;
            this.dgvCategoryList.Size = new System.Drawing.Size(345, 450);
            this.dgvCategoryList.TabIndex = 0;
            this.dgvCategoryList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoryList_CellClick);
            // 
            // No
            // 
            this.No.HeaderText = "#";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 30;
            // 
            // CatName
            // 
            this.CatName.HeaderText = "Tên danh mục";
            this.CatName.Name = "CatName";
            this.CatName.ReadOnly = true;
            this.CatName.Width = 135;
            // 
            // ParentCatName
            // 
            this.ParentCatName.HeaderText = "Tên danh mục cha";
            this.ParentCatName.Name = "ParentCatName";
            this.ParentCatName.ReadOnly = true;
            this.ParentCatName.Width = 135;
            // 
            // catid
            // 
            this.catid.HeaderText = "catid";
            this.catid.Name = "catid";
            this.catid.ReadOnly = true;
            this.catid.Visible = false;
            // 
            // parentid
            // 
            this.parentid.HeaderText = "parentid";
            this.parentid.Name = "parentid";
            this.parentid.ReadOnly = true;
            this.parentid.Visible = false;
            // 
            // frmListProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmListProductCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại sản phẩm";
            this.Load += new System.EventHandler(this.frmListProductCategory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.ComboBox cbParentCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCategoryList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtCatID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckIsParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentCatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn catid;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentid;
    }
}