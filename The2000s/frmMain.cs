using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The2000s.ManageForm;

namespace The2000s
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            //lbWelcome.Text = "Chào mừng, " + username;

            for (int i = 0; i < 5; i++)
            {
                int index = dgvOrderList.Rows.Add();

                dgvOrderList.Rows[index].Cells[0].Value = index + 1;
                dgvOrderList.Rows[index].Cells[1].Value = "006" + i;
                dgvOrderList.Rows[index].Cells[2].Value = "Nguyễn Văn " + i;
                dgvOrderList.Rows[index].Cells[3].Value = "Sản phẩm " + i;
                dgvOrderList.Rows[index].Cells[4].Value = i + 1;
                dgvOrderList.Rows[index].Cells[5].Value = (i + 1) * 250000;
                dgvOrderList.Rows[index].Cells[6].Value = "Đang xử lý";
                dgvOrderList.Rows[index].Cells[7].Value = DateTime.Now;
            }
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct frmAdd = new frmAddProduct();
            frmAdd.Show();
        }
    }
}
