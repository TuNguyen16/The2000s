using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The2000s.ManageForm.FormProduct;
using The2000s.ManageForm.FormOrder;
using The2000s.ManageForm.FormUser;
using The2000s.Models;

namespace The2000s
{
    public partial class frmAdmin : Form
    {
        DB_Context context = new DB_Context();
        User loginUser;
        public frmAdmin(int userid)
        {
            InitializeComponent();
            LoadUser(userid);
        }

        private void LoadUser(int userid)
        {
            //Lấy thông tin user đăng nhập
            loginUser = context.Users.FirstOrDefault(p => p.UserID == userid);
        }

        private string ShortNumber(int num)
        {
            if (num > 1000000000)
            {
                return (double)num / 1000000000 + "tỷ";
            }
            else if(num > 1000000)
            {
                return (double)num / 1000000 + "triệu";
            }
            else if(num > 1000)
            {
                return (double)num / 1000 + "nghìn";
            }
            else
            {
                return num.ToString();
            }
        }
        private void UpdateInfo()
        {
            //--------------------Hiển thị thông số trên dashboard--------------------
            //Quy ước trạng thái đơn hàng
            //0. Đang xử lý
            //1. Thành công
            //2. Đã hủy đơn
            lbSuccess.Text = context.Orders.Count(p => p.Status == 1).ToString();
            lbProcessing.Text = context.Orders.Count(p => p.Status == 0).ToString();
            lbCancel.Text = context.Orders.Count(p => p.Status == 2).ToString();
            int earned = 0;
            foreach (OrderDetail o in context.OrderDetails)
            {
                earned += (int)(o.Amount * o.Price);
            }
            lbEarned.Text = ShortNumber(earned) + " đồng";
            //---------------------Hiển thị đơn hàng mới (2 ngày)---------------------
            dgvOrderList.Rows.Clear();
            foreach (OrderDetail o in context.OrderDetails)
            {
                if (DateTime.Compare((DateTime)o.Order.CreatedAt, DateTime.Now.AddDays(-2)) >= 0)
                {
                    int i = dgvOrderList.Rows.Add();
                    dgvOrderList.Rows[i].Cells[0].Value = i + 1;
                    dgvOrderList.Rows[i].Cells[1].Value = o.OrderID;
                    dgvOrderList.Rows[i].Cells[2].Value = o.Order.Customer.CustomerName;
                    dgvOrderList.Rows[i].Cells[3].Value = o.Product.ProductName;
                    dgvOrderList.Rows[i].Cells[4].Value = o.Amount;
                    dgvOrderList.Rows[i].Cells[5].Value = o.Price;
                    dgvOrderList.Rows[i].Cells[6].Value = (o.Order.Status == 0) ? "Đang xử lý" : ((o.Order.Status == 1) ? "Đã giao hàng" : "Đã hủy đơn");
                    dgvOrderList.Rows[i].Cells[7].Value = i + 1;
                }
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Chào mừng, " + loginUser.FullName;

            //Gọi hàm Update thông số
            UpdateInfo();
        }

        #region Click Event
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
        #endregion
    }
}
