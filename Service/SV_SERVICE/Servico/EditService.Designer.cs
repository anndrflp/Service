namespace Service.zCONTROL
{
    partial class Service
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.equipecomboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.duracaoTextBox = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.RichTextBox();
            this.obsTextBox = new System.Windows.Forms.RichTextBox();
            this.statuscomboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.serviceTextbox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clienteTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ruaTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cidadeTextBox = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bairroTextBox = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.contatoTextBox = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.numTextBox = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(450, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(6, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 50);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(9, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // equipecomboBox1
            // 
            this.equipecomboBox1.FormattingEnabled = true;
            this.equipecomboBox1.Location = new System.Drawing.Point(91, 16);
            this.equipecomboBox1.Name = "equipecomboBox1";
            this.equipecomboBox1.Size = new System.Drawing.Size(140, 21);
            this.equipecomboBox1.TabIndex = 2;
            this.equipecomboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Equipe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(91, 62);
            this.dateTextBox.Mask = "0000/00/00 00:00:00";
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(140, 20);
            this.dateTextBox.TabIndex = 6;
            this.dateTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.dateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dateTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // duracaoTextBox
            // 
            this.duracaoTextBox.Location = new System.Drawing.Point(193, 106);
            this.duracaoTextBox.Mask = "00000";
            this.duracaoTextBox.Name = "duracaoTextBox";
            this.duracaoTextBox.Size = new System.Drawing.Size(38, 20);
            this.duracaoTextBox.TabIndex = 10;
            this.duracaoTextBox.ValidatingType = typeof(int);
            this.duracaoTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            this.duracaoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.duracaoTextBox_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.valorTextBox);
            this.panel2.Controls.Add(this.obsTextBox);
            this.panel2.Controls.Add(this.statuscomboBox2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.serviceTextbox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.equipecomboBox1);
            this.panel2.Controls.Add(this.duracaoTextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dateTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 161);
            this.panel2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(455, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Valor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(251, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Obs";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(522, 59);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(150, 21);
            this.valorTextBox.TabIndex = 18;
            this.valorTextBox.Text = "";
            this.valorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valorTextBox_KeyPress);
            // 
            // obsTextBox
            // 
            this.obsTextBox.Location = new System.Drawing.Point(318, 106);
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(354, 21);
            this.obsTextBox.TabIndex = 16;
            this.obsTextBox.Text = "";
            // 
            // statuscomboBox2
            // 
            this.statuscomboBox2.FormattingEnabled = true;
            this.statuscomboBox2.Location = new System.Drawing.Point(318, 59);
            this.statuscomboBox2.Name = "statuscomboBox2";
            this.statuscomboBox2.Size = new System.Drawing.Size(117, 21);
            this.statuscomboBox2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(251, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(251, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Serviço";
            // 
            // serviceTextbox
            // 
            this.serviceTextbox.Location = new System.Drawing.Point(318, 16);
            this.serviceTextbox.Name = "serviceTextbox";
            this.serviceTextbox.Size = new System.Drawing.Size(354, 21);
            this.serviceTextbox.TabIndex = 12;
            this.serviceTextbox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Duração (Em minutos)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(2, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cliente";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(90, 187);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(325, 21);
            this.clienteTextBox.TabIndex = 20;
            this.clienteTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Rua";
            // 
            // ruaTextBox
            // 
            this.ruaTextBox.Location = new System.Drawing.Point(90, 226);
            this.ruaTextBox.Name = "ruaTextBox";
            this.ruaTextBox.Size = new System.Drawing.Size(325, 21);
            this.ruaTextBox.TabIndex = 22;
            this.ruaTextBox.Text = "";
            this.ruaTextBox.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(434, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Cidade";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.Location = new System.Drawing.Point(499, 188);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(172, 21);
            this.cidadeTextBox.TabIndex = 24;
            this.cidadeTextBox.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(434, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Bairro";
            // 
            // bairroTextBox
            // 
            this.bairroTextBox.Location = new System.Drawing.Point(499, 225);
            this.bairroTextBox.Name = "bairroTextBox";
            this.bairroTextBox.Size = new System.Drawing.Size(172, 21);
            this.bairroTextBox.TabIndex = 26;
            this.bairroTextBox.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(2, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Contato";
            // 
            // contatoTextBox
            // 
            this.contatoTextBox.Location = new System.Drawing.Point(90, 265);
            this.contatoTextBox.Name = "contatoTextBox";
            this.contatoTextBox.Size = new System.Drawing.Size(325, 21);
            this.contatoTextBox.TabIndex = 28;
            this.contatoTextBox.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(434, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Num";
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(499, 265);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(172, 21);
            this.numTextBox.TabIndex = 30;
            this.numTextBox.Text = "";
            this.numTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTextBox_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(228, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(693, 360);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.contatoTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bairroTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ruaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox dateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox duracaoTextBox;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox clienteTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ruaTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox cidadeTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox bairroTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox contatoTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox numTextBox;
        public System.Windows.Forms.ComboBox equipecomboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}