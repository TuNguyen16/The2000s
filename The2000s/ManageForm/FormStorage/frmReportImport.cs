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
using The2000s.Models;

namespace The2000s.ManageForm.FormStorage
{
    public partial class frmReportImport : Form
    {
        DB_Context context = new DB_Context();
        public int importid { get; set; }
        public DateTime date { get; set; }
        public string supname { get; set; }
        public frmReportImport(int id, DateTime d, string name)
        {
            InitializeComponent();
            importid = id;
            date = d;
            supname = name;
        }

        private void frmReportImport_Load(object sender, EventArgs e)
        {
            ReportParameter[] para = new ReportParameter[3];
            para[0] = new ReportParameter("Date", date.ToString("dd/MM/yyyy"));
            para[1] = new ReportParameter("ID", importid.ToString());
            para[2] = new ReportParameter("SupplierName", supname);
            this.reportViewer1.LocalReport.SetParameters(para);
            List<ImportDetailsByID> list = context.ShowImportByID(importid).ToList();
            ReportDataSource rds = new ReportDataSource("DetailsDataSet", list);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
