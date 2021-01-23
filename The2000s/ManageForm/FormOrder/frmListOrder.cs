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

namespace The2000s.ManageForm.FormOrder
{
    public partial class frmListOrder : Form
    {
        DB_Context context = new DB_Context();
        public int userid { get; set; }
        public frmListOrder(int uid)
        {
            InitializeComponent();
            userid = uid;
        }
        private void LoadGrid()
        {
            dgvOrderList.Rows.Clear();
            int total = 0;
            foreach (Order o in context.Orders)
            {
                int i = dgvOrderList.Rows.Add();
                dgvOrderList.Rows[i].Cells[0].Value = i + 1;
                dgvOrderList.Rows[i].Cells[1].Value = o.OrderID;
                dgvOrderList.Rows[i].Cells[2].Value = o.Customer.CustomerName;
                dgvOrderList.Rows[i].Cells[3].Value = o.Status == 0 ? "Đang xử lý" : (o.Status == 1 ? "Đã giao hàng" : "Đã hủy đơn");
                dgvOrderList.Rows[i].Cells[4].Value = o.CreatedAt;
                total++;
            }
            txtTotal.Text = total.ToString();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            int oid = dgvOrderList.CurrentCell.RowIndex;
            frmReportOrder report = new frmReportOrder(oid);
            report.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOrder addOrder = new frmAddOrder(userid);
            DialogResult rs = addOrder.ShowDialog();
            if (rs == DialogResult.OK)
            {
                LoadGrid();
            }
            
        }

        private void frmListOrder_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}
