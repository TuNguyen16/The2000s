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
            if (optTime.Checked == true)
            {
                try
                {
                    if (DateTime.Compare(dtpS.Value.Date,dtpE.Value.Date) > 0)
                    {
                        dtpS.Value = dtpE.Value;
                        throw new Exception("Ngày bắt đầu không được lớn hơn ngày thúc");
                    }
                    dgvResult.Rows.Clear();
                    foreach (Order o in context.Orders)
                    {
                        if (DateTime.Compare(Convert.ToDateTime(o.CreatedAt).Date,dtpS.Value.Date) >= 0 && DateTime.Compare(Convert.ToDateTime(o.CreatedAt).Date, dtpE.Value.Date) <= 0)
                        {
                            int i = dgvResult.Rows.Add();
                            dgvResult.Rows[i].Cells[0].Value = i + 1;
                            dgvResult.Rows[i].Cells[1].Value = o.OrderID;
                            dgvResult.Rows[i].Cells[2].Value = o.Customer.CustomerName;
                            dgvResult.Rows[i].Cells[3].Value = (o.Status == 0) ? "Đang xử lý" : (o.Status == 1 ? "Đã giao hàng" : "Đã hủy đơn");
                            dgvResult.Rows[i].Cells[4].Value = o.CreatedAt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                dgvResult.Rows.Clear();
                int st = Convert.ToInt32(cbStatus.SelectedValue);
                List<Order> orders = context.Orders.Where(p => p.Status == st).ToList();
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

        private void frmSearchOrder_Load(object sender, EventArgs e)
        {
            optTime.Checked = true;
            cbStatus.Enabled = false;

            DataTable statusdt = new DataTable();
            DataColumn tmp1 = new DataColumn();
            tmp1.ColumnName = "colID";
            statusdt.Columns.Add(tmp1);
            tmp1 = new DataColumn();
            tmp1.ColumnName = "colName";
            statusdt.Columns.Add(tmp1);

            string[] status = { "Đang xử lý", "Đã giao hàng", "Đã hủy đơn" };
            int i = 0;
            foreach (string st in status)
            {
                DataRow tmp = statusdt.NewRow();
                tmp[0] = i;
                tmp[1] = st;
                statusdt.Rows.Add(tmp);
                i++;
            }

            cbStatus.DataSource = statusdt;
            cbStatus.ValueMember = "colID";
            cbStatus.DisplayMember = "colName";
        }

        private void optTime_CheckedChanged(object sender, EventArgs e)
        {
            if (optTime.Checked == true)
            {
                dtpS.Enabled = true;
                dtpE.Enabled = true;
            }
            else
            {
                dtpS.Enabled = false;
                dtpE.Enabled = false;
            }
        }

        private void optStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (optStatus.Checked == true)
            {
                cbStatus.Enabled = true;
            }
            else
            {
                cbStatus.Enabled = false;
            }
        }
    }
}
