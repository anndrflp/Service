﻿namespace Service
{
    partial class Service
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.servicoHojesDataGrid = new System.Windows.Forms.DataGridView();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situacõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosOsServiçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosSemanaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.calhasDataGridView = new System.Windows.Forms.DataGridView();
            this.Calhas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.vidrosdataGridView = new System.Windows.Forms.DataGridView();
            this.Vidros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medidasdataGridView = new System.Windows.Forms.DataGridView();
            this.Medidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atrasadosDataGridView = new System.Windows.Forms.DataGridView();
            this.deDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.transferenciaDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transferenciaCheckBox = new System.Windows.Forms.CheckBox();
            this.serviceTextBox = new System.Windows.Forms.TextBox();
            this.duracaotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clientetextBox = new System.Windows.Forms.TextBox();
            this.equipeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.servicoHojesDataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calhasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidrosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidasdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atrasadosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferenciaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // servicoHojesDataGrid
            // 
            this.servicoHojesDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.servicoHojesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicoHojesDataGrid.Location = new System.Drawing.Point(12, 368);
            this.servicoHojesDataGrid.Name = "servicoHojesDataGrid";
            this.servicoHojesDataGrid.Size = new System.Drawing.Size(701, 253);
            this.servicoHojesDataGrid.TabIndex = 1;
            this.servicoHojesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lineServiceDataGridView);
            this.servicoHojesDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceDataGridViewDoubleClick);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipesToolStripMenuItem,
            this.situacõesToolStripMenuItem,
            this.referenciaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // equipesToolStripMenuItem
            // 
            this.equipesToolStripMenuItem.Name = "equipesToolStripMenuItem";
            this.equipesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.equipesToolStripMenuItem.Text = "Equipes";
            this.equipesToolStripMenuItem.Click += new System.EventHandler(this.equipesToolStripMenuItem_Click);
            // 
            // situacõesToolStripMenuItem
            // 
            this.situacõesToolStripMenuItem.Name = "situacõesToolStripMenuItem";
            this.situacõesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.situacõesToolStripMenuItem.Text = "Situacões";
            this.situacõesToolStripMenuItem.Click += new System.EventHandler(this.situacõesToolStripMenuItem_Click);
            // 
            // referenciaToolStripMenuItem
            // 
            this.referenciaToolStripMenuItem.Name = "referenciaToolStripMenuItem";
            this.referenciaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.referenciaToolStripMenuItem.Text = "Referencia";
            this.referenciaToolStripMenuItem.Click += new System.EventHandler(this.referenciaToolStripMenuItem_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviçosToolStripMenuItem,
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serviçosToolStripMenuItem
            // 
            this.serviçosToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.serviçosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.serviçosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosOsServiçosToolStripMenuItem});
            this.serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            this.serviçosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // todosOsServiçosToolStripMenuItem
            // 
            this.todosOsServiçosToolStripMenuItem.Name = "todosOsServiçosToolStripMenuItem";
            this.todosOsServiçosToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.todosOsServiçosToolStripMenuItem.Text = "Cadastrar";
            this.todosOsServiçosToolStripMenuItem.Click += new System.EventHandler(this.todosOsServiçosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviçosDataToolStripMenuItem,
            this.serviçosSemanaisToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // serviçosDataToolStripMenuItem
            // 
            this.serviçosDataToolStripMenuItem.Name = "serviçosDataToolStripMenuItem";
            this.serviçosDataToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.serviçosDataToolStripMenuItem.Text = "Todos os serviços";
            this.serviçosDataToolStripMenuItem.Click += new System.EventHandler(this.serviçosDataToolStripMenuItem_Click);
            // 
            // serviçosSemanaisToolStripMenuItem
            // 
            this.serviçosSemanaisToolStripMenuItem.Name = "serviçosSemanaisToolStripMenuItem";
            this.serviçosSemanaisToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.serviçosSemanaisToolStripMenuItem.Text = "Todos os serviços (Semanal)";
            this.serviçosSemanaisToolStripMenuItem.Click += new System.EventHandler(this.serviçosSemanaisToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(72, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 64);
            this.button2.TabIndex = 4;
            this.button2.Text = "Alterar data";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(917, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "R";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(12, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(72, 167);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 64);
            this.button6.TabIndex = 9;
            this.button6.Text = "Relatórios";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hoje";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BotaoAtualizar);
            // 
            // calhasDataGridView
            // 
            this.calhasDataGridView.AllowUserToDeleteRows = false;
            this.calhasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calhasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Calhas,
            this.Pedido,
            this.Servico});
            this.calhasDataGridView.Location = new System.Drawing.Point(12, 55);
            this.calhasDataGridView.Name = "calhasDataGridView";
            this.calhasDataGridView.Size = new System.Drawing.Size(352, 287);
            this.calhasDataGridView.TabIndex = 9;
            this.calhasDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calhasDataGridView_CellDoubleClick);
            this.calhasDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.calhasDataGridView_CellMouseUp);
            // 
            // Calhas
            // 
            this.Calhas.FillWeight = 50F;
            this.Calhas.HeaderText = "Calhas";
            this.Calhas.Name = "Calhas";
            this.Calhas.Width = 59;
            // 
            // Pedido
            // 
            this.Pedido.FillWeight = 50F;
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.Name = "Pedido";
            this.Pedido.Width = 50;
            // 
            // Servico
            // 
            this.Servico.FillWeight = 200F;
            this.Servico.HeaderText = "Servico";
            this.Servico.Name = "Servico";
            this.Servico.Width = 200;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 64);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Service.Properties.Resources.Report;
            this.pictureBox3.Location = new System.Drawing.Point(12, 167);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 64);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // vidrosdataGridView
            // 
            this.vidrosdataGridView.AllowUserToDeleteRows = false;
            this.vidrosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vidrosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vidros,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.vidrosdataGridView.Location = new System.Drawing.Point(370, 55);
            this.vidrosdataGridView.Name = "vidrosdataGridView";
            this.vidrosdataGridView.Size = new System.Drawing.Size(343, 287);
            this.vidrosdataGridView.TabIndex = 10;
            this.vidrosdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.vidrosdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vidrosdataGridView_CellDoubleClick_1);
            this.vidrosdataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.vidrosdataGridView_CellMouseUp);
            // 
            // Vidros
            // 
            this.Vidros.FillWeight = 50F;
            this.Vidros.HeaderText = "Vidros";
            this.Vidros.Name = "Vidros";
            this.Vidros.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Pedido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Servico";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // medidasdataGridView
            // 
            this.medidasdataGridView.AllowUserToDeleteRows = false;
            this.medidasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medidasdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medidas,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.medidasdataGridView.Location = new System.Drawing.Point(719, 55);
            this.medidasdataGridView.Name = "medidasdataGridView";
            this.medidasdataGridView.Size = new System.Drawing.Size(343, 287);
            this.medidasdataGridView.TabIndex = 11;
            this.medidasdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medidasdataGridView_CellDoubleClick_1);
            this.medidasdataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.medidasdataGridView_CellMouseUp);
            // 
            // Medidas
            // 
            this.Medidas.FillWeight = 50F;
            this.Medidas.HeaderText = "Medidas";
            this.Medidas.Name = "Medidas";
            this.Medidas.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 50F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Pedido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 200F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Servico";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // atrasadosDataGridView
            // 
            this.atrasadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.atrasadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.atrasadosDataGridView.Location = new System.Drawing.Point(719, 368);
            this.atrasadosDataGridView.Name = "atrasadosDataGridView";
            this.atrasadosDataGridView.Size = new System.Drawing.Size(631, 253);
            this.atrasadosDataGridView.TabIndex = 12;
            this.atrasadosDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.atrasadosDataGridView_CellDoubleClick_1);
            // 
            // deDatePicker
            // 
            this.deDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.deDatePicker.Location = new System.Drawing.Point(1183, 20);
            this.deDatePicker.Name = "deDatePicker";
            this.deDatePicker.Size = new System.Drawing.Size(166, 29);
            this.deDatePicker.TabIndex = 13;
            this.deDatePicker.ValueChanged += new System.EventHandler(this.deDatePicker_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(990, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Atrasados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // transferenciaDataGridView
            // 
            this.transferenciaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transferenciaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.transferenciaDataGridView.Location = new System.Drawing.Point(1068, 55);
            this.transferenciaDataGridView.Name = "transferenciaDataGridView";
            this.transferenciaDataGridView.Size = new System.Drawing.Size(282, 287);
            this.transferenciaDataGridView.TabIndex = 15;
            this.transferenciaDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.transferenciaDataGridView_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Pedido";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 185F;
            this.Column2.HeaderText = "Cliente";
            this.Column2.Name = "Column2";
            this.Column2.Width = 185;
            // 
            // transferenciaCheckBox
            // 
            this.transferenciaCheckBox.AutoSize = true;
            this.transferenciaCheckBox.Location = new System.Drawing.Point(1183, 3);
            this.transferenciaCheckBox.Name = "transferenciaCheckBox";
            this.transferenciaCheckBox.Size = new System.Drawing.Size(166, 17);
            this.transferenciaCheckBox.TabIndex = 16;
            this.transferenciaCheckBox.Text = "Habilitar transferência reversa";
            this.transferenciaCheckBox.UseVisualStyleBackColor = true;
            // 
            // serviceTextBox
            // 
            this.serviceTextBox.Enabled = false;
            this.serviceTextBox.Location = new System.Drawing.Point(879, 4);
            this.serviceTextBox.Name = "serviceTextBox";
            this.serviceTextBox.Size = new System.Drawing.Size(73, 20);
            this.serviceTextBox.TabIndex = 17;
            // 
            // duracaotextBox
            // 
            this.duracaotextBox.Enabled = false;
            this.duracaotextBox.Location = new System.Drawing.Point(879, 27);
            this.duracaotextBox.Name = "duracaotextBox";
            this.duracaotextBox.Size = new System.Drawing.Size(73, 20);
            this.duracaotextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(813, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Duracao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(813, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(960, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cliente";
            // 
            // clientetextBox
            // 
            this.clientetextBox.Enabled = false;
            this.clientetextBox.Location = new System.Drawing.Point(1013, 4);
            this.clientetextBox.Name = "clientetextBox";
            this.clientetextBox.Size = new System.Drawing.Size(164, 20);
            this.clientetextBox.TabIndex = 21;
            // 
            // equipeTextBox
            // 
            this.equipeTextBox.Enabled = false;
            this.equipeTextBox.Location = new System.Drawing.Point(1013, 29);
            this.equipeTextBox.Name = "equipeTextBox";
            this.equipeTextBox.Size = new System.Drawing.Size(164, 20);
            this.equipeTextBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(958, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Equipe";
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1362, 651);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.equipeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clientetextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.duracaotextBox);
            this.Controls.Add(this.serviceTextBox);
            this.Controls.Add(this.transferenciaCheckBox);
            this.Controls.Add(this.transferenciaDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deDatePicker);
            this.Controls.Add(this.atrasadosDataGridView);
            this.Controls.Add(this.medidasdataGridView);
            this.Controls.Add(this.vidrosdataGridView);
            this.Controls.Add(this.calhasDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servicoHojesDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zeffos";
            this.Load += new System.EventHandler(this.Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicoHojesDataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calhasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidrosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medidasdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atrasadosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferenciaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView servicoHojesDataGrid;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situacõesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem referenciaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosOsServiçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.DataGridView calhasDataGridView;
        private System.Windows.Forms.ToolStripMenuItem serviçosDataToolStripMenuItem;
        private System.Windows.Forms.DataGridView vidrosdataGridView;
        private System.Windows.Forms.DataGridView medidasdataGridView;
        private System.Windows.Forms.DataGridView atrasadosDataGridView;
        private System.Windows.Forms.DateTimePicker deDatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vidros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calhas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servico;
        private System.Windows.Forms.DataGridView transferenciaDataGridView;
        private System.Windows.Forms.CheckBox transferenciaCheckBox;
        private System.Windows.Forms.TextBox serviceTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox duracaotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientetextBox;
        private System.Windows.Forms.ToolStripMenuItem serviçosSemanaisToolStripMenuItem;
        private System.Windows.Forms.TextBox equipeTextBox;
        private System.Windows.Forms.Label label6;
    }
}

