namespace Service.CONTROL.Menu
{
    partial class FColumnRegister
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
            this.cTableTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cRegisterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cForeignKeyComboBox = new System.Windows.Forms.ComboBox();
            this.cIsForeignKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lenght = new System.Windows.Forms.TextBox();
            this.cDataTypeComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cIsRequiredCheckBox = new System.Windows.Forms.CheckBox();
            this.cActiveButton = new System.Windows.Forms.Button();
            this.cReturnButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cTableTextBox
            // 
            this.cTableTextBox.Location = new System.Drawing.Point(347, 27);
            this.cTableTextBox.Name = "cTableTextBox";
            this.cTableTextBox.ReadOnly = true;
            this.cTableTextBox.Size = new System.Drawing.Size(192, 20);
            this.cTableTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabela";
            // 
            // cRegisterButton
            // 
            this.cRegisterButton.Location = new System.Drawing.Point(566, 227);
            this.cRegisterButton.Name = "cRegisterButton";
            this.cRegisterButton.Size = new System.Drawing.Size(75, 23);
            this.cRegisterButton.TabIndex = 2;
            this.cRegisterButton.Text = "Gravar";
            this.cRegisterButton.UseVisualStyleBackColor = true;
            this.cRegisterButton.Click += new System.EventHandler(this.RegisterOnClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número";
            // 
            // cNumberTextBox
            // 
            this.cNumberTextBox.Location = new System.Drawing.Point(545, 27);
            this.cNumberTextBox.Name = "cNumberTextBox";
            this.cNumberTextBox.ReadOnly = true;
            this.cNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.cNumberTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            // 
            // ColumnName
            // 
            this.ColumnName.Location = new System.Drawing.Point(12, 27);
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Size = new System.Drawing.Size(204, 20);
            this.ColumnName.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(633, 160);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cForeignKeyComboBox);
            this.tabPage1.Controls.Add(this.cIsForeignKeyCheckBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Lenght);
            this.tabPage1.Controls.Add(this.cDataTypeComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 134);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Complemento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tabela foreign key";
            // 
            // cForeignKeyComboBox
            // 
            this.cForeignKeyComboBox.FormattingEnabled = true;
            this.cForeignKeyComboBox.Location = new System.Drawing.Point(324, 32);
            this.cForeignKeyComboBox.Name = "cForeignKeyComboBox";
            this.cForeignKeyComboBox.Size = new System.Drawing.Size(191, 21);
            this.cForeignKeyComboBox.TabIndex = 11;
            // 
            // cIsForeignKeyCheckBox
            // 
            this.cIsForeignKeyCheckBox.AutoSize = true;
            this.cIsForeignKeyCheckBox.Location = new System.Drawing.Point(529, 35);
            this.cIsForeignKeyCheckBox.Name = "cIsForeignKeyCheckBox";
            this.cIsForeignKeyCheckBox.Size = new System.Drawing.Size(82, 17);
            this.cIsForeignKeyCheckBox.TabIndex = 9;
            this.cIsForeignKeyCheckBox.Text = "Foreign Key";
            this.cIsForeignKeyCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tamanho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de dado";
            // 
            // Lenght
            // 
            this.Lenght.Location = new System.Drawing.Point(206, 33);
            this.Lenght.Name = "Lenght";
            this.Lenght.Size = new System.Drawing.Size(112, 20);
            this.Lenght.TabIndex = 9;
            this.Lenght.Tag = "Lenght";
            // 
            // cDataTypeComboBox
            // 
            this.cDataTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cDataTypeComboBox.FormattingEnabled = true;
            this.cDataTypeComboBox.Items.AddRange(new object[] {
            "Int",
            "Varchar"});
            this.cDataTypeComboBox.Location = new System.Drawing.Point(6, 33);
            this.cDataTypeComboBox.Name = "cDataTypeComboBox";
            this.cDataTypeComboBox.Size = new System.Drawing.Size(194, 21);
            this.cDataTypeComboBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(625, 134);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Observação";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cIsRequiredCheckBox
            // 
            this.cIsRequiredCheckBox.AutoSize = true;
            this.cIsRequiredCheckBox.Location = new System.Drawing.Point(242, 29);
            this.cIsRequiredCheckBox.Name = "cIsRequiredCheckBox";
            this.cIsRequiredCheckBox.Size = new System.Drawing.Size(77, 17);
            this.cIsRequiredCheckBox.TabIndex = 8;
            this.cIsRequiredCheckBox.Text = "Obrigatório";
            this.cIsRequiredCheckBox.UseVisualStyleBackColor = true;
            // 
            // cActiveButton
            // 
            this.cActiveButton.Location = new System.Drawing.Point(566, 227);
            this.cActiveButton.Name = "cActiveButton";
            this.cActiveButton.Size = new System.Drawing.Size(75, 23);
            this.cActiveButton.TabIndex = 9;
            this.cActiveButton.Text = "Liberar";
            this.cActiveButton.UseVisualStyleBackColor = true;
            this.cActiveButton.Click += new System.EventHandler(this.ActiveOnClick);
            // 
            // cReturnButton
            // 
            this.cReturnButton.Location = new System.Drawing.Point(566, 227);
            this.cReturnButton.Name = "cReturnButton";
            this.cReturnButton.Size = new System.Drawing.Size(75, 23);
            this.cReturnButton.TabIndex = 10;
            this.cReturnButton.Text = "Liberar";
            this.cReturnButton.UseVisualStyleBackColor = true;
            this.cReturnButton.Click += new System.EventHandler(this.ReturnOnClick);
            // 
            // FColumnRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 256);
            this.Controls.Add(this.cReturnButton);
            this.Controls.Add(this.cActiveButton);
            this.Controls.Add(this.cIsRequiredCheckBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ColumnName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cNumberTextBox);
            this.Controls.Add(this.cRegisterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cTableTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FColumnRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coluna";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cTableTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cRegisterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cIsRequiredCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Lenght;
        private System.Windows.Forms.ComboBox cDataTypeComboBox;
        private System.Windows.Forms.CheckBox cIsForeignKeyCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cForeignKeyComboBox;
        private System.Windows.Forms.Button cActiveButton;
        private System.Windows.Forms.Button cReturnButton;
        public System.Windows.Forms.TextBox ColumnName;
    }
}