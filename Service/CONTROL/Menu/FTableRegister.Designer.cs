namespace Service.CONTROL.Menu
{
    partial class FTableRegister
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
            this.TableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.columnDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cNewColumnButton = new System.Windows.Forms.Button();
            this.Active = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.cLastTableNameTextBox = new System.Windows.Forms.TextBox();
            this.Handle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FormName = new System.Windows.Forms.Label();
            this.Form = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.columnDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableName
            // 
            this.TableName.Location = new System.Drawing.Point(13, 25);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(257, 20);
            this.TableName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(560, 266);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 3;
            this.Register.Text = "Gravar";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.RegisterOnClick);
            // 
            // columnDataGridView
            // 
            this.columnDataGridView.AllowUserToAddRows = false;
            this.columnDataGridView.AllowUserToDeleteRows = false;
            this.columnDataGridView.AllowUserToResizeRows = false;
            this.columnDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.columnDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.columnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.columnDataGridView.Location = new System.Drawing.Point(0, 26);
            this.columnDataGridView.MultiSelect = false;
            this.columnDataGridView.Name = "columnDataGridView";
            this.columnDataGridView.ReadOnly = true;
            this.columnDataGridView.RowHeadersVisible = false;
            this.columnDataGridView.Size = new System.Drawing.Size(618, 157);
            this.columnDataGridView.TabIndex = 4;
            this.columnDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ColumnCellDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 209);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(618, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Descrição";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Observação";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(4, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(611, 153);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cNewColumnButton);
            this.tabPage1.Controls.Add(this.columnDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 183);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Colunas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cNewColumnButton
            // 
            this.cNewColumnButton.Location = new System.Drawing.Point(568, 1);
            this.cNewColumnButton.Name = "cNewColumnButton";
            this.cNewColumnButton.Size = new System.Drawing.Size(50, 24);
            this.cNewColumnButton.TabIndex = 6;
            this.cNewColumnButton.Text = "+";
            this.cNewColumnButton.UseVisualStyleBackColor = true;
            this.cNewColumnButton.Click += new System.EventHandler(this.NewColumnOnClick);
            // 
            // Active
            // 
            this.Active.Location = new System.Drawing.Point(562, 266);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(75, 23);
            this.Active.TabIndex = 6;
            this.Active.Text = "Liberar";
            this.Active.UseVisualStyleBackColor = true;
            this.Active.Click += new System.EventHandler(this.ActiveButtonOnClick);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(560, 266);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(75, 23);
            this.Return.TabIndex = 7;
            this.Return.Text = "Voltar";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.ReturnOnClick);
            // 
            // cLastTableNameTextBox
            // 
            this.cLastTableNameTextBox.Location = new System.Drawing.Point(596, 25);
            this.cLastTableNameTextBox.Name = "cLastTableNameTextBox";
            this.cLastTableNameTextBox.Size = new System.Drawing.Size(10, 20);
            this.cLastTableNameTextBox.TabIndex = 8;
            this.cLastTableNameTextBox.Visible = false;
            // 
            // Handle
            // 
            this.Handle.Location = new System.Drawing.Point(545, 25);
            this.Handle.Name = "Handle";
            this.Handle.ReadOnly = true;
            this.Handle.Size = new System.Drawing.Size(94, 20);
            this.Handle.TabIndex = 9;
            this.Handle.TabStop = false;
            this.Handle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Número";
            // 
            // FormName
            // 
            this.FormName.AutoSize = true;
            this.FormName.Location = new System.Drawing.Point(272, 9);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(55, 13);
            this.FormName.TabIndex = 12;
            this.FormName.Text = "Formulário";
            // 
            // Form
            // 
            this.Form.Location = new System.Drawing.Point(275, 25);
            this.Form.Name = "Form";
            this.Form.Size = new System.Drawing.Size(264, 20);
            this.Form.TabIndex = 11;
            // 
            // FTableRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 293);
            this.Controls.Add(this.FormName);
            this.Controls.Add(this.Form);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Handle);
            this.Controls.Add(this.cLastTableNameTextBox);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Active);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FTableRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela";
            ((System.ComponentModel.ISupportInitialize)(this.columnDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.DataGridView columnDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cNewColumnButton;
        private System.Windows.Forms.Button Active;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.TextBox cLastTableNameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox Handle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.TextBox Form;
    }
}