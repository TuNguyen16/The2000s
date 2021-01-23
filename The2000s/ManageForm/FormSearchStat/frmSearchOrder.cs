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
    public partial class frmSearchOrder : Form
    {
        DB_Context context = new DB_Context();
        public frmSearchOrder()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvResult.Rows.Clear();
            List<Order> orders = context.Orders.Where(p => p.Customer.CustomerName == txtCustomer.Text).ToList();
            if (orders != null)
            {
                foreach (Order item in orders)
                {
                    int i = dgvResult.Rows.Add();
                    dgvResult.Rows[i].Cells[0].Value = i + 1;
                    dgvResult.Rows[i].Cells[1].Value = item.OrderID;
                    dgvResult.Rows[i].Cells[2].Value = item.Customer.CustomerName;
                    dgvResult.Rows[i].Cells[3].Value = (item.Status == 0) ? "Đang xử lý" : (item.Status == 1 ? "Đã giao hàng" : "Đã hủy đơn");
                    dgvResult.Rows[i].Cells[4].Value = item.CreatedAt;
                }
            }
        }
    }
}
