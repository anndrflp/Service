﻿namespace Service.CONTROL.Menu
{
    partial class GTableRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GTableRegister));
            this.button1 = new System.Windows.Forms.Button();
            this.cDataGridView = new System.Windows.Forms.DataGridView();
            this.paypeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paypeDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NewOnClick);
            // 
            // cDataGridView
            // 
            this.cDataGridView.AllowUserToAddRows = false;
            this.cDataGridView.AllowUserToDeleteRows = false;
            this.cDataGridView.AllowUserToOrderColumns = true;
            this.cDataGridView.AllowUserToResizeRows = false;
            this.cDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.cDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cDataGridView.Location = new System.Drawing.Point(87, 0);
            this.cDataGridView.MultiSelect = false;
            this.cDataGridView.Name = "cDataGridView";
            this.cDataGridView.ReadOnly = true;
            this.cDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.cDataGridView.RowHeadersVisible = false;
            this.cDataGridView.Size = new System.Drawing.Size(792, 628);
            this.cDataGridView.TabIndex = 1;
            this.cDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GerenciamentoCellDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dashboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GTableRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 627);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "GTableRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela";
            ((System.ComponentModel.ISupportInitialize)(this.cDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paypeDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView cDataGridView;
        private System.Windows.Forms.BindingSource paypeDataSetBindingSource;
        private System.Windows.Forms.Button button2;
    }
}