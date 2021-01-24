using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The2000s.Models;

namespace The2000s.ManageForm.FormStorage
{
    public partial class frmImportStorage : Form
    {
        DB_Context context = new DB_Context();
        public frmImportStorage()
        {
            InitializeComponent();
        }
        private void txtSupplierID_TextChanged(object sender, EventArgs e)
        {
            if (txtSupplierID.Text != "")
            {
                int supid = Convert.ToInt32(txtSupplierID.Text);
                Supplier sup = context.Suppliers.FirstOrDefault(p => p.SupplierID == supid);
                if (sup != null)
                {
                    txtSupplierName.Text = sup.SupplierName;
                }
                else
                {
                    txtSupplierName.Text = "";
                }
            }
            else
            {
                txtSupplierName.Text = "";
            }
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {
                int pid = Convert.ToInt32(txtProductID.Text);
                Product product = context.Products.FirstOrDefault(p => p.ProductID == pid);
                if (product != null)
                {
                    txtProductName.Text = product.ProductName;
                }
                else
                {
                    txtProductName.Text = "";
                }
            }
            else
            {
                txtProductName.Text = "";
            }
        }
        private void AddToGrid(Product p)
        {
            int i = dgvProductList.Rows.Add();
            dgvProductList.Rows[i].Cells[0].Value = i + 1;
            dgvProductList.Rows[i].Cells[1].Value = p.ProductID;
            dgvProductList.Rows[i].Cells[2].Value = p.ProductName;
            dgvProductList.Rows[i].Cells[3].Value = txtAmount.Text;
            dgvProductList.Rows[i].Cells[4].Value = txtBuyPrice.Text;
            int amount = Convert.ToInt32(txtAmount.Text);
            int buyprice = Convert.ToInt32(txtBuyPrice.Text);
            dgvProductList.Rows[i].Cells[5].Value = (amount * buyprice);
        }
        private void CalcTotalMoney()
        {
            int totalMoney = 0;
            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                totalMoney += Convert.ToInt32(row.Cells[5].Value);
            }
            txtTotal.Text = totalMoney.ToString("C0", new CultureInfo("vi-VN", false));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierID.Text == "" || txtSupplierName.Text == "")
                {
                    throw new Exception("Thông tin nhà cung cấp chưa chính xác");
                }
                if (txtProductID.Text == "" || txtProductName.Text == "" || txtAmount.Text == "")
                {
                    throw new Exception("Thông tin sản phẩm chưa chính xác");
                }
                int pid = Convert.ToInt32(txtProductID.Text);
                Product tmp = context.Products.FirstOrDefault(p => p.ProductID == pid);
                foreach (DataGridViewRow row in dgvProductList.Rows)
                {
                    if (row.Cells[1].Value.ToString() == txtProductID.Text)
                    {

                        int cur = Convert.ToInt32(row.Cells[3].Value);
                        cur += Convert.ToInt32(txtAmount.Text);
                        row.Cells[3].Value = cur;
                        row.Cells[5].Value = cur * Convert.ToInt32(row.Cells[4].Value);
                        CalcTotalMoney();
                        return;
                    }
                }
                AddToGrid(tmp);
                CalcTotalMoney();
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
                int pid = Convert.ToInt32(txtProductID.Text);
                foreach (DataGridViewRow row in dgvProductList.Rows)
                {
                    if (row.Cells[1].Value.ToString() == txtProductID.Text)
                    {
                        dgvProductList.Rows.Remove(row);
                    }
                }
                CalcTotalMoney();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddImport_Click(object sender, EventArgs e)
        {
            try
            {
                ImportProduct ip = new ImportProduct()
                {
                    CreatedAt = DateTime.Now,
                    SupplierID = Convert.ToInt32(txtSupplierID.Text)
                };
                context.ImportProducts.Add(ip);
                context.SaveChanges();

                int iid = ip.ImportID;
                foreach (DataGridViewRow row in dgvProductList.Rows)
                {
                    ImportProductDetail ipd = new ImportProductDetail()
                    {
                        ImportID = iid,
                        Amount = Convert.ToInt32(row.Cells[3].Value),
                        ProductID = Convert.ToInt32(row.Cells[1].Value),
                        BuyPrice = Convert.ToInt32(txtBuyPrice.Text)
                    };
                    context.ImportProductDetails.Add(ipd);
                }
                context.SaveChanges();
                MessageBox.Show("Thêm đơn nhập hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtProductID.Text = dgvProductList.Rows[i].Cells[1].Value.ToString();
            txtProductName.Text = dgvProductList.Rows[i].Cells[2].Value.ToString();
            txtAmount.Text = dgvProductList.Rows[i].Cells[3].Value.ToString();
            txtBuyPrice.Text = dgvProductList.Rows[i].Cells[4].Value.ToString();
        }
    }
}
