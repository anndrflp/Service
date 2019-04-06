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
            this.label4 = new System.Windows.Forms.Label();
            this.cStatusBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cReferenciaBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.cAteDate = new System.Windows.Forms.DateTimePicker();
            this.cDeDate = new System.Windows.Forms.DateTimePicker();
            this.cAteBox = new System.Windows.Forms.MaskedTextBox();
            this.cDeBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cTeamBox = new System.Windows.Forms.ComboBox();
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
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cStatusBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cReferenciaBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Data);
            this.panel1.Controls.Add(this.cAteDate);
            this.panel1.Controls.Add(this.cDeDate);
            this.panel1.Controls.Add(this.cAteBox);
            this.panel1.Controls.Add(this.cDeBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cTeamBox);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Situação";
            // 
            // cStatusBox
            // 
            this.cStatusBox.FormattingEnabled = true;
            this.cStatusBox.Location = new System.Drawing.Point(56, 146);
            this.cStatusBox.Name = "cStatusBox";
            this.cStatusBox.Size = new System.Drawing.Size(99, 21);
            this.cStatusBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Ref.";
            // 
            // cReferenciaBox
            // 
            this.cReferenciaBox.FormattingEnabled = true;
            this.cReferenciaBox.Location = new System.Drawing.Point(56, 119);
            this.cReferenciaBox.Name = "cReferenciaBox";
            this.cReferenciaBox.Size = new System.Drawing.Size(99, 21);
            this.cReferenciaBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ate";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(3, 41);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(30, 13);
            this.Data.TabIndex = 23;
            this.Data.Text = "Data";
            // 
            // cAteDate
            // 
            this.cAteDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cAteDate.Location = new System.Drawing.Point(158, 64);
            this.cAteDate.Name = "cAteDate";
            this.cAteDate.Size = new System.Drawing.Size(14, 20);
            this.cAteDate.TabIndex = 22;
            this.cAteDate.ValueChanged += new System.EventHandler(this.cAteDate_ValueChanged);
            // 
            // cDeDate
            // 
            this.cDeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cDeDate.Location = new System.Drawing.Point(158, 38);
            this.cDeDate.Name = "cDeDate";
            this.cDeDate.Size = new System.Drawing.Size(14, 20);
            this.cDeDate.TabIndex = 21;
            this.cDeDate.ValueChanged += new System.EventHandler(this.cDeDate_ValueChanged);
            // 
            // cAteBox
            // 
            this.cAteBox.Location = new System.Drawing.Point(56, 64);
            this.cAteBox.Mask = "00/00/0000 90:00";
            this.cAteBox.Name = "cAteBox";
            this.cAteBox.Size = new System.Drawing.Size(99, 20);
            this.cAteBox.TabIndex = 20;
            this.cAteBox.ValidatingType = typeof(System.DateTime);
            // 
            // cDeBox
            // 
            this.cDeBox.Location = new System.Drawing.Point(56, 38);
            this.cDeBox.Mask = "00/00/0000 90:00";
            this.cDeBox.Name = "cDeBox";
            this.cDeBox.Size = new System.Drawing.Size(99, 20);
            this.cDeBox.TabIndex = 19;
            this.cDeBox.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Equipe";
            // 
            // cTeamBox
            // 
            this.cTeamBox.FormattingEnabled = true;
            this.cTeamBox.Location = new System.Drawing.Point(56, 92);
            this.cTeamBox.Name = "cTeamBox";
            this.cTeamBox.Size = new System.Drawing.Size(99, 21);
            this.cTeamBox.TabIndex = 17;
            // 
            // cEhEntregue
            // 
            this.cEhEntregue.AutoSize = true;
            this.cEhEntregue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhEntregue.Location = new System.Drawing.Point(6, 481);
            this.cEhEntregue.Name = "cEhEntregue";
            this.cEhEntregue.Size = new System.Drawing.Size(73, 19);
            this.cEhEntregue.TabIndex = 16;
            this.cEhEntregue.Text = "Entregue";
            this.cEhEntregue.UseVisualStyleBackColor = true;
            // 
            // cEhProntoInstalacao
            // 
            this.cEhProntoInstalacao.AutoSize = true;
            this.cEhProntoInstalacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhProntoInstalacao.Location = new System.Drawing.Point(6, 456);
            this.cEhProntoInstalacao.Name = "cEhProntoInstalacao";
            this.cEhProntoInstalacao.Size = new System.Drawing.Size(139, 19);
            this.cEhProntoInstalacao.TabIndex = 15;
            this.cEhProntoInstalacao.Text = "Pronto para Instalar";
            this.cEhProntoInstalacao.UseVisualStyleBackColor = true;
            // 
            // cEhRecebido
            // 
            this.cEhRecebido.AutoSize = true;
            this.cEhRecebido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhRecebido.Location = new System.Drawing.Point(6, 408);
            this.cEhRecebido.Name = "cEhRecebido";
            this.cEhRecebido.Size = new System.Drawing.Size(76, 19);
            this.cEhRecebido.TabIndex = 14;
            this.cEhRecebido.Text = "Recebido";
            this.cEhRecebido.UseVisualStyleBackColor = true;
            // 
            // cEhSeparado
            // 
            this.cEhSeparado.AutoSize = true;
            this.cEhSeparado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhSeparado.Location = new System.Drawing.Point(6, 431);
            this.cEhSeparado.Name = "cEhSeparado";
            this.cEhSeparado.Size = new System.Drawing.Size(78, 19);
            this.cEhSeparado.TabIndex = 13;
            this.cEhSeparado.Text = "Separado";
            this.cEhSeparado.UseVisualStyleBackColor = true;
            // 
            // cEhEncomendado
            // 
            this.cEhEncomendado.AutoSize = true;
            this.cEhEncomendado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhEncomendado.Location = new System.Drawing.Point(6, 383);
            this.cEhEncomendado.Name = "cEhEncomendado";
            this.cEhEncomendado.Size = new System.Drawing.Size(103, 19);
            this.cEhEncomendado.TabIndex = 12;
            this.cEhEncomendado.Text = "Encomendado";
            this.cEhEncomendado.UseVisualStyleBackColor = true;
            // 
            // cEhConfirmado
            // 
            this.cEhConfirmado.AutoSize = true;
            this.cEhConfirmado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhConfirmado.Location = new System.Drawing.Point(6, 358);
            this.cEhConfirmado.Name = "cEhConfirmado";
            this.cEhConfirmado.Size = new System.Drawing.Size(90, 19);
            this.cEhConfirmado.TabIndex = 11;
            this.cEhConfirmado.Text = "Confirmado";
            this.cEhConfirmado.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(6, 333);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Cliente Avisa";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cEhClienteAvisa
            // 
            this.cEhClienteAvisa.AutoSize = true;
            this.cEhClienteAvisa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhClienteAvisa.Location = new System.Drawing.Point(6, 308);
            this.cEhClienteAvisa.Name = "cEhClienteAvisa";
            this.cEhClienteAvisa.Size = new System.Drawing.Size(97, 19);
            this.cEhClienteAvisa.TabIndex = 9;
            this.cEhClienteAvisa.Text = "Cliente Avisa";
            this.cEhClienteAvisa.UseVisualStyleBackColor = true;
            // 
            // cEhMedida
            // 
            this.cEhMedida.AutoSize = true;
            this.cEhMedida.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhMedida.Location = new System.Drawing.Point(6, 283);
            this.cEhMedida.Name = "cEhMedida";
            this.cEhMedida.Size = new System.Drawing.Size(134, 19);
            this.cEhMedida.TabIndex = 8;
            this.cEhMedida.Text = "Medida Combinada";
            this.cEhMedida.UseVisualStyleBackColor = true;
            // 
            // cEhObraPronta
            // 
            this.cEhObraPronta.AutoSize = true;
            this.cEhObraPronta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhObraPronta.Location = new System.Drawing.Point(6, 258);
            this.cEhObraPronta.Name = "cEhObraPronta";
            this.cEhObraPronta.Size = new System.Drawing.Size(94, 19);
            this.cEhObraPronta.TabIndex = 7;
            this.cEhObraPronta.Text = "Obra Pronta";
            this.cEhObraPronta.UseVisualStyleBackColor = true;
            // 
            // cEhRebocada
            // 
            this.cEhRebocada.AutoSize = true;
            this.cEhRebocada.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhRebocada.Location = new System.Drawing.Point(6, 233);
            this.cEhRebocada.Name = "cEhRebocada";
            this.cEhRebocada.Size = new System.Drawing.Size(80, 19);
            this.cEhRebocada.TabIndex = 6;
            this.cEhRebocada.Text = "Rebocada";
            this.cEhRebocada.UseVisualStyleBackColor = true;
            // 
            // cEhCoberta
            // 
            this.cEhCoberta.AutoSize = true;
            this.cEhCoberta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhCoberta.Location = new System.Drawing.Point(6, 208);
            this.cEhCoberta.Name = "cEhCoberta";
            this.cEhCoberta.Size = new System.Drawing.Size(69, 19);
            this.cEhCoberta.TabIndex = 5;
            this.cEhCoberta.Text = "Coberta";
            this.cEhCoberta.UseVisualStyleBackColor = true;
            // 
            // cEhFundamento
            // 
            this.cEhFundamento.AutoSize = true;
            this.cEhFundamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEhFundamento.Location = new System.Drawing.Point(6, 183);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cReferenciaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.DateTimePicker cAteDate;
        private System.Windows.Forms.DateTimePicker cDeDate;
        private System.Windows.Forms.MaskedTextBox cAteBox;
        private System.Windows.Forms.MaskedTextBox cDeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cTeamBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cStatusBox;
    }
}