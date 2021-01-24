
namespace The2000s.ManageForm.FormSearchStat.Report
{
    partial class frmReportCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CustomerReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptView
            // 
            reportDataSource1.Name = "CustomerReportDataSet";
            reportDataSource1.Value = this.CustomerReportBindingSource;
            this.rptView.LocalReport.DataSources.Add(reportDataSource1);
            this.rptView.LocalReport.ReportEmbeddedResource = "The2000s.Reports.ReportCustomer.rdlc";
            this.rptView.Location = new System.Drawing.Point(12, 12);
            this.rptView.Name = "rptView";
            this.rptView.ServerReport.BearerToken = null;
            this.rptView.Size = new System.Drawing.Size(884, 435);
            this.rptView.TabIndex = 0;
            // 
            // CustomerReportBindingSource
            // 
            this.CustomerReportBindingSource.DataSource = typeof(The2000s.ManageForm.FormSearchStat.Class.CustomerReport);
            // 
            // frmReportCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 462);
            this.Controls.Add(this.rptView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReportCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo khách hàng thân thiết";
            this.Load += new System.EventHandler(this.frmReportCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptView;
        private System.Windows.Forms.BindingSource CustomerReportBindingSource;
    }
}