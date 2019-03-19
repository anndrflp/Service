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
            this.label1 = new System.Windows.Forms.Label();
            this.cRegisterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Handle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.IsList = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TranslateField = new System.Windows.Forms.ComboBox();
            this.IsBoolean = new System.Windows.Forms.CheckBox();
            this.IsComponent = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ForeignKeyTable = new System.Windows.Forms.ComboBox();
            this.IsForeignKey = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lenght = new System.Windows.Forms.TextBox();
            this.DataType = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.IsRequired = new System.Windows.Forms.CheckBox();
            this.cActiveButton = new System.Windows.Forms.Button();
            this.cReturnButton = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.ComboBox();
            this.IsPrimaryKey = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
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
            // Handle
            // 
            this.Handle.Location = new System.Drawing.Point(545, 27);
            this.Handle.Name = "Handle";
            this.Handle.ReadOnly = true;
            this.Handle.Size = new System.Drawing.Size(100, 20);
            this.Handle.TabIndex = 3;
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
            this.tabPage1.Controls.Add(this.IsPrimaryKey);
            this.tabPage1.Controls.Add(this.IsList);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.TranslateField);
            this.tabPage1.Controls.Add(this.IsBoolean);
            this.tabPage1.Controls.Add(this.IsComponent);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ForeignKeyTable);
            this.tabPage1.Controls.Add(this.IsForeignKey);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Lenght);
            this.tabPage1.Controls.Add(this.DataType);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 134);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " Complemento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // IsList
            // 
            this.IsList.AutoSize = true;
            this.IsList.Location = new System.Drawing.Point(528, 61);
            this.IsList.Name = "IsList";
            this.IsList.Size = new System.Drawing.Size(42, 17);
            this.IsList.TabIndex = 17;
            this.IsList.Text = "List";
            this.IsList.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Campo de tradução";
            // 
            // TranslateField
            // 
            this.TranslateField.FormattingEnabled = true;
            this.TranslateField.Location = new System.Drawing.Point(206, 81);
            this.TranslateField.Name = "TranslateField";
            this.TranslateField.Size = new System.Drawing.Size(191, 21);
            this.TranslateField.TabIndex = 15;
            // 
            // IsBoolean
            // 
            this.IsBoolean.AutoSize = true;
            this.IsBoolean.Enabled = false;
            this.IsBoolean.Location = new System.Drawing.Point(424, 60);
            this.IsBoolean.Name = "IsBoolean";
            this.IsBoolean.Size = new System.Drawing.Size(65, 17);
            this.IsBoolean.TabIndex = 14;
            this.IsBoolean.Text = "Boolean";
            this.IsBoolean.UseVisualStyleBackColor = true;
            // 
            // IsComponent
            // 
            this.IsComponent.AutoSize = true;
            this.IsComponent.Location = new System.Drawing.Point(528, 33);
            this.IsComponent.Name = "IsComponent";
            this.IsComponent.Size = new System.Drawing.Size(80, 17);
            this.IsComponent.TabIndex = 13;
            this.IsComponent.Text = "Component";
            this.IsComponent.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tabela foreign key";
            // 
            // ForeignKeyTable
            // 
            this.ForeignKeyTable.FormattingEnabled = true;
            this.ForeignKeyTable.Items.AddRange(new object[] {
            "TC_TABLE",
            "TC_COLUMN"});
            this.ForeignKeyTable.Location = new System.Drawing.Point(6, 81);
            this.ForeignKeyTable.Name = "ForeignKeyTable";
            this.ForeignKeyTable.Size = new System.Drawing.Size(191, 21);
            this.ForeignKeyTable.TabIndex = 11;
            this.ForeignKeyTable.DropDown += new System.EventHandler(this.TableForeignKeyDropDown);
            // 
            // IsForeignKey
            // 
            this.IsForeignKey.AutoSize = true;
            this.IsForeignKey.Location = new System.Drawing.Point(424, 33);
            this.IsForeignKey.Name = "IsForeignKey";
            this.IsForeignKey.Size = new System.Drawing.Size(82, 17);
            this.IsForeignKey.TabIndex = 9;
            this.IsForeignKey.Text = "Foreign Key";
            this.IsForeignKey.UseVisualStyleBackColor = true;
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
            this.Lenght.Size = new System.Drawing.Size(191, 20);
            this.Lenght.TabIndex = 9;
            this.Lenght.Tag = "Lenght";
            // 
            // DataType
            // 
            this.DataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataType.FormattingEnabled = true;
            this.DataType.Items.AddRange(new object[] {
            "INT",
            "VARCHAR",
            "BOOLEAN"});
            this.DataType.Location = new System.Drawing.Point(6, 33);
            this.DataType.Name = "DataType";
            this.DataType.Size = new System.Drawing.Size(194, 21);
            this.DataType.TabIndex = 0;
            this.DataType.SelectedIndexChanged += new System.EventHandler(this.DataTypeOnChanged);
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
            // IsRequired
            // 
            this.IsRequired.AutoSize = true;
            this.IsRequired.Location = new System.Drawing.Point(242, 29);
            this.IsRequired.Name = "IsRequired";
            this.IsRequired.Size = new System.Drawing.Size(77, 17);
            this.IsRequired.TabIndex = 8;
            this.IsRequired.Text = "Obrigatório";
            this.IsRequired.UseVisualStyleBackColor = true;
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
            // Table
            // 
            this.Table.FormattingEnabled = true;
            this.Table.Items.AddRange(new object[] {
            "TC_TABLE",
            "TC_COLUMN"});
            this.Table.Location = new System.Drawing.Point(347, 27);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(191, 21);
            this.Table.TabIndex = 18;
            // 
            // IsPrimaryKey
            // 
            this.IsPrimaryKey.AutoSize = true;
            this.IsPrimaryKey.Location = new System.Drawing.Point(425, 85);
            this.IsPrimaryKey.Name = "IsPrimaryKey";
            this.IsPrimaryKey.Size = new System.Drawing.Size(81, 17);
            this.IsPrimaryKey.TabIndex = 18;
            this.IsPrimaryKey.Text = "Primary Key";
            this.IsPrimaryKey.UseVisualStyleBackColor = true;
            // 
            // FColumnRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 256);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.cReturnButton);
            this.Controls.Add(this.cActiveButton);
            this.Controls.Add(this.IsRequired);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ColumnName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Handle);
            this.Controls.Add(this.cRegisterButton);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cRegisterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Handle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox IsRequired;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Lenght;
        private System.Windows.Forms.ComboBox DataType;
        private System.Windows.Forms.CheckBox IsForeignKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ForeignKeyTable;
        private System.Windows.Forms.Button cActiveButton;
        private System.Windows.Forms.Button cReturnButton;
        public System.Windows.Forms.TextBox ColumnName;
        private System.Windows.Forms.CheckBox IsComponent;
        private System.Windows.Forms.CheckBox IsBoolean;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TranslateField;
        private System.Windows.Forms.CheckBox IsList;
        private System.Windows.Forms.ComboBox Table;
        private System.Windows.Forms.CheckBox IsPrimaryKey;
    }
}