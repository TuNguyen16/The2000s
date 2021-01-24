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
    public partial class frmReportProfit : Form
    {
        public List<ProfitReport> list { get; set; }
        public string datestr { get; set; }
        public frmReportProfit(List<ProfitReport> l, string d)
        {
            InitializeComponent();
            list = l;
            datestr = d;
        }

        private void frmReportProfit_Load(object sender, EventArgs e)
        {
            ReportParameter para = new ReportParameter("DateStr",datestr);
            this.rptView.LocalReport.SetParameters(para);
            ReportDataSource rptS = new ReportDataSource("ProfitReportDataSet", list);
            this.rptView.LocalReport.DataSources.Clear();
            this.rptView.LocalReport.DataSources.Add(rptS);
            this.rptView.RefreshReport();
        }
    }
}
