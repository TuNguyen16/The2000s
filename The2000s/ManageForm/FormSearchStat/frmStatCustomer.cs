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
    public partial class frmStatCustomer : Form
    {
        DB_Context context = new DB_Context();
        public frmStatCustomer()
        {
            InitializeComponent();
        }

        private void frmStatCustomer_Load(object sender, EventArgs e)
        {
            dgvList.Rows.Clear();
            foreach (Customer cus in context.Customers)
            {
                int total = 0;
                foreach (OrderDetail od in context.OrderDetails)
                {
                    if (od.Order.CustomerID == cus.CustomerID)
                    {
                        total += Convert.ToInt32(od.Amount * od.Product.Price);
                    }
                }
                if (total >= 2000000)
                {
                    int i = dgvList.Rows.Add();
                    dgvList.Rows[i].Cells[0].Value = 0;
                    dgvList.Rows[i].Cells[1].Value = cus.CustomerID;
                    dgvList.Rows[i].Cells[2].Value = cus.CustomerName;
                    dgvList.Rows[i].Cells[3].Value = context.Orders.Where(p => p.CustomerID == cus.CustomerID && p.Status == 1).Count();
                    dgvList.Rows[i].Cells[4].Value = total;
                }
            }
            int j = 1;
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                row.Cells[0].Value = j;
                j++;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            List<CustomerReport> list = new List<CustomerReport>();
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                CustomerReport cus = new CustomerReport()
                {
                    CustomerID = Convert.ToInt32(row.Cells[1].Value),
                    CustomerName = row.Cells[2].Value.ToString(),
                    Amount = Convert.ToInt32(row.Cells[3].Value),
                    Total = Convert.ToInt32(row.Cells[4].Value)
                };
                list.Add(cus);
            }
            frmReportCustomer rcus = new frmReportCustomer(list);
            rcus.ShowDialog();
        }
    }
}
