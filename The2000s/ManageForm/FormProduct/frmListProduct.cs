using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The2000s.ManageForm.FormProduct
{
    public partial class frmListProduct : Form
    {
        public frmListProduct()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                int index = dgvProductList.Rows.Add();

                dgvProductList.Rows[index].Cells[0].Value = index + 1;
                dgvProductList.Rows[index].Cells[1].Value = "Sản phẩm " + i;
                dgvProductList.Rows[index].Cells[2].Value = (i + 1) * 100000;
                dgvProductList.Rows[index].Cells[3].Value = (index % 2 ==0 ? "Danh mục 1" : "Danh mục 2");
                dgvProductList.Rows[index].Cells[4].Value = DateTime.Now;
                dgvProductList.Rows[index].Cells[5].Value = (index % 2 == 0 ? "Còn hàng" : "Hết hàng");
            }
        }
    }
}
