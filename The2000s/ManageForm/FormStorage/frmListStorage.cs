using System;
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

namespace The2000s.ManageForm.FormStorage
{
    public partial class frmListStorage : Form
    {
        DB_Context context = new DB_Context();
        public frmListStorage()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            dgvImportList.Rows.Clear();
            int total = 0;
            foreach (ImportProduct ip in context.ImportProducts)
            {
                int i = dgvImportList.Rows.Add();
                int totalMoney = 0;
                dgvImportList.Rows[i].Cells[0].Value = i + 1;
                dgvImportList.Rows[i].Cells[1].Value = ip.ImportID;
                dgvImportList.Rows[i].Cells[2].Value = ip.Supplier.SupplierName;
                foreach (ImportProductDetail ipd in context.ImportProductDetails)
                {
                    if (ipd.ImportID == ip.ImportID)
                    {
                        totalMoney += Convert.ToInt32(ipd.Amount * ipd.BuyPrice);
                    }
                }
                dgvImportList.Rows[i].Cells[3].Value = totalMoney.ToString("C0",new CultureInfo("vi-VN", false));
                dgvImportList.Rows[i].Cells[4].Value = ip.CreatedAt;
                total++;
            }
            txtTotal.Text = total.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmImportStorage isto = new frmImportStorage();
            isto.ShowDialog();
            context = new DB_Context();
            LoadGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListStorage_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            int i = dgvImportList.CurrentCell.RowIndex;
            int iid = Convert.ToInt32(dgvImportList.Rows[i].Cells[1].Value);
            ImportProduct ip = context.ImportProducts.FirstOrDefault(p => p.ImportID == iid);
            DateTime date = Convert.ToDateTime(ip.CreatedAt);
            frmReportImport report = new frmReportImport(iid, date, ip.Supplier.SupplierName);
            report.ShowDialog();
        }
    }
}
