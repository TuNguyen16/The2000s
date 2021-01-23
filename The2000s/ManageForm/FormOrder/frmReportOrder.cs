﻿using Microsoft.Reporting.WinForms;
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
        public DateTime date { get; set; }
        public frmReportOrder(int oid,DateTime d)
        {
            InitializeComponent();
            orderid = oid;
            date = d;
        }

        private void frmReportOrder_Load(object sender, EventArgs e)
        {
            ReportParameter[] para = new ReportParameter[2];
            para[0] = new ReportParameter("Date", date.ToString("dd/MM/yyyy"));
            para[1] = new ReportParameter("ID", orderid.ToString());
            this.reportViewer1.LocalReport.SetParameters(para);
            List<OrderDetailsByID> list = context.ShowOrderByID(orderid).ToList();
            ReportDataSource rds = new ReportDataSource("DetailsDataSet",list);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
