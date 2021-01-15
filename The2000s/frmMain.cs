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
using The2000s.Models;

namespace The2000s
{
    public partial class frmMain : Form
    {
        DB_Context context = new DB_Context();
        User loginUser;
        public frmMain()
        {
            InitializeComponent();

            
        }

        private void SetPermission()
        {
            frmLogin login = new frmLogin();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                menuFeature.Enabled = true;
                loginUser = context.Users.FirstOrDefault(p => p.UserID == login.userid);
                int userRole = (int)loginUser.RoleID;
                switch (userRole)
                {
                    case 2:
                        menuStorage.Enabled = false;
                        menuUser.Enabled = false;
                        break;
                    case 3:
                        menuProduct.Enabled = false;
                        menuOrder.Enabled = false;
                        break;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetPermission();
            lbWelcome.Text = "Chào mừng, " + loginUser.FullName + " (" +loginUser.Role.RoleName +")";
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
