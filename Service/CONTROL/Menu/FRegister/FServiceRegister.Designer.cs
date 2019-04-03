namespace Service.zCONTROL
{
    partial class RegisterService
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
            this.equipecomboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cDataOriginalTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.duracaoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.datefinalTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.RichTextBox();
            this.statuscomboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serviceTextbox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.obsTextBox = new System.Windows.Forms.RichTextBox();
            this.handleTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.contatoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cComplementoTextBox = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bairroTextBox = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.referenciacomboBox1 = new System.Windows.Forms.ComboBox();
            this.ruaTextBox = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clienteTextBox = new System.Windows.Forms.RichTextBox();
            this.numTextBox = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cidadeTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.obraProntocheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.cEHFundamento = new System.Windows.Forms.CheckBox();
            this.cEHCOBERTA = new System.Windows.Forms.CheckBox();
            this.cEHRebocada = new System.Windows.Forms.CheckBox();
            this.cEHMedidaCombinada = new System.Windows.Forms.CheckBox();
            this.cEHClienteAvisa = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.recebidocheckBox = new System.Windows.Forms.CheckBox();
            this.entreguecheckBox = new System.Windows.Forms.CheckBox();
            this.encomendadocheckBox = new System.Windows.Forms.CheckBox();
            this.semDataCheckBox = new System.Windows.Forms.CheckBox();
            this.cEHConfirmado = new System.Windows.Forms.CheckBox();
            this.cEHSeparado = new System.Windows.Forms.CheckBox();
            this.cEHInstalacao = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipecomboBox1
            // 
            this.equipecomboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.equipecomboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.equipecomboBox1.FormattingEnabled = true;
            this.equipecomboBox1.Location = new System.Drawing.Point(91, 18);
            this.equipecomboBox1.Name = "equipecomboBox1";
            this.equipecomboBox1.Size = new System.Drawing.Size(242, 21);
            this.equipecomboBox1.TabIndex = 1;
            this.equipecomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Equipe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(91, 92);
            this.dateTextBox.Mask = "00/00/0000 90:00";
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(107, 20);
            this.dateTextBox.TabIndex = 4;
            this.dateTextBox.ValidatingType = typeof(System.DateTime);
            this.dateTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.dateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTextBox_KeyDown);
            this.dateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cDataOriginalTextBox);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.duracaoTextBox);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.datefinalTextBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.valorTextBox);
            this.panel2.Controls.Add(this.statuscomboBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.serviceTextbox);
            this.panel2.Controls.Add(this.equipecomboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 161);
            this.panel2.TabIndex = 1;
            // 
            // cDataOriginalTextBox
            // 
            this.cDataOriginalTextBox.Enabled = false;
            this.cDataOriginalTextBox.Location = new System.Drawing.Point(526, 92);
            this.cDataOriginalTextBox.Mask = "00/00/0000 90:00";
            this.cDataOriginalTextBox.Name = "cDataOriginalTextBox";
            this.cDataOriginalTextBox.Size = new System.Drawing.Size(145, 20);
            this.cDataOriginalTextBox.TabIndex = 23;
            this.cDataOriginalTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(419, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 20);
            this.label18.TabIndex = 22;
            this.label18.Text = "Data Original";
            // 
            // duracaoTextBox
            // 
            this.duracaoTextBox.Enabled = false;
            this.duracaoTextBox.Location = new System.Drawing.Point(295, 129);
            this.duracaoTextBox.Name = "duracaoTextBox";
            this.duracaoTextBox.Size = new System.Drawing.Size(111, 20);
            this.duracaoTextBox.TabIndex = 6;
            this.duracaoTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(213, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Duração";
            // 
            // datefinalTextBox
            // 
            this.datefinalTextBox.Location = new System.Drawing.Point(296, 91);
            this.datefinalTextBox.Mask = "00/00/0000 90:00";
            this.datefinalTextBox.Name = "datefinalTextBox";
            this.datefinalTextBox.Size = new System.Drawing.Size(110, 20);
            this.datefinalTextBox.TabIndex = 5;
            this.datefinalTextBox.ValidatingType = typeof(System.DateTime);
            this.datefinalTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datefinalTextBox_KeyDown);
            this.datefinalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.datefinalTextBox_KeyPress_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "R$";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(91, 128);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(107, 21);
            this.valorTextBox.TabIndex = 7;
            this.valorTextBox.Text = "";
            this.valorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorTextBox_KeyPress);
            // 
            // statuscomboBox2
            // 
            this.statuscomboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.statuscomboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.statuscomboBox2.FormattingEnabled = true;
            this.statuscomboBox2.Location = new System.Drawing.Point(413, 18);
            this.statuscomboBox2.Name = "statuscomboBox2";
            this.statuscomboBox2.Size = new System.Drawing.Size(259, 21);
            this.statuscomboBox2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(350, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Serviço";
            // 
            // serviceTextbox
            // 
            this.serviceTextbox.Location = new System.Drawing.Point(91, 56);
            this.serviceTextbox.Name = "serviceTextbox";
            this.serviceTextbox.Size = new System.Drawing.Size(581, 21);
            this.serviceTextbox.TabIndex = 3;
            this.serviceTextbox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(213, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data final";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Obs";
            // 
            // obsTextBox
            // 
            this.obsTextBox.Location = new System.Drawing.Point(49, 6);
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(620, 116);
            this.obsTextBox.TabIndex = 20;
            this.obsTextBox.Text = "";
            // 
            // handleTextBox
            // 
            this.handleTextBox.Enabled = false;
            this.handleTextBox.Location = new System.Drawing.Point(647, 4);
            this.handleTextBox.Name = "handleTextBox";
            this.handleTextBox.Size = new System.Drawing.Size(54, 20);
            this.handleTextBox.TabIndex = 35;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 208);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 153);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.contatoTextBox);
            this.tabPage1.Controls.Add(this.cComplementoTextBox);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.bairroTextBox);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.referenciacomboBox1);
            this.tabPage1.Controls.Add(this.ruaTextBox);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.clienteTextBox);
            this.tabPage1.Controls.Add(this.numTextBox);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cidadeTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(685, 127);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente";
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.Location = new System.Drawing.Point(499, 12);
            this.contatoTextBox.Mask = "(00) 00000 - 0000";
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(169, 20);
            this.contatoTextBox.TabIndex = 34;
            // 
            // cComplementoTextBox
            // 
            this.cComplementoTextBox.Location = new System.Drawing.Point(94, 93);
            this.cComplementoTextBox.Name = "cComplementoTextBox";
            this.cComplementoTextBox.Size = new System.Drawing.Size(480, 21);
            this.cComplementoTextBox.TabIndex = 33;
            this.cComplementoTextBox.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(7, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "Compl.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(428, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Telefone";
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Location = new System.Drawing.Point(498, 66);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(170, 21);
            this.bairroTextBox.TabIndex = 13;
            this.bairroTextBox.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(434, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Bairro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cliente";
            // 
            // referenciacomboBox1
            // 
            this.referenciacomboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.referenciacomboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.referenciacomboBox1.FormattingEnabled = true;
            this.referenciacomboBox1.Location = new System.Drawing.Point(94, 38);
            this.referenciacomboBox1.Name = "referenciacomboBox1";
            this.referenciacomboBox1.Size = new System.Drawing.Size(328, 21);
            this.referenciacomboBox1.TabIndex = 10;
            this.referenciacomboBox1.SelectedIndexChanged += new System.EventHandler(this.referenciacomboBox1_SelectedIndexChanged_1);
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.Location = new System.Drawing.Point(94, 65);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(328, 21);
            this.ruaTextBox.TabIndex = 12;
            this.ruaTextBox.Text = "";
            this.ruaTextBox.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(580, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Nº";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Rua";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(94, 11);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(328, 21);
            this.clienteTextBox.TabIndex = 8;
            this.clienteTextBox.Text = "";
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(612, 92);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(56, 21);
            this.numTextBox.TabIndex = 14;
            this.numTextBox.Text = "";
            this.numTextBox.TextChanged += new System.EventHandler(this.numTextBox_TextChanged);
            this.numTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTextBox_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(6, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "Ref. End";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(434, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Cidade";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Location = new System.Drawing.Point(499, 39);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(170, 21);
            this.cidadeTextBox.TabIndex = 11;
            this.cidadeTextBox.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.cEHClienteAvisa);
            this.tabPage3.Controls.Add(this.cEHMedidaCombinada);
            this.tabPage3.Controls.Add(this.cEHRebocada);
            this.tabPage3.Controls.Add(this.cEHCOBERTA);
            this.tabPage3.Controls.Add(this.cEHFundamento);
            this.tabPage3.Controls.Add(this.obraProntocheckBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(685, 127);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Obra";
            // 
            // obraProntocheckBox
            // 
            this.obraProntocheckBox.AutoSize = true;
            this.obraProntocheckBox.Location = new System.Drawing.Point(16, 87);
            this.obraProntocheckBox.Name = "obraProntocheckBox";
            this.obraProntocheckBox.Size = new System.Drawing.Size(82, 17);
            this.obraProntocheckBox.TabIndex = 16;
            this.obraProntocheckBox.Text = "Obra pronta";
            this.obraProntocheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage2.Controls.Add(this.obsTextBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(685, 127);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Observacao";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(262, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Cadastro de serviços";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(579, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 45);
            this.button1.TabIndex = 54;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonCancelar);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(174, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 45);
            this.button2.TabIndex = 51;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonCadastrar);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(309, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 45);
            this.button3.TabIndex = 52;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Location = new System.Drawing.Point(444, 367);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(129, 45);
            this.buttonEditar.TabIndex = 53;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // cEHFundamento
            // 
            this.cEHFundamento.AutoSize = true;
            this.cEHFundamento.Location = new System.Drawing.Point(16, 18);
            this.cEHFundamento.Name = "cEHFundamento";
            this.cEHFundamento.Size = new System.Drawing.Size(85, 17);
            this.cEHFundamento.TabIndex = 20;
            this.cEHFundamento.Text = "Fundamento";
            this.cEHFundamento.UseVisualStyleBackColor = true;
            // 
            // cEHCOBERTA
            // 
            this.cEHCOBERTA.AutoSize = true;
            this.cEHCOBERTA.Location = new System.Drawing.Point(16, 41);
            this.cEHCOBERTA.Name = "cEHCOBERTA";
            this.cEHCOBERTA.Size = new System.Drawing.Size(63, 17);
            this.cEHCOBERTA.TabIndex = 21;
            this.cEHCOBERTA.Text = "Coberta";
            this.cEHCOBERTA.UseVisualStyleBackColor = true;
            // 
            // cEHRebocada
            // 
            this.cEHRebocada.AutoSize = true;
            this.cEHRebocada.Location = new System.Drawing.Point(16, 64);
            this.cEHRebocada.Name = "cEHRebocada";
            this.cEHRebocada.Size = new System.Drawing.Size(76, 17);
            this.cEHRebocada.TabIndex = 22;
            this.cEHRebocada.Text = "Rebocada";
            this.cEHRebocada.UseVisualStyleBackColor = true;
            // 
            // cEHMedidaCombinada
            // 
            this.cEHMedidaCombinada.AutoSize = true;
            this.cEHMedidaCombinada.Location = new System.Drawing.Point(158, 18);
            this.cEHMedidaCombinada.Name = "cEHMedidaCombinada";
            this.cEHMedidaCombinada.Size = new System.Drawing.Size(117, 17);
            this.cEHMedidaCombinada.TabIndex = 23;
            this.cEHMedidaCombinada.Text = "Medida Combinada";
            this.cEHMedidaCombinada.UseVisualStyleBackColor = true;
            // 
            // cEHClienteAvisa
            // 
            this.cEHClienteAvisa.AutoSize = true;
            this.cEHClienteAvisa.Location = new System.Drawing.Point(158, 41);
            this.cEHClienteAvisa.Name = "cEHClienteAvisa";
            this.cEHClienteAvisa.Size = new System.Drawing.Size(106, 17);
            this.cEHClienteAvisa.TabIndex = 24;
            this.cEHClienteAvisa.Text = "Cliente vai avisar";
            this.cEHClienteAvisa.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage4.Controls.Add(this.cEHInstalacao);
            this.tabPage4.Controls.Add(this.cEHSeparado);
            this.tabPage4.Controls.Add(this.cEHConfirmado);
            this.tabPage4.Controls.Add(this.semDataCheckBox);
            this.tabPage4.Controls.Add(this.encomendadocheckBox);
            this.tabPage4.Controls.Add(this.entreguecheckBox);
            this.tabPage4.Controls.Add(this.recebidocheckBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(685, 127);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pedido";
            // 
            // recebidocheckBox
            // 
            this.recebidocheckBox.AutoSize = true;
            this.recebidocheckBox.Location = new System.Drawing.Point(16, 66);
            this.recebidocheckBox.Name = "recebidocheckBox";
            this.recebidocheckBox.Size = new System.Drawing.Size(72, 17);
            this.recebidocheckBox.TabIndex = 19;
            this.recebidocheckBox.Text = "Recebido";
            this.recebidocheckBox.UseVisualStyleBackColor = true;
            // 
            // entreguecheckBox
            // 
            this.entreguecheckBox.AutoSize = true;
            this.entreguecheckBox.Location = new System.Drawing.Point(158, 43);
            this.entreguecheckBox.Name = "entreguecheckBox";
            this.entreguecheckBox.Size = new System.Drawing.Size(69, 17);
            this.entreguecheckBox.TabIndex = 20;
            this.entreguecheckBox.Text = "Entregue";
            this.entreguecheckBox.UseVisualStyleBackColor = true;
            // 
            // encomendadocheckBox
            // 
            this.encomendadocheckBox.AutoSize = true;
            this.encomendadocheckBox.Location = new System.Drawing.Point(16, 43);
            this.encomendadocheckBox.Name = "encomendadocheckBox";
            this.encomendadocheckBox.Size = new System.Drawing.Size(95, 17);
            this.encomendadocheckBox.TabIndex = 21;
            this.encomendadocheckBox.Text = "Encomendado";
            this.encomendadocheckBox.UseVisualStyleBackColor = true;
            // 
            // semDataCheckBox
            // 
            this.semDataCheckBox.AutoSize = true;
            this.semDataCheckBox.Location = new System.Drawing.Point(158, 66);
            this.semDataCheckBox.Name = "semDataCheckBox";
            this.semDataCheckBox.Size = new System.Drawing.Size(111, 17);
            this.semDataCheckBox.TabIndex = 22;
            this.semDataCheckBox.Text = "Sem data definida";
            this.semDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // cEHConfirmado
            // 
            this.cEHConfirmado.AutoSize = true;
            this.cEHConfirmado.Location = new System.Drawing.Point(16, 20);
            this.cEHConfirmado.Name = "cEHConfirmado";
            this.cEHConfirmado.Size = new System.Drawing.Size(79, 17);
            this.cEHConfirmado.TabIndex = 23;
            this.cEHConfirmado.Text = "Confirmado";
            this.cEHConfirmado.UseVisualStyleBackColor = true;
            // 
            // cEHSeparado
            // 
            this.cEHSeparado.AutoSize = true;
            this.cEHSeparado.Location = new System.Drawing.Point(16, 89);
            this.cEHSeparado.Name = "cEHSeparado";
            this.cEHSeparado.Size = new System.Drawing.Size(72, 17);
            this.cEHSeparado.TabIndex = 24;
            this.cEHSeparado.Text = "Separado";
            this.cEHSeparado.UseVisualStyleBackColor = true;
            // 
            // cEHInstalacao
            // 
            this.cEHInstalacao.AutoSize = true;
            this.cEHInstalacao.Location = new System.Drawing.Point(158, 20);
            this.cEHInstalacao.Name = "cEHInstalacao";
            this.cEHInstalacao.Size = new System.Drawing.Size(109, 17);
            this.cEHInstalacao.TabIndex = 25;
            this.cEHInstalacao.Text = "Pronto P/ Instalar";
            this.cEHInstalacao.UseVisualStyleBackColor = true;
            // 
            // RegisterService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(715, 416);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.handleTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RegisterService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox dateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox obsTextBox;
        private System.Windows.Forms.ComboBox statuscomboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox serviceTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox valorTextBox;
        public System.Windows.Forms.ComboBox equipecomboBox1;
        private System.Windows.Forms.MaskedTextBox datefinalTextBox;
        private System.Windows.Forms.TextBox handleTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox bairroTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox referenciacomboBox1;
        private System.Windows.Forms.RichTextBox ruaTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox clienteTextBox;
        private System.Windows.Forms.RichTextBox numTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox cidadeTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox obraProntocheckBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox duracaoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.RichTextBox cComplementoTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox contatoTextBox;
        private System.Windows.Forms.MaskedTextBox cDataOriginalTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox cEHClienteAvisa;
        private System.Windows.Forms.CheckBox cEHMedidaCombinada;
        private System.Windows.Forms.CheckBox cEHRebocada;
        private System.Windows.Forms.CheckBox cEHCOBERTA;
        private System.Windows.Forms.CheckBox cEHFundamento;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox cEHInstalacao;
        private System.Windows.Forms.CheckBox cEHSeparado;
        private System.Windows.Forms.CheckBox cEHConfirmado;
        private System.Windows.Forms.CheckBox semDataCheckBox;
        private System.Windows.Forms.CheckBox encomendadocheckBox;
        private System.Windows.Forms.CheckBox entreguecheckBox;
        private System.Windows.Forms.CheckBox recebidocheckBox;
    }
}