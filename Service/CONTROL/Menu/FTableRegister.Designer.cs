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
            this.cTableNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cRegisterButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cNewColumnButton = new System.Windows.Forms.Button();
            this.cActiveButton = new System.Windows.Forms.Button();
            this.cReturnButton = new System.Windows.Forms.Button();
            this.cLastTableNameTextBox = new System.Windows.Forms.TextBox();
            this.cNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cTableNameTextBox
            // 
            this.cTableNameTextBox.Location = new System.Drawing.Point(13, 25);
            this.cTableNameTextBox.Name = "cTableNameTextBox";
            this.cTableNameTextBox.Size = new System.Drawing.Size(300, 20);
            this.cTableNameTextBox.TabIndex = 0;
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
            // cRegisterButton
            // 
            this.cRegisterButton.Location = new System.Drawing.Point(560, 266);
            this.cRegisterButton.Name = "cRegisterButton";
            this.cRegisterButton.Size = new System.Drawing.Size(75, 23);
            this.cRegisterButton.TabIndex = 3;
            this.cRegisterButton.Text = "Gravar";
            this.cRegisterButton.UseVisualStyleBackColor = true;
            this.cRegisterButton.Click += new System.EventHandler(this.RegisterOnClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 157);
            this.dataGridView1.TabIndex = 4;
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
            this.tabPage1.Controls.Add(this.dataGridView1);
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
            // cActiveButton
            // 
            this.cActiveButton.Location = new System.Drawing.Point(562, 266);
            this.cActiveButton.Name = "cActiveButton";
            this.cActiveButton.Size = new System.Drawing.Size(75, 23);
            this.cActiveButton.TabIndex = 6;
            this.cActiveButton.Text = "Liberar";
            this.cActiveButton.UseVisualStyleBackColor = true;
            this.cActiveButton.Click += new System.EventHandler(this.ActiveButtonOnClick);
            // 
            // cReturnButton
            // 
            this.cReturnButton.Location = new System.Drawing.Point(560, 266);
            this.cReturnButton.Name = "cReturnButton";
            this.cReturnButton.Size = new System.Drawing.Size(75, 23);
            this.cReturnButton.TabIndex = 7;
            this.cReturnButton.Text = "Voltar";
            this.cReturnButton.UseVisualStyleBackColor = true;
            this.cReturnButton.Click += new System.EventHandler(this.ReturnOnClick);
            // 
            // cLastTableNameTextBox
            // 
            this.cLastTableNameTextBox.Location = new System.Drawing.Point(596, 25);
            this.cLastTableNameTextBox.Name = "cLastTableNameTextBox";
            this.cLastTableNameTextBox.Size = new System.Drawing.Size(10, 20);
            this.cLastTableNameTextBox.TabIndex = 8;
            this.cLastTableNameTextBox.Visible = false;
            // 
            // cNumberTextBox
            // 
            this.cNumberTextBox.Location = new System.Drawing.Point(545, 25);
            this.cNumberTextBox.Name = "cNumberTextBox";
            this.cNumberTextBox.ReadOnly = true;
            this.cNumberTextBox.Size = new System.Drawing.Size(94, 20);
            this.cNumberTextBox.TabIndex = 9;
            this.cNumberTextBox.TabStop = false;
            this.cNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // FTableRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 293);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cNumberTextBox);
            this.Controls.Add(this.cLastTableNameTextBox);
            this.Controls.Add(this.cReturnButton);
            this.Controls.Add(this.cActiveButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cRegisterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cTableNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FTableRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cTableNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cRegisterButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button cNewColumnButton;
        private System.Windows.Forms.Button cActiveButton;
        private System.Windows.Forms.Button cReturnButton;
        private System.Windows.Forms.TextBox cLastTableNameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox cNumberTextBox;
        private System.Windows.Forms.Label label3;
    }
}