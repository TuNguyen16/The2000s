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
using The2000s.ManageForm.FormSearchStat;
using The2000s.Models;
using The2000s.ManageForm.FormStorage;
using System.Globalization;

namespace The2000s
{
    public partial class frmNVKho : Form
    {
        DB_Context context = new DB_Context();
        User loginUser;
        public frmNVKho(int userid)
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
                return ((double)num / 1000000000).ToString("N1", CultureInfo.InvariantCulture) + " tỷ";
            }
            else if(num > 1000000)
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
            
            lbSuccess.Text = context.ImportProducts.ToList().Count.ToString();
            int sell = Convert.ToInt32(context.OrderDetails.Sum(p => p.Amount));
            int cur = Convert.ToInt32(context.ImportProductDetails.Sum(p => p.Amount));
            lbProcessing.Text = (cur - sell).ToString();
            int earned = 0;
            foreach (ImportProductDetail o in context.ImportProductDetails)
            {
                earned += (int)(o.Amount * o.BuyPrice);
            }
            lbEarned.Text = ShortNumber(earned) + " đồng";
            //---------------------Hiển thị đơn nhập hàng mới (2 ngày)---------------------
            dgvOrderList.Rows.Clear();
            foreach (ImportProduct o in context.ImportProducts)
            {
                if (DateTime.Compare((DateTime)o.CreatedAt, DateTime.Now.AddDays(-2)) >= 0)
                {
                    int i = dgvOrderList.Rows.Add();
                    int totalPrice = 0;
                    foreach (ImportProductDetail od in context.ImportProductDetails)
                    {
                        if (od.ImportID == o.ImportID)
                        {
                            totalPrice += Convert.ToInt32(od.Amount * od.BuyPrice);
                        }
                    }
                    dgvOrderList.Rows[i].Cells[0].Value = i + 1;
                    dgvOrderList.Rows[i].Cells[1].Value = o.ImportID;
                    dgvOrderList.Rows[i].Cells[2].Value = o.Supplier.SupplierName;
                    dgvOrderList.Rows[i].Cells[3].Value = totalPrice.ToString("C0",new CultureInfo("vi-VN",false));
                    dgvOrderList.Rows[i].Cells[4].Value = o.CreatedAt;
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

        private void lbRole_Click(object sender, EventArgs e)
        {

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

        private void menuProfile_Click(object sender, EventArgs e)
        {
            frmProfile profile = new frmProfile(loginUser.UserID);
            profile.Show();
        }

        private void menuSearchProduct_Click(object sender, EventArgs e)
        {
            frmSearchProduct spro = new frmSearchProduct();
            spro.ShowDialog();
        }

        private void menuSearchPC_Click(object sender, EventArgs e)
        {
            frmSearchPC spc = new frmSearchPC();
            spc.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatProductRemain stat1 = new frmStatProductRemain();
            stat1.ShowDialog();
        }
    }
}
