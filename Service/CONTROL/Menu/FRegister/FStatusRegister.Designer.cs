namespace Service.CONTROL.Menu.Register
{
    partial class FStatusRegister
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
            this.cStatusTextBox = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.Label();
            this.cCadastrarButton = new System.Windows.Forms.Button();
            this.cCancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cStatusTextBox
            // 
            this.cStatusTextBox.Location = new System.Drawing.Point(58, 15);
            this.cStatusTextBox.Name = "cStatusTextBox";
            this.cStatusTextBox.Size = new System.Drawing.Size(251, 20);
            this.cStatusTextBox.TabIndex = 7;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 18);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 6;
            this.Status.Text = "Status";
            // 
            // cCadastrarButton
            // 
            this.cCadastrarButton.Location = new System.Drawing.Point(153, 44);
            this.cCadastrarButton.Name = "cCadastrarButton";
            this.cCadastrarButton.Size = new System.Drawing.Size(75, 23);
            this.cCadastrarButton.TabIndex = 5;
            this.cCadastrarButton.Text = "Cadastrar";
            this.cCadastrarButton.UseVisualStyleBackColor = true;
            this.cCadastrarButton.Click += new System.EventHandler(this.cCadastrarButton_Click);
            // 
            // cCancelarButton
            // 
            this.cCancelarButton.Location = new System.Drawing.Point(234, 44);
            this.cCancelarButton.Name = "cCancelarButton";
            this.cCancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cCancelarButton.TabIndex = 4;
            this.cCancelarButton.Text = "Cancelar";
            this.cCancelarButton.UseVisualStyleBackColor = true;
            // 
            // FStatusRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(321, 83);
            this.Controls.Add(this.cStatusTextBox);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.cCadastrarButton);
            this.Controls.Add(this.cCancelarButton);
            this.Name = "FStatusRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStatusRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cStatusTextBox;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button cCadastrarButton;
        private System.Windows.Forms.Button cCancelarButton;
    }
}