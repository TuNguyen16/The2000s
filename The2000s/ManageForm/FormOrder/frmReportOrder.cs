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

namespace The2000s.ManageForm.FormOrder
{
    public partial class frmReportOrder : Form
    {
        DB_Context context = new DB_Context();
        public int orderid { get; set; }
        public frmReportOrder(int oid)
        {
            InitializeComponent();
            orderid = oid;
        }

        private void frmReportOrder_Load(object sender, EventArgs e)
        {
            ReportParameter[] para = new ReportParameter[2];
            para[0] = new ReportParameter("Date", DateTime.Now.ToString("dd/MM/yyyy"));
            para[1] = new ReportParameter("ID", orderid.ToString());
            this.reportViewer1.LocalReport.SetParameters(para);
            //List<>
            //ReportDataSource rds = new ReportDataSource("DetailsDataSet",list);
            this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add();
            this.reportViewer1.RefreshReport();
        }
    }
}
