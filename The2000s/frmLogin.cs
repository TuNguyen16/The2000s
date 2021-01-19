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

namespace The2000s
{
    public partial class frmLogin : Form
    {
        DB_Context context = new DB_Context();
        public int roleid { get; set; }
        public int userid { get; set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User u = context.Users.FirstOrDefault(p => p.Username == txtUsername.Text);
                if (u == null)
                {
                    throw new Exception("Tên người dùng này không tồn tại!");
                }
                else if(u.Password != txtPassword.Text)
                {
                    throw new Exception("Mật khẩu không chính xác");
                }
                else
                {
                    roleid = (int)u.RoleID;
                    userid = (int)u.UserID;
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
