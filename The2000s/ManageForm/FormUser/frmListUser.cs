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

namespace The2000s.ManageForm.FormUser
{
    public partial class frmListUser : Form
    {
        DB_Context context = new DB_Context();
        public frmListUser()
        {
            InitializeComponent();
        }

        private void LoadGrid()
        {
            dgvUserList.Rows.Clear();
            foreach (User u in context.Users)
            {
                int i = dgvUserList.Rows.Add();
                dgvUserList.Rows[i].Cells[0].Value = i + 1;
                dgvUserList.Rows[i].Cells[1].Value = u.FullName;
                dgvUserList.Rows[i].Cells[2].Value = u.Email;
                dgvUserList.Rows[i].Cells[3].Value = u.Role.RoleName;
                dgvUserList.Rows[i].Cells[4].Value = u.Username;
                dgvUserList.Rows[i].Cells[5].Value = u.RoleID;
            }
        }
        private void ResetValue()
        {
            txtFullName.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            //cbPermission.SelectedIndex = 0;
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

        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtFullName.Text = dgvUserList.Rows[i].Cells[1].Value.ToString();
            txtEmail.Text = dgvUserList.Rows[i].Cells[2].Value.ToString();
            txtUsername.Text = dgvUserList.Rows[i].Cells[4].Value.ToString();
            cbPermission.SelectedValue = dgvUserList.Rows[i].Cells[5].Value;
        }
    }
}
