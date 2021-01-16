
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCat = new System.Windows.Forms.TextBox();
            this.optPublic = new System.Windows.Forms.RadioButton();
            this.optPending = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParentCat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCategoryList = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtCat);
            this.groupBox1.Controls.Add(this.optPublic);
            this.groupBox1.Controls.Add(this.optPending);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtParentCat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 31);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtCat
            // 
            this.txtCat.Location = new System.Drawing.Point(110, 32);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(156, 20);
            this.txtCat.TabIndex = 7;
            // 
            // optPublic
            // 
            this.optPublic.AutoSize = true;
            this.optPublic.Location = new System.Drawing.Point(193, 93);
            this.optPublic.Name = "optPublic";
            this.optPublic.Size = new System.Drawing.Size(73, 17);
            this.optPublic.TabIndex = 6;
            this.optPublic.TabStop = true;
            this.optPublic.Text = "Công khai";
            this.optPublic.UseVisualStyleBackColor = true;
            // 
            // optPending
            // 
            this.optPending.AutoSize = true;
            this.optPending.Location = new System.Drawing.Point(110, 93);
            this.optPending.Name = "optPending";
            this.optPending.Size = new System.Drawing.Size(73, 17);
            this.optPending.TabIndex = 5;
            this.optPending.TabStop = true;
            this.optPending.Text = "Chờ duyệt";
            this.optPending.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Trạng thái";
            // 
            // txtParentCat
            // 
            this.txtParentCat.FormattingEnabled = true;
            this.txtParentCat.Location = new System.Drawing.Point(110, 61);
            this.txtParentCat.Name = "txtParentCat";
            this.txtParentCat.Size = new System.Drawing.Size(156, 21);
            this.txtParentCat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh mục cha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên danh mục";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCategoryList);
            this.groupBox2.Location = new System.Drawing.Point(292, 36);
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
            this.ParentCatName});
            this.dgvCategoryList.Location = new System.Drawing.Point(6, 19);
            this.dgvCategoryList.Name = "dgvCategoryList";
            this.dgvCategoryList.ReadOnly = true;
            this.dgvCategoryList.Size = new System.Drawing.Size(345, 450);
            this.dgvCategoryList.TabIndex = 0;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F);
            this.label4.Location = new System.Drawing.Point(220, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Danh mục sản phẩm";
            // 
            // frmListProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 523);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListProductCategory";
            this.Text = "Quản lý danh mục sản phẩm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.RadioButton optPublic;
        private System.Windows.Forms.RadioButton optPending;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtParentCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCategoryList;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentCatName;
        private System.Windows.Forms.Label label4;
    }
}