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
    public partial class frmSearchPC : Form
    {
        DB_Context context = new DB_Context();
        public frmSearchPC()
        {
            InitializeComponent();
        }

        private void frmSearchPC_Load(object sender, EventArgs e)
        {
            optName.Checked = true;
            cbParent.Enabled = false;

            List<ProductCategory> lpc = context.ProductCategories.ToList();
            cbParent.DataSource = lpc;
            cbParent.ValueMember = "CatID";
            cbParent.DisplayMember = "CatName";
        }

        private void optName_CheckedChanged(object sender, EventArgs e)
        {
            if (optName.Checked == true)
            {
                txtName.Enabled = true;
            }
            else
            {
                txtName.Enabled = false;
            }
        }

        private void optParent_CheckedChanged(object sender, EventArgs e)
        {
            if (optParent.Checked == true)
            {
                cbParent.Enabled = true;
            }
            else
            {
                cbParent.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvResult.Rows.Clear();
            if (optName.Checked == true)
            {
                List<ProductCategory> lpc = context.ProductCategories.Where(p => p.CatName == txtName.Text).ToList();
                foreach (ProductCategory pc in lpc)
                {
                    int i = dgvResult.Rows.Add();
                    dgvResult.Rows[i].Cells[0].Value = i + 1;
                    dgvResult.Rows[i].Cells[1].Value = pc.CatID;
                    dgvResult.Rows[i].Cells[2].Value = pc.CatName;
                    ProductCategory parent = context.ProductCategories.FirstOrDefault(p => p.CatID == pc.ParentID);
                    if (parent != null)
                    {
                        dgvResult.Rows[i].Cells[3].Value = parent.CatName;
                    }
                }
            }
            else
            {
                int parentid = Convert.ToInt32(cbParent.SelectedValue);
                List<ProductCategory> lpc = context.ProductCategories.Where(p => p.ParentID == parentid).ToList();
                foreach (ProductCategory pc in lpc)
                {
                    int i = dgvResult.Rows.Add();
                    dgvResult.Rows[i].Cells[0].Value = i + 1;
                    dgvResult.Rows[i].Cells[1].Value = pc.CatID;
                    dgvResult.Rows[i].Cells[2].Value = pc.CatName;
                    ProductCategory parent = context.ProductCategories.FirstOrDefault(p => p.CatID == pc.ParentID);
                    if (parent != null)
                    {
                        dgvResult.Rows[i].Cells[3].Value = parent.CatName;
                    }
                }
            }
        }
    }
}
