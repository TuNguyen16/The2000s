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
    public partial class frmReportMostSell : Form
    {
        public List<ProductReport> list { get; set; }
        public string datestr { get; set; }
        public frmReportMostSell(List<ProductReport> l, string dstr)
        {
            InitializeComponent();
            list = l;
            datestr = dstr;
        }

        private void frmReportMostSell_Load(object sender, EventArgs e)
        {
            ReportParameter para = new ReportParameter("Date", datestr);
            this.rptView.LocalReport.SetParameters(para);

            ReportDataSource rptS = new ReportDataSource("ProductReportDataSet",list);
            this.rptView.LocalReport.DataSources.Clear();
            this.rptView.LocalReport.DataSources.Add(rptS);
            this.rptView.RefreshReport();
        }
    }
}
