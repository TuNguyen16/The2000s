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

namespace The2000s.ManageForm.FormSearchStat
{
    public partial class frmSearchProduct : Form
    {
        DB_Context context = new DB_Context();
        public frmSearchProduct()
        {
            InitializeComponent();
        }

        private void frmSearchProduct_Load(object sender, EventArgs e)
        {
            optName.Checked = true;
            txtPriceS.Enabled = false;
            txtPriceE.Enabled = false;
            cbType.Enabled = false;
        }

        private void optName_CheckedChanged(object sender, EventArgs e)
        {
            if (optName.Checked == true)
            {
                txtName.Enabled = true;
            }
            else
            {
                txtName.Enabled = false;
            }
        }

        private void optType_CheckedChanged(object sender, EventArgs e)
        {
            if (optType.Checked == true)
            {
                cbType.Enabled = true;
            }
            else
            {
                cbType.Enabled = false;
            }
        }

        private void optPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (optPrice.Checked == true)
            {
                txtPriceS.Enabled = true;
                txtPriceE.Enabled = true;
            }
            else
            {
                txtPriceS.Enabled = false;
                txtPriceE.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (optName.Checked == true)
            {
                dgvResult.Rows.Clear();
                List<Product> lpro = context.Products.Where(p => p.ProductName == txtName.Text).ToList();
                foreach (Product item in lpro)
                {
                    int i = dgvResult.Rows.Add();
                    dgvResult.Rows[i].Cells[0].Value = i + 1;
                    dgvResult.Rows[i].Cells[1].Value = item.ProductID;
                    dgvResult.Rows[i].Cells[2].Value = item.ProductName;
                    dgvResult.Rows[i].Cells[3].Value = item.ProductCategory.CatName;
                    dgvResult.Rows[i].Cells[4].Value = item.Price;
                    dgvResult.Rows[i].Cells[5].Value = item.CreatedAt;
                    dgvResult.Rows[i].Cells[6].Value = (item.Status == 0) ? "Công khai" : "Ngừng bán";
                }
            }
            else if (optType.Checked == true)
            {
                dgvResult.Rows.Clear();
                int id = Convert.ToInt32(cbType.SelectedValue);
                List<Product> lpro = context.Products.Where(p => p.CatID == id).ToList();
                foreach (Product item in lpro)
                {
                    int i = dgvResult.Rows.Add();
                    dgvResult.Rows[i].Cells[0].Value = i + 1;
                    dgvResult.Rows[i].Cells[1].Value = item.ProductID;
                    dgvResult.Rows[i].Cells[2].Value = item.ProductName;
                    dgvResult.Rows[i].Cells[3].Value = item.ProductCategory.CatName;
                    dgvResult.Rows[i].Cells[4].Value = item.Price;
                    dgvResult.Rows[i].Cells[5].Value = item.CreatedAt;
                    dgvResult.Rows[i].Cells[6].Value = (item.Status == 0) ? "Công khai" : "Ngừng bán";
                }
            }
            else
            {
                try
                {
                    dgvResult.Rows.Clear();
                    if (txtPriceS.Text != "" && txtPriceE.Text != "")
                    {
                        int start = Convert.ToInt32(txtPriceS.Text);
                        int end = Convert.ToInt32(txtPriceE.Text);
                        if (start >= end)
                        {
                            txtPriceS.Text = end.ToString();
                            throw new Exception("Giá bắt đầu không được lớn hơn giá kết thúc");
                        }
                        List<Product> lpro = context.Products.Where(p => p.Price >= start && p.Price <= end).ToList();
                        foreach (Product item in lpro)
                        {
                            int i = dgvResult.Rows.Add();
                            dgvResult.Rows[i].Cells[0].Value = i + 1;
                            dgvResult.Rows[i].Cells[1].Value = item.ProductID;
                            dgvResult.Rows[i].Cells[2].Value = item.ProductName;
                            dgvResult.Rows[i].Cells[3].Value = item.ProductCategory.CatName;
                            dgvResult.Rows[i].Cells[4].Value = item.Price;
                            dgvResult.Rows[i].Cells[5].Value = item.CreatedAt;
                            dgvResult.Rows[i].Cells[6].Value = (item.Status == 0) ? "Công khai" : "Ngừng bán";
                        }
                    }
                    else
                    {
                        throw new Exception("Giá bắt đầu và kết thúc không được để trống");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
