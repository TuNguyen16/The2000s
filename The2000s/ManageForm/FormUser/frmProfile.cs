using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The2000s.Models;

namespace The2000s.ManageForm.FormUser
{
    public partial class frmProfile : Form
    {
        DB_Context context = new DB_Context();
        public int userid { get; set; }
        public frmProfile(int uid)
        {
            InitializeComponent();
            userid = uid;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            User u = context.Users.FirstOrDefault(p => p.UserID == userid);
            txtFullName.Text = u.FullName;
            txtAddress.Text = u.Address;
            txtEmail.Text = u.Email;
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || txtEmail.Text == "" || txtAddress.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                User u = context.Users.FirstOrDefault(p => p.UserID == userid);
                u.FullName = txtFullName.Text;
                u.Address = txtAddress.Text;
                u.Email = txtEmail.Text;
                context.SaveChanges();
                MessageBox.Show("Đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string EncryptPass(string input)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] byteArray = Encoding.ASCII.GetBytes(input);
            MemoryStream stream = new MemoryStream(byteArray);
            byte[] hash = sha256.ComputeHash(stream);
            StringBuilder pass = new StringBuilder(hash.Length * 2);
            foreach (byte b in hash)
            {
                pass.AppendFormat("{0:x2}", b);
            }
            return pass.ToString();
        }
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOldPass.Text == "")
                {
                    throw new Exception("Vui lòng nhập mật khẩu cũ");
                }
                if (txtNewPass.Text == "")
                {
                    throw new Exception("Vui lòng nhập mật khẩu mới");
                }
                if (txtConfirmPass.Text == "")
                {
                    throw new Exception("Vui lòng nhập xác nhận mật khẩu");
                }
                if (txtNewPass.Text != txtConfirmPass.Text)
                {
                    throw new Exception("Xác thực mật khẩu không trùng khớp");
                }
                User u = context.Users.FirstOrDefault(p => p.UserID == userid);
                if (u.Password != EncryptPass(txtOldPass.Text))
                {
                    throw new Exception("Mật khẩu cũ không chính xác");
                }
                u.Password = EncryptPass(txtNewPass.Text);
                context.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPass.Text = "";
                txtNewPass.Text = "";
                txtConfirmPass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
