namespace Service.CONTROL.Relatorio
{
    partial class fmr_PrintService
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
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paypeYan = new sv_DataSetService();
            this.paypeYanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable1TableAdapter = new paypeYanTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paypeYan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paypeYanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.paypeYan;
            // 
            // paypeYan
            // 
            this.paypeYan.DataSetName = "paypeYan";
            this.paypeYan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paypeYanBindingSource
            // 
            this.paypeYanBindingSource.DataSource = this.paypeYan;
            this.paypeYanBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Service.CONTROL.Relatorio.sv_PrintService.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(875, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // fmr_PrintService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fmr_PrintService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmr_PrintService";
            this.Load += new System.EventHandler(this.fmr_PrintService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paypeYan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paypeYanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource paypeYanBindingSource;
        private sv_DataSetService paypeYan;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private paypeYanTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}