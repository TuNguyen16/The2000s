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
    public partial class frmListUser : Form
    {
        DB_Context context = new DB_Context();
        public int userid { get; set; }
        public frmListUser(int uid)
        {
            InitializeComponent();
            userid = uid;
        }

        private void LoadGrid()
        {
            dgvUserList.Rows.Clear();
            int total = 0;
            foreach (User u in context.Users)
            {
                int i = dgvUserList.Rows.Add();
                dgvUserList.Rows[i].Cells[0].Value = i + 1;
                dgvUserList.Rows[i].Cells[1].Value = u.UserID;
                dgvUserList.Rows[i].Cells[2].Value = u.FullName;
                dgvUserList.Rows[i].Cells[3].Value = u.Email;
                dgvUserList.Rows[i].Cells[4].Value = u.Role.RoleName;
                dgvUserList.Rows[i].Cells[5].Value = u.Username;
                dgvUserList.Rows[i].Cells[6].Value = u.Password;
                dgvUserList.Rows[i].Cells[7].Value = u.RoleID;
                dgvUserList.Rows[i].Cells[8].Value = u.Address;
                dgvUserList.Rows[i].Cells[9].Value = u.CreatedAt;
                total++;
            }
            txtTotal.Text = total.ToString();
        }
        private void ResetValue()
        {
            txtUserID.Text = "";
            txtFullName.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtCreatedAt.Text = "";
            cbPermission.SelectedIndex = 0;
        }
        private void frmListUser_Load(object sender, EventArgs e)
        {
            //Load thông tin user vào DataGrid
            LoadGrid();
            //Load các quyền vào ComboBox
            List<Role> roles = context.Roles.ToList();
            cbPermission.DataSource = roles;
            cbPermission.ValueMember = "RoleID";
            cbPermission.DisplayMember = "RoleName";
        }
        #region Events

        
        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtUserID.Text = dgvUserList.Rows[i].Cells[1].Value.ToString();
                txtFullName.Text = dgvUserList.Rows[i].Cells[2].Value.ToString();
                txtEmail.Text = dgvUserList.Rows[i].Cells[3].Value.ToString();
                txtUsername.Text = dgvUserList.Rows[i].Cells[5].Value.ToString();
                txtPassword.Text = dgvUserList.Rows[i].Cells[6].Value.ToString();
                cbPermission.SelectedValue = dgvUserList.Rows[i].Cells[7].Value;
                txtAddress.Text = dgvUserList.Rows[i].Cells[8].Value.ToString();
                txtCreatedAt.Text = dgvUserList.Rows[i].Cells[9].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFullName.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtUsername.Text == "" ||
                    txtPassword.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                SHA256 sha256 = SHA256.Create();
                byte[] byteArray = Encoding.ASCII.GetBytes(txtPassword.Text);
                MemoryStream stream = new MemoryStream(byteArray);
                byte[] hash = sha256.ComputeHash(stream);
                StringBuilder pass = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    pass.AppendFormat("{0:x2}", b);
                }
                User tmp = new User()
                {
                    FullName = txtFullName.Text,
                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    Username = txtUsername.Text,
                    Password = pass.ToString(),
                    CreatedAt = DateTime.Now,
                    CreatedBy = userid,
                    RoleID = (int?)cbPermission.SelectedValue
                };
                context.Users.Add(tmp);
                context.SaveChanges();
                LoadGrid();
                ResetValue();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text == "")
                {
                    throw new Exception("Vui lòng nhập user ID cần sửa");
                }
                if (txtFullName.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || 
                    txtUsername.Text == "" || txtPassword.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                int euid = Convert.ToInt32(txtUserID.Text);
                User edit = context.Users.FirstOrDefault(p => p.UserID == euid);
                if (edit != null)
                {
                    if (txtPassword.Text != edit.Password)
                    {
                        //Encrypt Pass-----------------------
                        SHA256 sha256 = SHA256.Create();
                        byte[] byteArray = Encoding.ASCII.GetBytes(txtPassword.Text);
                        MemoryStream stream = new MemoryStream(byteArray);
                        byte[] hash = sha256.ComputeHash(stream);
                        StringBuilder pass = new StringBuilder(hash.Length * 2);
                        foreach (byte b in hash)
                        {
                            pass.AppendFormat("{0:x2}", b);
                        }

                        //----------------------------------
                        
                        edit.Password = pass.ToString();
                        
                    }
                    edit.FullName = txtFullName.Text;
                    edit.Address = txtAddress.Text;
                    edit.Email = txtEmail.Text;
                    edit.Username = txtUsername.Text;
                    edit.RoleID = (int)cbPermission.SelectedValue;
                }
                else
                {
                    throw new Exception("Không tìm thấy người dùng này");
                }
                context.SaveChanges();
                LoadGrid();
                ResetValue();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text == "")
                {
                    throw new Exception("Vui lòng nhập User ID cần xóa");
                }
                int euid = Convert.ToInt32(txtUserID.Text);
                User edit = context.Users.FirstOrDefault(p => p.UserID == euid);
                if (edit != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa người dùng này không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        context.Users.Remove(edit);
                        context.SaveChanges();
                        LoadGrid();
                        ResetValue();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    throw new Exception("Không tìm thấy người dùng này");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
