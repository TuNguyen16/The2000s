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
using The2000s.ManageForm.FormCustomer;
using The2000s.Models;
using The2000s.ManageForm.FormStorage;
using System.Globalization;

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
            this.DialogResult = DialogResult.No;
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
                return ((double)num / 1000000000).ToString("N1", CultureInfo.InvariantCulture) + " tỷ";
            }
            else if (num > 1000000)
            {
                return ((double)num / 1000000).ToString("N1", CultureInfo.InvariantCulture) + " triệu";
            }
            else
            {
                return num.ToString("N1", CultureInfo.InvariantCulture);
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
                earned += (int)(o.Amount * o.Product.Price);
            }
            lbEarned.Text = ShortNumber(earned) + " đồng";
            //---------------------Hiển thị đơn hàng mới (2 ngày)---------------------
            dgvOrderList.Rows.Clear();
            foreach (Order o in context.Orders)
            {
                if (DateTime.Compare((DateTime)o.CreatedAt, DateTime.Now.AddDays(-2)) >= 0)
                {
                    int i = dgvOrderList.Rows.Add();
                    int totalPrice = 0;
                    foreach (OrderDetail od in context.OrderDetails)
                    {
                        if (od.OrderID == o.OrderID)
                        {
                            totalPrice += Convert.ToInt32(od.Amount * od.Product.Price);
                        }
                    }
                    dgvOrderList.Rows[i].Cells[0].Value = i + 1;
                    dgvOrderList.Rows[i].Cells[1].Value = o.OrderID;
                    dgvOrderList.Rows[i].Cells[2].Value = o.Customer.CustomerName;
                    dgvOrderList.Rows[i].Cells[4].Value = o.Customer.Address;
                    dgvOrderList.Rows[i].Cells[3].Value = o.Customer.Phone;
                    dgvOrderList.Rows[i].Cells[5].Value = totalPrice;
                    dgvOrderList.Rows[i].Cells[6].Value = (o.Status == 0) ? "Đang xử lý" : (o.Status == 1 ? "Đã giao hàng" : "Đã hủy đơn");
                    dgvOrderList.Rows[i].Cells[7].Value = o.CreatedAt;
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

        private void listProduct_Click(object sender, EventArgs e)
        {
            frmListProduct list = new frmListProduct(loginUser.UserID);
            list.Show();
            UpdateInfo();
        }

        private void productCategory_Click(object sender, EventArgs e)
        {
            frmListProductCategory pcat = new frmListProductCategory();
            pcat.Show();
            UpdateInfo();
        }

        private void orderList_Click(object sender, EventArgs e)
        {
            frmListOrder olist = new frmListOrder(loginUser.UserID);
            olist.Show();
            UpdateInfo();
        }

        private void listUser_Click(object sender, EventArgs e)
        {
            frmListUser luser = new frmListUser(loginUser.UserID);
            luser.Show();
            UpdateInfo();
        }

        private void listCustomer_Click(object sender, EventArgs e)
        {
            frmListCustomer lcus = new frmListCustomer();
            lcus.Show();
            UpdateInfo();
        }
        #endregion

        private void QL_Storage_Click(object sender, EventArgs e)
        {
            frmListStorage lsto = new frmListStorage();
            lsto.Show();
            UpdateInfo();
        }

        private void QL_Supplier_Click(object sender, EventArgs e)
        {
            frmListSupplier lsup = new frmListSupplier();
            lsup.Show();
            UpdateInfo();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }
    }
}
