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

namespace The2000s.ManageForm.FormCustomer
{
    public partial class frmListCustomer : Form
    {
        DB_Context context = new DB_Context();
        public frmListCustomer()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            dgvCustomerList.Rows.Clear();
            int total = 0;
            foreach (Customer c in context.Customers)
            {
                int i = dgvCustomerList.Rows.Add();
                dgvCustomerList.Rows[i].Cells[0].Value = i + 1;
                dgvCustomerList.Rows[i].Cells[1].Value = c.CustomerName;
                dgvCustomerList.Rows[i].Cells[2].Value = c.Address;
                dgvCustomerList.Rows[i].Cells[3].Value = c.Phone;
                dgvCustomerList.Rows[i].Cells[4].Value = c.CustomerID;
                total++;
            }
            txtTotal.Text = total.ToString();
        }
        private void ResetValue()
        {
            txtCustomerID.Text = "";
            txtCustomerName.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerPhone.Text = "";
        }

        private void frmListCustomer_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerName.Text == "" || txtCustomerAddress.Text == "" || txtCustomerPhone.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                Customer cus = new Customer()
                {
                    CustomerName = txtCustomerName.Text,
                    Address = txtCustomerAddress.Text,
                    Phone = txtCustomerPhone.Text
                };
                context.Customers.Add(cus); 
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
                if (txtCustomerID.Text == "")
                {
                    throw new Exception("Vui lòng nhập mã khách hàng");
                }
                if (txtCustomerName.Text == "" || txtCustomerAddress.Text == "" || txtCustomerPhone.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                int cusid = Convert.ToInt32(txtCustomerID.Text);
                Customer edit = context.Customers.FirstOrDefault(p => p.CustomerID == cusid);
                if (edit != null)
                {
                    edit.CustomerName = txtCustomerName.Text;
                    edit.Address = txtCustomerAddress.Text;
                    edit.Phone = txtCustomerPhone.Text;
                    context.SaveChanges();
                    LoadGrid();
                    ResetValue();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("Không tìm thấy khách hàng này");
                }
                
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
                if (txtCustomerID.Text == "")
                {
                    throw new Exception("Vui lòng nhập mã khách hàng");
                }
                int cusid = Convert.ToInt32(txtCustomerID.Text);
                Customer edit = context.Customers.FirstOrDefault(p => p.CustomerID == cusid);
                if (edit != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng này không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        context.Customers.Remove(edit);
                        context.SaveChanges();
                        LoadGrid();
                        ResetValue();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    throw new Exception("Không tìm thấy khách hàng này");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtCustomerID.Text = dgvCustomerList.Rows[i].Cells[4].Value.ToString();
            txtCustomerName.Text = dgvCustomerList.Rows[i].Cells[1].Value.ToString();
            txtCustomerAddress.Text = dgvCustomerList.Rows[i].Cells[2].Value.ToString();
            txtCustomerPhone.Text = dgvCustomerList.Rows[i].Cells[3].Value.ToString();
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
