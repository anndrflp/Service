namespace Service.CONTROL.Menu.FDelete
{
    partial class FReferenceDelete
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
            this.cConfirmarButton = new System.Windows.Forms.Button();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.cCancelarButton = new System.Windows.Forms.Button();
            this.cReferencesComboBox = new System.Windows.Forms.ComboBox();
            this.ReferenciaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cConfirmarButton
            // 
            this.cConfirmarButton.Location = new System.Drawing.Point(167, 49);
            this.cConfirmarButton.Name = "cConfirmarButton";
            this.cConfirmarButton.Size = new System.Drawing.Size(78, 37);
            this.cConfirmarButton.TabIndex = 0;
            this.cConfirmarButton.Text = "Excluir";
            this.cConfirmarButton.UseVisualStyleBackColor = true;
            this.cConfirmarButton.Click += new System.EventHandler(this.cConfirmarButton_Click);
            // 
            // cCancelarButton
            // 
            this.cCancelarButton.Location = new System.Drawing.Point(251, 49);
            this.cCancelarButton.Name = "cCancelarButton";
            this.cCancelarButton.Size = new System.Drawing.Size(92, 37);
            this.cCancelarButton.TabIndex = 1;
            this.cCancelarButton.Text = "Cancelar";
            this.cCancelarButton.UseVisualStyleBackColor = true;
            this.cCancelarButton.Click += new System.EventHandler(this.cCancelarButton_Click);
            // 
            // cReferencesComboBox
            // 
            this.cReferencesComboBox.FormattingEnabled = true;
            this.cReferencesComboBox.Location = new System.Drawing.Point(109, 22);
            this.cReferencesComboBox.Name = "cReferencesComboBox";
            this.cReferencesComboBox.Size = new System.Drawing.Size(234, 21);
            this.cReferencesComboBox.TabIndex = 2;
            // 
            // ReferenciaLabel
            // 
            this.ReferenciaLabel.AutoSize = true;
            this.ReferenciaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenciaLabel.Location = new System.Drawing.Point(12, 20);
            this.ReferenciaLabel.Name = "ReferenciaLabel";
            this.ReferenciaLabel.Size = new System.Drawing.Size(91, 20);
            this.ReferenciaLabel.TabIndex = 3;
            this.ReferenciaLabel.Text = "Referencia ";
            // 
            // FReferenceDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 94);
            this.Controls.Add(this.ReferenciaLabel);
            this.Controls.Add(this.cReferencesComboBox);
            this.Controls.Add(this.cCancelarButton);
            this.Controls.Add(this.cConfirmarButton);
            this.Name = "FReferenceDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exclusão de referencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cConfirmarButton;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Button cCancelarButton;
        private System.Windows.Forms.ComboBox cReferencesComboBox;
        private System.Windows.Forms.Label ReferenciaLabel;
    }
}