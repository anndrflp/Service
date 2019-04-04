namespace Service.CONTROL.Relatorio
{
    partial class FServiceWeek
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
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dReportPrint = new CONTROL.Reports.DReportPrint();
            this.dReportPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable1TableAdapter = new CONTROL.Reports.DReportPrintTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dReportPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dReportPrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dReportPrint;
            // 
            // dReportPrint
            // 
            this.dReportPrint.DataSetName = "DReportPrint";
            this.dReportPrint.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dReportPrintBindingSource
            // 
            this.dReportPrintBindingSource.DataSource = this.dReportPrint;
            this.dReportPrintBindingSource.Position = 0;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dReportPrint;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            reportDataSource1.Name = "ServiceDataSet";
            reportDataSource1.Value = this.dataTable1BindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Service.CONTROL.Reports.RPrintService.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(895, 492);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // FServiceWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(895, 492);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FServiceWeek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "servicosSemanais";
            this.Load += new System.EventHandler(this.FServiceWeek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dReportPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dReportPrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reports.DReportPrint dReportPrint;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Reports.DReportPrintTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dReportPrintBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
    }
}