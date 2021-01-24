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
using The2000s.ManageForm.FormSearchStat.Class;
using The2000s.ManageForm.FormSearchStat.Report;
using The2000s.Models;

namespace The2000s.ManageForm.FormSearchStat
{
    public partial class frmStatProfit : Form
    {
        DB_Context context = new DB_Context();
        public frmStatProfit()
        {
            InitializeComponent();
        }
        private string ShortNumber(int num)
        {
            if (num >= 0)
            {
                if (num > 1000000000)
                {
                    return ((double)num / 1000000000).ToString("N1", CultureInfo.InvariantCulture) + " tỷ";
                }
                else if (num > 1000000)
                {
                    return ((double)num / 1000000).ToString("N1", CultureInfo.InvariantCulture) + " triệu";
                }
                else
                {
                    return num.ToString("N0", CultureInfo.InvariantCulture);
                }
            }
            else
            {
                if (num < -1000000000)
                {
                    return ((double)num / 1000000000).ToString("N1", CultureInfo.InvariantCulture) + " tỷ";
                }
                else if (num < -1000000)
                {
                    return ((double)num / 1000000).ToString("N1", CultureInfo.InvariantCulture) + " triệu";
                }
                else
                {
                    return num.ToString("N0", CultureInfo.InvariantCulture);
                }
            }
        }
        private void frmStatProfit_Load(object sender, EventArgs e)
        {
            dtpMonth.CustomFormat = "MM/yyyy";
            dtpQYear.CustomFormat = "yyyy";
            dtpYear.CustomFormat = "yyyy";

            optMonth.Checked = true;
            numQuarter.Enabled = false;
            dtpQYear.Enabled = false;
            dtpYear.Enabled = false;

            //===============================================================================
            dgvOrderList.Rows.Clear();
            foreach (Order o in context.Orders)
            {
                if (o.Status == 1)
                {
                    int total = 0;
                    foreach (OrderDetail od in context.OrderDetails)
                    {
                        if (od.OrderID == o.OrderID)
                        {
                            total += Convert.ToInt32(od.Amount * od.Product.Price);
                        }

                    }
                    int i = dgvOrderList.Rows.Add();
                    dgvOrderList.Rows[i].Cells[0].Value = i + 1;
                    dgvOrderList.Rows[i].Cells[1].Value = o.OrderID;
                    dgvOrderList.Rows[i].Cells[2].Value = o.Customer.CustomerName;
                    dgvOrderList.Rows[i].Cells[3].Value = total;
                    dgvOrderList.Rows[i].Cells[4].Value = o.CreatedAt;
                }
            }
            //=================================================================================
            int soldValue = 0;
            foreach (OrderDetail od in context.OrderDetails)
            {
                if (od.Order.Status == 1)
                {
                    soldValue += Convert.ToInt32(od.Amount * od.Product.Price);
                }
            }
            int boughtValue = 0;
            foreach (ImportProductDetail ipd in context.ImportProductDetails)
            {
                boughtValue += Convert.ToInt32(ipd.Amount * ipd.BuyPrice);
            }
            lbIn.Text = ShortNumber(soldValue);
            lbOut.Text = ShortNumber(boughtValue);
            lbEarned.Text = ShortNumber(soldValue - boughtValue);
            //==================================================================================
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

        private void btnStat_Click(object sender, EventArgs e)
        {
            dgvOrderList.Rows.Clear();
            if (optMonth.Checked == true)
            {
                DateTime st = new DateTime(dtpMonth.Value.Year, dtpMonth.Value.Month, 01);
                DateTime en = new DateTime(dtpMonth.Value.Year, dtpMonth.Value.Month, DateTime.DaysInMonth(dtpMonth.Value.Year, dtpMonth.Value.Month));
                foreach (Order o in context.Orders)
                {
                    if (o.Status == 1 && DateTime.Compare(Convert.ToDateTime(o.CreatedAt), st) >= 0 && DateTime.Compare(Convert.ToDateTime(o.CreatedAt), en) <= 0)
                    {
                        int total = 0;
                        foreach (OrderDetail od in context.OrderDetails)
                        {
                            if (od.OrderID == o.OrderID)
                            {
                                total += Convert.ToInt32(od.Amount * od.Product.Price);
                            }
                        }
                        int i = dgvOrderList.Rows.Add();
                        dgvOrderList.Rows[i].Cells[0].Value = i + 1;
                        dgvOrderList.Rows[i].Cells[1].Value = o.OrderID;
                        dgvOrderList.Rows[i].Cells[2].Value = o.Customer.CustomerName;
                        dgvOrderList.Rows[i].Cells[3].Value = total;
                        dgvOrderList.Rows[i].Cells[4].Value = o.CreatedAt;
                    }
                }
            }
            else if (optQuarter.Checked == true)
            {
                int quarst = (Convert.ToInt32(numQuarter.Value) * 3) - 2;
                int quaren = (Convert.ToInt32(numQuarter.Value) * 3);
                DateTime st = new DateTime(dtpQYear.Value.Year, quarst, 01);
                DateTime en = new DateTime(dtpQYear.Value.Year, quaren, DateTime.DaysInMonth(dtpQYear.Value.Year, quaren));
                foreach (Order o in context.Orders)
                {
                    if (o.Status == 1 && DateTime.Compare(Convert.ToDateTime(o.CreatedAt), st) >= 0 && DateTime.Compare(Convert.ToDateTime(o.CreatedAt), en) <= 0)
                    {
                        int total = 0;
                        foreach (OrderDetail od in context.OrderDetails)
                        {
                            if (od.OrderID == o.OrderID)
                            {
                                total += Convert.ToInt32(od.Amount * od.Product.Price);
                            }
                        }
                        int i = dgvOrderList.Rows.Add();
                        dgvOrderList.Rows[i].Cells[0].Value = i + 1;
                        dgvOrderList.Rows[i].Cells[1].Value = o.OrderID;
                        dgvOrderList.Rows[i].Cells[2].Value = o.Customer.CustomerName;
                        dgvOrderList.Rows[i].Cells[3].Value = total;
                        dgvOrderList.Rows[i].Cells[4].Value = o.CreatedAt;
                    }
                }
            }
            else
            {
                foreach (Order o in context.Orders)
                {
                    if (o.Status == 1 && Convert.ToDateTime(o.CreatedAt).Year == dtpYear.Value.Year)
                    {
                        int total = 0;
                        foreach (OrderDetail od in context.OrderDetails)
                        {
                            if (od.OrderID == o.OrderID)
                            {
                                total += Convert.ToInt32(od.Amount * od.Product.Price);
                            }
                        }
                        int i = dgvOrderList.Rows.Add();
                        dgvOrderList.Rows[i].Cells[0].Value = i + 1;
                        dgvOrderList.Rows[i].Cells[1].Value = o.OrderID;
                        dgvOrderList.Rows[i].Cells[2].Value = o.Customer.CustomerName;
                        dgvOrderList.Rows[i].Cells[3].Value = total;
                        dgvOrderList.Rows[i].Cells[4].Value = o.CreatedAt;
                    }

                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string DateStr;
            if (optMonth.Checked == true)
            {
                DateStr = "Tháng " + dtpMonth.Value.ToString("MM/yyyy");
                btnStat.PerformClick();
                List<ProfitReport> list = new List<ProfitReport>();
                foreach (DataGridViewRow row in dgvOrderList.Rows)
                {
                    ProfitReport pr = new ProfitReport()
                    {
                        OrderID = Convert.ToInt32(row.Cells[1].Value),
                        CustomerName = row.Cells[2].Value.ToString(),
                        Total = Convert.ToInt32(row.Cells[3].Value),
                        CreateDate = Convert.ToDateTime(row.Cells[4].Value)
                    };
                    list.Add(pr);
                }
                frmReportProfit rfit = new frmReportProfit(list, DateStr);
                rfit.ShowDialog();
            }
            else if (optQuarter.Checked == true)
            {
                DateStr = "Quý " + numQuarter.Value.ToString() + "/" + dtpQYear.Value.Year;
                btnStat.PerformClick();
                List<ProfitReport> list = new List<ProfitReport>();
                foreach (DataGridViewRow row in dgvOrderList.Rows)
                {
                    ProfitReport pr = new ProfitReport()
                    {
                        OrderID = Convert.ToInt32(row.Cells[1].Value),
                        CustomerName = row.Cells[2].Value.ToString(),
                        Total = Convert.ToInt32(row.Cells[3].Value),
                        CreateDate = Convert.ToDateTime(row.Cells[4].Value)
                    };
                    list.Add(pr);
                }
                frmReportProfit rfit = new frmReportProfit(list, DateStr);
                rfit.ShowDialog();
            }
            else
            {
                DateStr = "Năm " + dtpYear.Value.Year;
                btnStat.PerformClick();
                List<ProfitReport> list = new List<ProfitReport>();
                foreach (DataGridViewRow row in dgvOrderList.Rows)
                {
                    ProfitReport pr = new ProfitReport()
                    {
                        OrderID = Convert.ToInt32(row.Cells[1].Value),
                        CustomerName = row.Cells[2].Value.ToString(),
                        Total = Convert.ToInt32(row.Cells[3].Value),
                        CreateDate = Convert.ToDateTime(row.Cells[4].Value)
                    };
                    list.Add(pr);
                }
                frmReportProfit rfit = new frmReportProfit(list, DateStr);
                rfit.ShowDialog();
            }
        }

        private void btnReportAll_Click(object sender, EventArgs e)
        {
            string DateStr = "Tất cả";

            dgvOrderList.Rows.Clear();
            foreach (Order o in context.Orders)
            {
                if (o.Status == 1)
                {
                    int total = 0;
                    foreach (OrderDetail od in context.OrderDetails)
                    {
                        if (od.OrderID == o.OrderID)
                        {
                            total += Convert.ToInt32(od.Amount * od.Product.Price);
                        }

                    }
                    int i = dgvOrderList.Rows.Add();
                    dgvOrderList.Rows[i].Cells[0].Value = i + 1;
                    dgvOrderList.Rows[i].Cells[1].Value = o.OrderID;
                    dgvOrderList.Rows[i].Cells[2].Value = o.Customer.CustomerName;
                    dgvOrderList.Rows[i].Cells[3].Value = total;
                    dgvOrderList.Rows[i].Cells[4].Value = o.CreatedAt;
                }
            }

            List<ProfitReport> list = new List<ProfitReport>();
            foreach (DataGridViewRow row in dgvOrderList.Rows)
            {
                ProfitReport pr = new ProfitReport()
                {
                    OrderID = Convert.ToInt32(row.Cells[1].Value),
                    CustomerName = row.Cells[2].Value.ToString(),
                    Total = Convert.ToInt32(row.Cells[3].Value),
                    CreateDate = Convert.ToDateTime(row.Cells[4].Value)
                };
                list.Add(pr);
            }
            frmReportProfit rfit = new frmReportProfit(list, DateStr);
            rfit.ShowDialog();
        }
    }
}
