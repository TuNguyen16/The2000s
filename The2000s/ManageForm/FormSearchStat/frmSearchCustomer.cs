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

namespace The2000s.ManageForm.FormSearchStat
{
    public partial class frmSearchCustomer : Form
    {
        DB_Context context = new DB_Context();
        public frmSearchCustomer()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvResult.Rows.Clear();
            List<Customer> lcs = context.Customers.Where(p => p.CustomerName.Contains(txtName.Text)).ToList();
            if (lcs != null)
            {
                foreach (Customer cs in lcs)
                {
                    int i = dgvResult.Rows.Add();
                    dgvResult.Rows[i].Cells[0].Value = i + 1;
                    dgvResult.Rows[i].Cells[1].Value = cs.CustomerID;
                    dgvResult.Rows[i].Cells[2].Value = cs.CustomerName;
                    dgvResult.Rows[i].Cells[3].Value = cs.Address;
                    dgvResult.Rows[i].Cells[4].Value = cs.Phone;
                }
            }
        }
    }
}
