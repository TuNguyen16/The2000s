using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The2000s.ManageForm.FormOrder
{
    public partial class frmReportOrder : Form
    {
        public frmReportOrder()
        {
            InitializeComponent();
        }

        private void frmReportOrder_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
