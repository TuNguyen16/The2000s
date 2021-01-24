using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The2000s.ManageForm.FormSearchStat.Class;

namespace The2000s.ManageForm.FormSearchStat.Report
{
    public partial class frmReportCustomer : Form
    {
        public List<CustomerReport> list { get; set; }
        public frmReportCustomer(List<CustomerReport> l)
        {
            InitializeComponent();
            list = l;
        }

        private void frmReportCustomer_Load(object sender, EventArgs e)
        {
            ReportDataSource rptS = new ReportDataSource("CustomerReportDataSet", list);
            this.rptView.LocalReport.DataSources.Clear();
            this.rptView.LocalReport.DataSources.Add(rptS);
            this.rptView.RefreshReport();
        }
    }
}
