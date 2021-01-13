using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The2000s.ManageForm.Product;
using The2000s.ManageForm.Order;
using The2000s.ManageForm.User;

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
            frmAddProduct add = new frmAddProduct();
            add.Show();
        }

        private void listProduct_Click(object sender, EventArgs e)
        {
            frmListProduct list = new frmListProduct();
            list.Show();
        }

        private void productCategory_Click(object sender, EventArgs e)
        {
            frmListProductCategory pcat = new frmListProductCategory();
            pcat.Show();
        }

        private void orderList_Click(object sender, EventArgs e)
        {
            frmListOrder olist = new frmListOrder();
            olist.Show();
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            frmAddOrder addOrder = new frmAddOrder();
            addOrder.Show();
        }

        private void listUser_Click(object sender, EventArgs e)
        {
            frmListUser luser = new frmListUser();
            luser.Show();
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            frmAddUser auser = new frmAddUser();
            auser.Show();
        }
    }
}
