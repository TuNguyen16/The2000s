﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The2000s.Models;

namespace The2000s.ManageForm.FormOrder
{
    public partial class frmAddOrder : Form
    {
        DB_Context context = new DB_Context();
        public int userid { get; set; }
        public frmAddOrder(int uid)
        {
            InitializeComponent();
            userid = uid;
            DialogResult = DialogResult.OK;
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerID.Text != "")
                {
                    int cusid = Convert.ToInt32(txtCustomerID.Text);
                    Customer cus = context.Customers.FirstOrDefault(p => p.CustomerID == cusid);
                    if (cus != null)
                    {
                        txtCustomerName.Text = cus.CustomerName;
                    }
                    else
                    {
                        txtCustomerName.Text = "";
                    }
                }
                else
                {
                    txtCustomerName.Text = "";
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtProductID.Text != "")
                {
                    int pid = Convert.ToInt32(txtProductID.Text);
                    Product product = context.Products.FirstOrDefault(p => p.ProductID == pid);
                    if (product != null)
                    {
                        txtProductName.Text = product.ProductName;
                    }
                    else
                    {
                        txtProductName.Text = "";
                    }
                }
                else
                {
                    txtProductName.Text = "";
                }
            }
            catch (Exception)
            {

               
            }
        }

        private void AddToGrid(Product p)
        {
            if (Convert.ToInt32(txtAmount.Text) > context.ImportProductDetails.AsEnumerable().Where(k => k.ProductID == Convert.ToInt32(txtProductID.Text)).Sum(k => k.Amount)
                                 - context.OrderDetails.AsEnumerable().Where(k => k.ProductID == Convert.ToInt32(txtProductID.Text) && k.Order.Status != 2).Sum(k => k.Amount))
            {
                throw new Exception("Hàng trong kho không đủ");
            }
            int i = dgvProductList.Rows.Add();
            dgvProductList.Rows[i].Cells[0].Value = i + 1;
            dgvProductList.Rows[i].Cells[1].Value = p.ProductID;
            dgvProductList.Rows[i].Cells[2].Value = p.ProductName;
            dgvProductList.Rows[i].Cells[3].Value = txtAmount.Text;
            dgvProductList.Rows[i].Cells[4].Value = p.Price;
            int amount = Convert.ToInt32(txtAmount.Text);
            dgvProductList.Rows[i].Cells[5].Value = (amount * p.Price);
        }
        private void CalcTotalMoney()
        {
            int totalMoney = 0;
            foreach (DataGridViewRow row in dgvProductList.Rows)
            {
                totalMoney += Convert.ToInt32(row.Cells[5].Value);
            }
            txtTotal.Text = totalMoney.ToString("C0", new CultureInfo("vi-VN", false));
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCustomerID.Text == "" || txtCustomerName.Text == "")
                {
                    throw new Exception("Thông tin khách hàng chưa chính xác");
                }
                if (txtProductID.Text == "" || txtProductName.Text == "" || txtAmount.Text == "")
                {
                    throw new Exception("Thông tin sản phẩm chưa chính xác");
                }
                int pid = Convert.ToInt32(txtProductID.Text);
                Product tmp = context.Products.FirstOrDefault(p => p.ProductID == pid);
                foreach (DataGridViewRow row in dgvProductList.Rows)
                {
                    if (row.Cells[1].Value.ToString() == txtProductID.Text)
                    {

                        int cur = Convert.ToInt32(row.Cells[3].Value);
                        cur += Convert.ToInt32(txtAmount.Text);
                        if (cur > context.ImportProductDetails.AsEnumerable().Where(p=>p.ProductID == Convert.ToInt32(row.Cells[1].Value)).Sum(p=>p.Amount)
                                 - context.OrderDetails.AsEnumerable().Where(p => p.ProductID == Convert.ToInt32(row.Cells[1].Value) && p.Order.Status != 2).Sum(p => p.Amount))
                        {
                            throw new Exception("Hàng trong kho không đủ");
                        }
                        row.Cells[3].Value = cur;
                        row.Cells[5].Value = cur * Convert.ToInt32(row.Cells[4].Value);
                        CalcTotalMoney();
                        return;
                    }
                }
                AddToGrid(tmp);
                CalcTotalMoney();
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
                int pid = Convert.ToInt32(txtProductID.Text);
                foreach (DataGridViewRow row in dgvProductList.Rows)
                {
                    if (row.Cells[1].Value.ToString() == txtProductID.Text)
                    {
                        dgvProductList.Rows.Remove(row);
                    }
                }
                CalcTotalMoney();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtProductID.Text = dgvProductList.Rows[i].Cells[1].Value.ToString();
            txtProductName.Text = dgvProductList.Rows[i].Cells[2].Value.ToString();
            txtAmount.Text = dgvProductList.Rows[i].Cells[3].Value.ToString();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order o = new Order()
                {
                    CreatedAt = DateTime.Now,
                    CustomerID = Convert.ToInt32(txtCustomerID.Text),
                    UserID = userid,
                    Status = 0
                };
                context.Orders.Add(o);
                context.SaveChanges();

                int oid = o.OrderID;
                foreach (DataGridViewRow row in dgvProductList.Rows)
                {
                    OrderDetail od = new OrderDetail()
                    {
                        OrderID = oid,
                        Amount = Convert.ToInt32(row.Cells[3].Value),
                        ProductID = Convert.ToInt32(row.Cells[1].Value)
                    };
                    context.OrderDetails.Add(od);
                }
                context.SaveChanges();
                MessageBox.Show("Thêm đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
