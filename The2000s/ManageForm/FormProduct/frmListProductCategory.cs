using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The2000s.ManageForm.FormProduct
{
    public partial class frmListProductCategory : Form
    {
        public frmListProductCategory()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                int index = dgvCategoryList.Rows.Add();

                dgvCategoryList.Rows[index].Cells[0].Value = index + 1;
                dgvCategoryList.Rows[index].Cells[1].Value = "Danh mục " + (i + 1);
                dgvCategoryList.Rows[index].Cells[2].Value = "Danh mục 0";            }
        }
    }
}
