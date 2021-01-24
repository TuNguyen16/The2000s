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
    public partial class frmStatProductRemain : Form
    {
        DB_Context context = new DB_Context();
        public frmStatProductRemain()
        {
            InitializeComponent();
        }

        private void frmStatProductRemain_Load(object sender, EventArgs e)
        {
            dgvProductList.Rows.Clear();
            foreach (Product p in context.Products)
            {
                int i = dgvProductList.Rows.Add();
                dgvProductList.Rows[i].Cells[0].Value = i + 1;
                dgvProductList.Rows[i].Cells[1].Value = p.ProductID;
                dgvProductList.Rows[i].Cells[2].Value = p.ProductName;
                int sold = 0;
                foreach (OrderDetail od in context.OrderDetails)
                {
                    if (od.ProductID == p.ProductID && od.Order.Status != 2)
                    {
                        sold += Convert.ToInt32(od.Amount);
                    }
                }
                int bought = 0;
                foreach (ImportProductDetail ipd in context.ImportProductDetails)
                {
                    if (ipd.ProductID == p.ProductID)
                    {
                        bought += Convert.ToInt32(ipd.Amount);
                    }
                }
                dgvProductList.Rows[i].Cells[3].Value = bought - sold;
                dgvProductList.Rows[i].Cells[4].Value = (bought - sold >= 20) ? "" : (bought - sold > 0 ? "Sắp hết" : "Hết hàng");
            }

            int totalSold = Convert.ToInt32(context.OrderDetails.Where(p=>p.Order.Status != 2).Sum(p => p.Amount));
            int totalBought = Convert.ToInt32(context.ImportProductDetails.Sum(p => p.Amount));
            lbProductRemain.Text = "Tổng các sản phẩm trong kho: " + (totalBought - totalSold);
        }
    }
}
