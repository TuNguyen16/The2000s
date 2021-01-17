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
    public partial class frmListProduct : Form
    {
        DB_Context context = new DB_Context();
        public int userid { get; set; }
        public frmListProduct(int uid)
        {
            InitializeComponent();
            userid = uid;
        }
        private void LoadGrid()
        {
            dgvProductList.Rows.Clear();
            int total = 0;
            foreach (Product p in context.Products)
            {
                int i = dgvProductList.Rows.Add();
                dgvProductList.Rows[i].Cells[0].Value = i + 1;
                dgvProductList.Rows[i].Cells[1].Value = p.ProductID;
                dgvProductList.Rows[i].Cells[2].Value = p.ProductName;
                dgvProductList.Rows[i].Cells[3].Value = p.Price;
                dgvProductList.Rows[i].Cells[4].Value = p.ProductCategory.CatName;
                dgvProductList.Rows[i].Cells[5].Value = p.CreatedAt;
                dgvProductList.Rows[i].Cells[6].Value = (p.Status == 0) ? "Công khai" : "Ngừng bán" ;
                dgvProductList.Rows[i].Cells[7].Value = p.CatID;
                dgvProductList.Rows[i].Cells[8].Value = p.Status;
                total++;
            }
            txtTotal.Text = total.ToString();
        }
        private void ResetValue()
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtCreatedAt.Text = "";
            txtCreatedBy.Text = "";
            cbProductCategory.SelectedIndex = 0;
            optPublic.Checked = true;
        }

        private void frmListProduct_Load(object sender, EventArgs e)
        {
            //Load thông tin vào DataGrid
            LoadGrid();
            //Load thành phần vào ComboBox
            List<ProductCategory> productCategories = context.ProductCategories.ToList();
            cbProductCategory.DataSource = productCategories;
            cbProductCategory.ValueMember = "CatID";
            cbProductCategory.DisplayMember = "CatName";
            //Mặc định là công khai
            optPublic.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == "" || txtPrice.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                Product tmp = new Product()
                {
                    ProductName = txtProductName.Text,
                    CatID = (int)cbProductCategory.SelectedValue,
                    Price = Convert.ToInt32(txtPrice.Text),
                    CreatedAt = DateTime.Now,
                    CreatedBy = userid,
                    Status = optPublic.Checked == true ? 0 : 1
                };
                context.Products.Add(tmp);
                context.SaveChanges();
                LoadGrid();
                ResetValue();
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
                if (txtProductID.Text == "")
                {
                    throw new Exception("Vui lòng nhập mã sản phẩm cần sửa");
                }
                if (txtProductName.Text == "" || txtPrice.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                int epid = Convert.ToInt32(txtProductID.Text);
                Product edit = context.Products.FirstOrDefault(p => p.ProductID == epid);
                if (edit != null)
                {
                    edit.ProductName = txtProductName.Text;
                    edit.CatID = Convert.ToInt32(cbProductCategory.SelectedValue);
                    edit.Price = Convert.ToInt32(txtPrice.Text);
                    edit.Status = optPublic.Checked == true ? 0 : 1;
                }
                else
                {
                    throw new Exception("Không tìm thấy sản phẩm này");
                }
                context.SaveChanges();
                LoadGrid();
                ResetValue();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (txtProductID.Text == "")
                {
                    throw new Exception("Vui lòng nhập mã sản phẩm cần xóa");
                }
                int epid = Convert.ToInt32(txtProductID.Text);
                Product edit = context.Products.FirstOrDefault(p => p.ProductID == epid);
                if (edit != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm này không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        context.Products.Remove(edit);
                        context.SaveChanges();
                        LoadGrid();
                        ResetValue();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    throw new Exception("Không tìm thấy sản phẩm này");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang được xây dựng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtProductID.Text = dgvProductList.Rows[i].Cells[1].Value.ToString();
                txtProductName.Text = dgvProductList.Rows[i].Cells[2].Value.ToString();
                txtPrice.Text = dgvProductList.Rows[i].Cells[3].Value.ToString();
                cbProductCategory.SelectedValue = dgvProductList.Rows[i].Cells[7].Value;
                txtCreatedAt.Text = dgvProductList.Rows[i].Cells[5].Value.ToString();
                if (dgvProductList.Rows[i].Cells[6].Value.ToString() == "Công khai")
                {
                    optPublic.Checked = true;
                }
                else
                {
                    optStopSell.Checked = true;
                }
            }
            catch (ArgumentOutOfRangeException)
            { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
