using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The2000s.ManageForm.FormSearchStat.Class;
using The2000s.ManageForm.FormSearchStat.Report;
using The2000s.Models;

namespace The2000s.ManageForm.FormSearchStat
{
    public partial class frmStatMostSell : Form
    {
        DB_Context context = new DB_Context();
        public frmStatMostSell()
        {
            InitializeComponent();
        }

        private void frmStatMostSell_Load(object sender, EventArgs e)
        {
            dtpMonth.CustomFormat = "MM/yyyy";
            dtpQYear.CustomFormat = "yyyy";
            dtpYear.CustomFormat = "yyyy";

            optMonth.Checked = true;
            numQuarter.Enabled = false;
            dtpQYear.Enabled = false;
            dtpYear.Enabled = false;
        }

        private void optMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (optMonth.Checked == true)
            {
                dtpMonth.Enabled = true;
            }
            else
            {
                dtpMonth.Enabled = false;
            }
        }

        private void optQuarter_CheckedChanged(object sender, EventArgs e)
        {
            if (optQuarter.Checked == true)
            {
                dtpQYear.Enabled = true;
                numQuarter.Enabled = true;
            }
            else
            {
                dtpQYear.Enabled = false;
                numQuarter.Enabled = false;
            }
        }

        private void optYear_CheckedChanged(object sender, EventArgs e)
        {
            if (optYear.Checked == true)
            {
                dtpYear.Enabled = true;
            }
            else
            {
                dtpYear.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCategory.Rows.Clear();
            dgvProduct.Rows.Clear();
            if (optMonth.Checked == true)
            {
                DateTime st = new DateTime(dtpMonth.Value.Year, dtpMonth.Value.Month, 01);
                DateTime en = new DateTime(dtpMonth.Value.Year, dtpMonth.Value.Month, DateTime.DaysInMonth(dtpMonth.Value.Year, dtpMonth.Value.Month));
                foreach (Product pro in context.Products)
                {
                    int sumP = Convert.ToInt32(context.OrderDetails.AsEnumerable().Where(p => p.ProductID == pro.ProductID && p.Order.Status == 1 && DateTime.Compare(Convert.ToDateTime(p.Order.CreatedAt), st) >= 0 && DateTime.Compare(Convert.ToDateTime(p.Order.CreatedAt), en) <= 0).Sum(p => p.Amount));
                    int i = dgvProduct.Rows.Add();
                    dgvProduct.Rows[i].Cells[0].Value = 0;
                    dgvProduct.Rows[i].Cells[1].Value = pro.ProductID;
                    dgvProduct.Rows[i].Cells[2].Value = pro.ProductName;
                    dgvProduct.Rows[i].Cells[3].Value = sumP;
                }
                foreach (ProductCategory pc in context.ProductCategories)
                {
                    int sumPC = Convert.ToInt32(context.OrderDetails.AsEnumerable().Where(p => p.Product.ProductCategory.CatID == pc.CatID && p.Order.Status == 1 && DateTime.Compare(Convert.ToDateTime(p.Order.CreatedAt), st) >= 0 && DateTime.Compare(Convert.ToDateTime(p.Order.CreatedAt), en) <= 0).Sum(p => p.Amount));
                    int i = dgvCategory.Rows.Add();
                    dgvCategory.Rows[i].Cells[0].Value = 0;
                    dgvCategory.Rows[i].Cells[1].Value = pc.CatID;
                    dgvCategory.Rows[i].Cells[2].Value = pc.CatName;
                    dgvCategory.Rows[i].Cells[3].Value = sumPC;
                }
                dgvCategory.Sort(dgvCategory.Columns["Column8"], ListSortDirection.Descending);
                dgvProduct.Sort(dgvProduct.Columns["Column4"], ListSortDirection.Descending);
                int j = 1;
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    row.Cells[0].Value = j;
                    j++;
                }
                int k = 1;
                foreach (DataGridViewRow row in dgvCategory.Rows)
                {
                    row.Cells[0].Value = k;
                    k++;
                }
            }
            else if (optQuarter.Checked == true)
            {
                int quarst = (Convert.ToInt32(numQuarter.Value) * 3) - 2;
                int quaren = (Convert.ToInt32(numQuarter.Value) * 3);
                DateTime st = new DateTime(dtpQYear.Value.Year, quarst, 01);
                DateTime en = new DateTime(dtpQYear.Value.Year, quaren, DateTime.DaysInMonth(dtpQYear.Value.Year, quaren));
                foreach (Product pro in context.Products)
                {
                    int sumP = Convert.ToInt32(context.OrderDetails.AsEnumerable().Where(p => p.ProductID == pro.ProductID && p.Order.Status == 1 && DateTime.Compare(Convert.ToDateTime(p.Order.CreatedAt), st) >= 0 && DateTime.Compare(Convert.ToDateTime(p.Order.CreatedAt), en) <= 0).Sum(p => p.Amount));
                    int i = dgvProduct.Rows.Add();
                    dgvProduct.Rows[i].Cells[0].Value = 0;
                    dgvProduct.Rows[i].Cells[1].Value = pro.ProductID;
                    dgvProduct.Rows[i].Cells[2].Value = pro.ProductName;
                    dgvProduct.Rows[i].Cells[3].Value = sumP;
                }
                foreach (ProductCategory pc in context.ProductCategories)
                {
                    int sumPC = Convert.ToInt32(context.OrderDetails.AsEnumerable().Where(p => p.Product.ProductCategory.CatID == pc.CatID && p.Order.Status == 1 && DateTime.Compare(Convert.ToDateTime(p.Order.CreatedAt), st) >= 0 && DateTime.Compare(Convert.ToDateTime(p.Order.CreatedAt), en) <= 0).Sum(p => p.Amount));
                    int i = dgvCategory.Rows.Add();
                    dgvCategory.Rows[i].Cells[0].Value = 0;
                    dgvCategory.Rows[i].Cells[1].Value = pc.CatID;
                    dgvCategory.Rows[i].Cells[2].Value = pc.CatName;
                    dgvCategory.Rows[i].Cells[3].Value = sumPC;
                }
                dgvCategory.Sort(dgvCategory.Columns["Column8"], ListSortDirection.Descending);
                dgvProduct.Sort(dgvProduct.Columns["Column4"], ListSortDirection.Descending);
                int j = 1;
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    row.Cells[0].Value = j;
                    j++;
                }
                int k = 1;
                foreach (DataGridViewRow row in dgvCategory.Rows)
                {
                    row.Cells[0].Value = k;
                    k++;
                }
            }
            else
            {
                foreach (Product pro in context.Products)
                {
                    int sumP = Convert.ToInt32(context.OrderDetails.AsEnumerable().Where(p => p.ProductID == pro.ProductID && p.Order.Status == 1 && Convert.ToDateTime(p.Order.CreatedAt).Year == dtpYear.Value.Year).Sum(p => p.Amount));
                    int i = dgvProduct.Rows.Add();
                    dgvProduct.Rows[i].Cells[0].Value = 0;
                    dgvProduct.Rows[i].Cells[1].Value = pro.ProductID;
                    dgvProduct.Rows[i].Cells[2].Value = pro.ProductName;
                    dgvProduct.Rows[i].Cells[3].Value = sumP;
                }
                foreach (ProductCategory pc in context.ProductCategories)
                {
                    int sumPC = Convert.ToInt32(context.OrderDetails.AsEnumerable().Where(p => p.Product.ProductCategory.CatID == pc.CatID && p.Order.Status == 1 && Convert.ToDateTime(p.Order.CreatedAt).Year == dtpYear.Value.Year).Sum(p => p.Amount));
                    int i = dgvCategory.Rows.Add();
                    dgvCategory.Rows[i].Cells[0].Value = 0;
                    dgvCategory.Rows[i].Cells[1].Value = pc.CatID;
                    dgvCategory.Rows[i].Cells[2].Value = pc.CatName;
                    dgvCategory.Rows[i].Cells[3].Value = sumPC;
                }
                dgvCategory.Sort(dgvCategory.Columns["Column8"], ListSortDirection.Descending);
                dgvProduct.Sort(dgvProduct.Columns["Column4"], ListSortDirection.Descending);
                int j = 1;
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    row.Cells[0].Value = j;
                    j++;
                }
                int k = 1;
                foreach (DataGridViewRow row in dgvCategory.Rows)
                {
                    row.Cells[0].Value = k;
                    k++;
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string DateStr;
            if (optMonth.Checked == true)
            {
                DateStr = "Tháng " + dtpMonth.Value.ToString("MM/yyyy");
                btnSearch.PerformClick();
                List<ProductReport> list = new List<ProductReport>();
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    ProductReport pr = new ProductReport()
                    {
                        ProductID = Convert.ToInt32(row.Cells[1].Value),
                        ProductName = row.Cells[2].Value.ToString(),
                        Amount = Convert.ToInt32(row.Cells[3].Value)
                    };
                    list.Add(pr);
                }
                frmReportMostSell rmost = new frmReportMostSell(list,DateStr);
                rmost.ShowDialog();
            }
            else if(optQuarter.Checked == true)
            {
                DateStr = "Quý " + numQuarter.Value.ToString() + "/" + dtpQYear.Value.Year;
                btnSearch.PerformClick();
                List<ProductReport> list = new List<ProductReport>();
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    ProductReport pr = new ProductReport()
                    {
                        ProductID = Convert.ToInt32(row.Cells[1].Value),
                        ProductName = row.Cells[2].Value.ToString(),
                        Amount = Convert.ToInt32(row.Cells[3].Value)
                    };
                    list.Add(pr);
                }
                frmReportMostSell rmost = new frmReportMostSell(list, DateStr);
                rmost.ShowDialog();
            }
            else
            {
                DateStr = "Năm " + dtpYear.Value.Year;
                btnSearch.PerformClick();
                List<ProductReport> list = new List<ProductReport>();
                foreach (DataGridViewRow row in dgvProduct.Rows)
                {
                    ProductReport pr = new ProductReport()
                    {
                        ProductID = Convert.ToInt32(row.Cells[1].Value),
                        ProductName = row.Cells[2].Value.ToString(),
                        Amount = Convert.ToInt32(row.Cells[3].Value)
                    };
                    list.Add(pr);
                }
                frmReportMostSell rmost = new frmReportMostSell(list, DateStr);
                rmost.ShowDialog();
            }
        }
    }
}
