namespace Service.CONTROL.Reports.Prints
{
    partial class FPrintAllServices
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
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dReportPrint = new SV_SERVICE.Reports.DReportPrint();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cEhEntregue = new System.Windows.Forms.CheckBox();
            this.cEhProntoInstalacao = new System.Windows.Forms.CheckBox();
            this.cEhRecebido = new System.Windows.Forms.CheckBox();
            this.cEhSeparado = new System.Windows.Forms.CheckBox();
            this.cEhEncomendado = new System.Windows.Forms.CheckBox();
            this.cEhConfirmado = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cEhClienteAvisa = new System.Windows.Forms.CheckBox();
            this.cEhMedida = new System.Windows.Forms.CheckBox();
            this.cEhObraPronta = new System.Windows.Forms.CheckBox();
            this.cEhRebocada = new System.Windows.Forms.CheckBox();
            this.cEhCoberta = new System.Windows.Forms.CheckBox();
            this.cEhFundamento = new System.Windows.Forms.CheckBox();
            this.cExitButton = new System.Windows.Forms.PictureBox();
            this.cRefresButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new SV_SERVICE.Reports.DReportPrintTableAdapters.DataTable1TableAdapter();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dReportPrint)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRefresButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataMember = "DataTable1";
            this.dataTable1BindingSource2.DataSource = this.dReportPrint;
            // 
            // dReportPrint
            // 
            this.dReportPrint.DataSetName = "DReportPrint";
            this.dReportPrint.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            reportDataSource1.Name = "AllServiceDataSet";
            reportDataSource1.Value = this.dataTable1BindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Service.SV_SERVICE.Reports.RPrintAllService.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(174, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(890, 617);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.cEhEntregue);
            this.panel1.Controls.Add(this.cEhProntoInstalacao);
            this.panel1.Controls.Add(this.cEhRecebido);
            this.panel1.Controls.Add(this.cEhSeparado);
            this.panel1.Controls.Add(this.cEhEncomendado);
            this.panel1.Controls.Add(this.cEhConfirmado);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.cEhClienteAvisa);
            this.panel1.Controls.Add(this.cEhMedida);
            this.panel1.Controls.Add(this.cEhObraPronta);
            this.panel1.Controls.Add(this.cEhRebocada);
            this.panel1.Controls.Add(this.cEhCoberta);
            this.panel1.Controls.Add(this.cEhFundamento);
            this.panel1.Controls.Add(this.cExitButton);
            this.panel1.Controls.Add(this.cRefresButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 723);
            this.panel1.TabIndex = 1;
            // 
            // cEhEntregue
            // 
            this.cEhEntregue.AutoSize = true;
            this.cEhEntregue.Checked = true;
            this.cEhEntregue.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cEhEntregue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhEntregue.Location = new System.Drawing.Point(16, 320);
            this.cEhEntregue.Name = "cEhEntregue";
            this.cEhEntregue.Size = new System.Drawing.Size(73, 19);
            this.cEhEntregue.TabIndex = 16;
            this.cEhEntregue.Text = "Entregue";
            this.cEhEntregue.UseVisualStyleBackColor = true;
            // 
            // cEhProntoInstalacao
            // 
            this.cEhProntoInstalacao.AutoSize = true;
            this.cEhProntoInstalacao.Checked = true;
            this.cEhProntoInstalacao.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cEhProntoInstalacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhProntoInstalacao.Location = new System.Drawing.Point(16, 295);
            this.cEhProntoInstalacao.Name = "cEhProntoInstalacao";
            this.cEhProntoInstalacao.Size = new System.Drawing.Size(139, 19);
            this.cEhProntoInstalacao.TabIndex = 15;
            this.cEhProntoInstalacao.Text = "Pronto para Instalar";
            this.cEhProntoInstalacao.UseVisualStyleBackColor = true;
            // 
            // cEhRecebido
            // 
            this.cEhRecebido.AutoSize = true;
            this.cEhRecebido.Checked = true;
            this.cEhRecebido.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cEhRecebido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhRecebido.Location = new System.Drawing.Point(16, 247);
            this.cEhRecebido.Name = "cEhRecebido";
            this.cEhRecebido.Size = new System.Drawing.Size(76, 19);
            this.cEhRecebido.TabIndex = 14;
            this.cEhRecebido.Text = "Recebido";
            this.cEhRecebido.UseVisualStyleBackColor = true;
            // 
            // cEhSeparado
            // 
            this.cEhSeparado.AutoSize = true;
            this.cEhSeparado.Checked = true;
            this.cEhSeparado.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cEhSeparado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhSeparado.Location = new System.Drawing.Point(16, 270);
            this.cEhSeparado.Name = "cEhSeparado";
            this.cEhSeparado.Size = new System.Drawing.Size(78, 19);
            this.cEhSeparado.TabIndex = 13;
            this.cEhSeparado.Text = "Separado";
            this.cEhSeparado.UseVisualStyleBackColor = true;
            // 
            // cEhEncomendado
            // 
            this.cEhEncomendado.AutoSize = true;
            this.cEhEncomendado.Checked = true;
            this.cEhEncomendado.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cEhEncomendado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhEncomendado.Location = new System.Drawing.Point(16, 222);
            this.cEhEncomendado.Name = "cEhEncomendado";
            this.cEhEncomendado.Size = new System.Drawing.Size(103, 19);
            this.cEhEncomendado.TabIndex = 12;
            this.cEhEncomendado.Text = "Encomendado";
            this.cEhEncomendado.UseVisualStyleBackColor = true;
            // 
            // cEhConfirmado
            // 
            this.cEhConfirmado.AutoSize = true;
            this.cEhConfirmado.Checked = true;
            this.cEhConfirmado.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cEhConfirmado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhConfirmado.Location = new System.Drawing.Point(16, 197);
            this.cEhConfirmado.Name = "cEhConfirmado";
            this.cEhConfirmado.Size = new System.Drawing.Size(90, 19);
            this.cEhConfirmado.TabIndex = 11;
            this.cEhConfirmado.Text = "Confirmado";
            this.cEhConfirmado.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(16, 172);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Cliente Avisa";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cEhClienteAvisa
            // 
            this.cEhClienteAvisa.AutoSize = true;
            this.cEhClienteAvisa.Checked = true;
            this.cEhClienteAvisa.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cEhClienteAvisa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhClienteAvisa.Location = new System.Drawing.Point(16, 147);
            this.cEhClienteAvisa.Name = "cEhClienteAvisa";
            this.cEhClienteAvisa.Size = new System.Drawing.Size(97, 19);
            this.cEhClienteAvisa.TabIndex = 9;
            this.cEhClienteAvisa.Text = "Cliente Avisa";
            this.cEhClienteAvisa.UseVisualStyleBackColor = true;
            // 
            // cEhMedida
            // 
            this.cEhMedida.AutoSize = true;
            this.cEhMedida.Checked = true;
            this.cEhMedida.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cEhMedida.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhMedida.Location = new System.Drawing.Point(16, 122);
            this.cEhMedida.Name = "cEhMedida";
            this.cEhMedida.Size = new System.Drawing.Size(134, 19);
            this.cEhMedida.TabIndex = 8;
            this.cEhMedida.Text = "Medida Combinada";
            this.cEhMedida.UseVisualStyleBackColor = true;
            // 
            // cEhObraPronta
            // 
            this.cEhObraPronta.AutoSize = true;
            this.cEhObraPronta.Checked = true;
            this.cEhObraPronta.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cEhObraPronta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhObraPronta.Location = new System.Drawing.Point(16, 97);
            this.cEhObraPronta.Name = "cEhObraPronta";
            this.cEhObraPronta.Size = new System.Drawing.Size(94, 19);
            this.cEhObraPronta.TabIndex = 7;
            this.cEhObraPronta.Text = "Obra Pronta";
            this.cEhObraPronta.UseVisualStyleBackColor = true;
            // 
            // cEhRebocada
            // 
            this.cEhRebocada.AutoSize = true;
            this.cEhRebocada.Checked = true;
            this.cEhRebocada.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cEhRebocada.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhRebocada.Location = new System.Drawing.Point(16, 72);
            this.cEhRebocada.Name = "cEhRebocada";
            this.cEhRebocada.Size = new System.Drawing.Size(80, 19);
            this.cEhRebocada.TabIndex = 6;
            this.cEhRebocada.Text = "Rebocada";
            this.cEhRebocada.UseVisualStyleBackColor = true;
            // 
            // cEhCoberta
            // 
            this.cEhCoberta.AutoSize = true;
            this.cEhCoberta.Checked = true;
            this.cEhCoberta.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cEhCoberta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhCoberta.Location = new System.Drawing.Point(16, 47);
            this.cEhCoberta.Name = "cEhCoberta";
            this.cEhCoberta.Size = new System.Drawing.Size(69, 19);
            this.cEhCoberta.TabIndex = 5;
            this.cEhCoberta.Text = "Coberta";
            this.cEhCoberta.UseVisualStyleBackColor = true;
            // 
            // cEhFundamento
            // 
            this.cEhFundamento.AutoSize = true;
            this.cEhFundamento.Checked = true;
            this.cEhFundamento.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cEhFundamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhFundamento.Location = new System.Drawing.Point(16, 22);
            this.cEhFundamento.Name = "cEhFundamento";
            this.cEhFundamento.Size = new System.Drawing.Size(94, 19);
            this.cEhFundamento.TabIndex = 4;
            this.cEhFundamento.Text = "Fundamento";
            this.cEhFundamento.UseVisualStyleBackColor = true;
            // 
            // cExitButton
            // 
            this.cExitButton.Image = global::Service.Properties.Resources.exit__1_;
            this.cExitButton.Location = new System.Drawing.Point(103, 547);
            this.cExitButton.Name = "cExitButton";
            this.cExitButton.Size = new System.Drawing.Size(69, 71);
            this.cExitButton.TabIndex = 1;
            this.cExitButton.TabStop = false;
            this.cExitButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cRefresButton
            // 
            this.cRefresButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cRefresButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cRefresButton.Image = global::Service.Properties.Resources.refresh;
            this.cRefresButton.Location = new System.Drawing.Point(16, 547);
            this.cRefresButton.Name = "cRefresButton";
            this.cRefresButton.Size = new System.Drawing.Size(69, 71);
            this.cRefresButton.TabIndex = 0;
            this.cRefresButton.TabStop = false;
            this.cRefresButton.Click += new System.EventHandler(this.cRefresButton_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 542);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 85);
            this.panel2.TabIndex = 2;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dReportPrint;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dReportPrint;
            // 
            // FPrintAllServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1061, 615);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "FPrintAllServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPrintAllServices";
            this.Load += new System.EventHandler(this.FPrintAllServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dReportPrint)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cRefresButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SV_SERVICE.Reports.DReportPrint dReportPrint;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private SV_SERVICE.Reports.DReportPrintTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox cRefresButton;
        private System.Windows.Forms.PictureBox cExitButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cEhEntregue;
        private System.Windows.Forms.CheckBox cEhProntoInstalacao;
        private System.Windows.Forms.CheckBox cEhRecebido;
        private System.Windows.Forms.CheckBox cEhSeparado;
        private System.Windows.Forms.CheckBox cEhEncomendado;
        private System.Windows.Forms.CheckBox cEhConfirmado;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cEhClienteAvisa;
        private System.Windows.Forms.CheckBox cEhMedida;
        private System.Windows.Forms.CheckBox cEhObraPronta;
        private System.Windows.Forms.CheckBox cEhRebocada;
        private System.Windows.Forms.CheckBox cEhCoberta;
        private System.Windows.Forms.CheckBox cEhFundamento;
    }
}