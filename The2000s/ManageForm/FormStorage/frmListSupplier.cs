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

namespace The2000s.ManageForm.FormStorage
{
    public partial class frmListSupplier : Form
    {
        DB_Context context = new DB_Context();
        public frmListSupplier()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            dgvSupplierList.Rows.Clear();
            int total = 0;
            foreach (Supplier s in context.Suppliers)
            {
                int i = dgvSupplierList.Rows.Add();
                dgvSupplierList.Rows[i].Cells[0].Value = i + 1;
                dgvSupplierList.Rows[i].Cells[1].Value = s.SupplierID;
                dgvSupplierList.Rows[i].Cells[2].Value = s.SupplierName;
                dgvSupplierList.Rows[i].Cells[3].Value = s.Address;
                dgvSupplierList.Rows[i].Cells[4].Value = s.Phone;
                total++;
            }
            txtTotal.Text = total.ToString();
        }
        private void ResetValue()
        {
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            txtSupplierAddress.Text = "";
            txtSupplierPhone.Text = "";
        }

        private void frmListSupplier_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dgvSupplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtSupplierID.Text = dgvSupplierList.Rows[i].Cells[1].Value.ToString();
                txtSupplierName.Text = dgvSupplierList.Rows[i].Cells[2].Value.ToString();
                txtSupplierAddress.Text = dgvSupplierList.Rows[i].Cells[3].Value.ToString();
                txtSupplierPhone.Text = dgvSupplierList.Rows[i].Cells[4].Value.ToString();
            }
            catch (ArgumentOutOfRangeException)
            { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSupplierName.Text == "" || txtSupplierAddress.Text == "" || txtSupplierPhone.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                Supplier sup = new Supplier()
                {
                    SupplierName = txtSupplierName.Text,
                    Address = txtSupplierAddress.Text,
                    Phone = txtSupplierPhone.Text
                };
                context.Suppliers.Add(sup);
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
                if (txtSupplierName.Text == "" || txtSupplierAddress.Text == "" || txtSupplierPhone.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                }
                if (txtSupplierID.Text == "")
                {
                    throw new Exception("Vui lòng nhập mã nhà cung cấp");
                }
                int supid = Convert.ToInt32(txtSupplierID.Text);
                Supplier edit = context.Suppliers.FirstOrDefault(p => p.SupplierID == supid);
                if (edit != null)
                {
                    edit.SupplierName = txtSupplierName.Text;
                    edit.Address = txtSupplierAddress.Text;
                    edit.Phone = txtSupplierPhone.Text;
                }
                else
                {
                    throw new Exception("Không tìm thấy nhà cung cấp này");
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
                if (txtSupplierID.Text == "")
                {
                    throw new Exception("Vui lòng nhập mã nhà cung cấp");
                }
                int supid = Convert.ToInt32(txtSupplierID.Text);
                Supplier edit = context.Suppliers.FirstOrDefault(p => p.SupplierID == supid);
                if (edit != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa nhà cung cấp này không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        context.Suppliers.Remove(edit);
                        context.SaveChanges();
                        LoadGrid();
                        ResetValue();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    throw new Exception("Không tìm thấy nhà cung cấp này");
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
    }
}
