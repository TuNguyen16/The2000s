using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The2000s.Models;

namespace The2000s.ManageForm.FormProduct
{
    public partial class frmListProductCategory : Form
    {
        DB_Context context = new DB_Context();
        public frmListProductCategory()
        {
            InitializeComponent();


        }
        private void LoadGrid()
        {
            dgvCategoryList.Rows.Clear();
            foreach (ProductCategory cat in context.ProductCategories)
            {
                int i = dgvCategoryList.Rows.Add();
                dgvCategoryList.Rows[i].Cells[0].Value = i + 1;
                dgvCategoryList.Rows[i].Cells[1].Value = cat.CatName;
                if (cat.ParentID != 0)
                {
                    ProductCategory tmp = context.ProductCategories.FirstOrDefault(p => p.CatID == cat.ParentID);
                    dgvCategoryList.Rows[i].Cells[2].Value = tmp.CatName;
                }
                else
                {
                    dgvCategoryList.Rows[i].Cells[2].Value = "Loại cấp cha";
                }
                dgvCategoryList.Rows[i].Cells[3].Value = cat.CatID;
                dgvCategoryList.Rows[i].Cells[4].Value = cat.ParentID;

            }
        }
        private void ResetValue()
        {
            txtCatID.Text = "";
            txtCatName.Text = "";
            cbParentCat.SelectedIndex = 0;
            ckIsParent.Checked = false;
        }
        private void LoadCombobox()
        {
            List<ProductCategory> lcat = context.ProductCategories.ToList();
            cbParentCat.DataSource = lcat;
            cbParentCat.ValueMember = "CatID";
            cbParentCat.DisplayMember = "CatName";
        }
        private void frmListProductCategory_Load(object sender, EventArgs e)
        {
            LoadGrid();

            LoadCombobox();
        }
        private void dgvCategoryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtCatID.Text = dgvCategoryList.Rows[i].Cells[3].Value.ToString();
                txtCatName.Text = dgvCategoryList.Rows[i].Cells[1].Value.ToString();
                cbParentCat.SelectedValue = dgvCategoryList.Rows[i].Cells[4].Value;
                ckIsParent.Checked = dgvCategoryList.Rows[i].Cells[2].Value.ToString() == "Loại cấp cha" ? true : false;
            }
            catch (ArgumentOutOfRangeException)
            {  }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCatName.Text == "")
                {
                    throw new Exception("Vui lòng nhập tên loại sản phẩm");
                }
                if (ckIsParent.Checked == true)
                {
                    ProductCategory pc = new ProductCategory()
                    {
                        CatName = txtCatName.Text,
                        ParentID = 0
                    };
                    context.ProductCategories.Add(pc);
                }
                else
                {
                    if (cbParentCat.Text == "")
                    {
                        throw new Exception("Vui lòng chọn loại cấp cha");
                    }
                    ProductCategory pc = new ProductCategory()
                    {
                        CatName = txtCatName.Text,
                        ParentID = Convert.ToInt32(cbParentCat.SelectedValue)
                    };
                    context.ProductCategories.Add(pc);
                }
                context.SaveChanges();
                LoadGrid();
                ResetValue();
                LoadCombobox();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCatID.Text == "")
                {
                    throw new Exception("Vui lòng nhập mã loại cần sửa");
                }
                if (txtCatName.Text == "")
                {
                    throw new Exception("Vui lòng nhập tên loại sản phẩm");
                }
                int cid = Convert.ToInt32(txtCatID.Text);
                ProductCategory edit = context.ProductCategories.FirstOrDefault(p => p.CatID == cid);
                if (edit != null)
                {
                    edit.CatName = txtCatName.Text;
                    if (ckIsParent.Checked == true)
                    {
                        edit.ParentID = 0;
                    }
                    else
                    {
                        if (cbParentCat.Text == "")
                        {
                            throw new Exception("Vui lòng chọn loại cấp cha");
                        }
                        else
                        {
                            edit.ParentID = Convert.ToInt32(cbParentCat.SelectedValue);
                        }
                    }
                    context.SaveChanges();
                    LoadGrid();
                    ResetValue();
                    LoadCombobox();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Không tìm thấy loại sản phẩm này");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCatID.Text == "")
                {
                    throw new Exception("Vui lòng nhập mã loại cần xóa");
                }
                int cid = Convert.ToInt32(txtCatID.Text);
                ProductCategory edit = context.ProductCategories.FirstOrDefault(p => p.CatID == cid);
                if (edit != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa người dùng này không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        context.ProductCategories.Remove(edit);
                        context.SaveChanges();
                        LoadGrid();
                        ResetValue();
                        LoadCombobox();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    throw new Exception("Không tìm thấy loại sản phẩm này");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
