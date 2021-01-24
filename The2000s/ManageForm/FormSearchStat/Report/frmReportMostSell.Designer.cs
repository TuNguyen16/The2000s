
namespace The2000s.ManageForm.FormSearchStat.Report
{
    partial class frmReportMostSell
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
            this.rptView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptView
            // 
            this.rptView.LocalReport.ReportEmbeddedResource = "The2000s.Reports.ReportMostSell.rdlc";
            this.rptView.Location = new System.Drawing.Point(12, 12);
            this.rptView.Name = "rptView";
            this.rptView.ServerReport.BearerToken = null;
            this.rptView.Size = new System.Drawing.Size(883, 517);
            this.rptView.TabIndex = 0;
            // 
            // frmReportMostSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 541);
            this.Controls.Add(this.rptView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReportMostSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo sản phẩm bán chạy";
            this.Load += new System.EventHandler(this.frmReportMostSell_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptView;
    }
}