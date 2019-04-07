namespace Service.SV_SERVICE.Menu.FAll
{
    partial class FUpdateDate
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
            this.cCancelarButton = new System.Windows.Forms.Button();
            this.cAtualizar = new System.Windows.Forms.Button();
            this.Quantidade = new System.Windows.Forms.Label();
            this.cDiasBox = new System.Windows.Forms.TextBox();
            this.cOperacaoBox = new System.Windows.Forms.ComboBox();
            this.Operação = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cCancelarButton
            // 
            this.cCancelarButton.Location = new System.Drawing.Point(83, 66);
            this.cCancelarButton.Name = "cCancelarButton";
            this.cCancelarButton.Size = new System.Drawing.Size(62, 23);
            this.cCancelarButton.TabIndex = 0;
            this.cCancelarButton.Text = "Cancelar";
            this.cCancelarButton.UseVisualStyleBackColor = true;
            this.cCancelarButton.Click += new System.EventHandler(this.cCancelarButton_Click);
            // 
            // cAtualizar
            // 
            this.cAtualizar.Location = new System.Drawing.Point(12, 66);
            this.cAtualizar.Name = "cAtualizar";
            this.cAtualizar.Size = new System.Drawing.Size(65, 23);
            this.cAtualizar.TabIndex = 1;
            this.cAtualizar.Text = "Atualizar";
            this.cAtualizar.UseVisualStyleBackColor = true;
            this.cAtualizar.Click += new System.EventHandler(this.cAtualizar_Click);
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSize = true;
            this.Quantidade.Location = new System.Drawing.Point(12, 16);
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(28, 13);
            this.Quantidade.TabIndex = 2;
            this.Quantidade.Text = "Dias";
            // 
            // cDiasBox
            // 
            this.cDiasBox.Location = new System.Drawing.Point(72, 13);
            this.cDiasBox.Name = "cDiasBox";
            this.cDiasBox.Size = new System.Drawing.Size(73, 20);
            this.cDiasBox.TabIndex = 3;
            this.cDiasBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // cOperacaoBox
            // 
            this.cOperacaoBox.FormattingEnabled = true;
            this.cOperacaoBox.Items.AddRange(new object[] {
            "Mais",
            "Menos"});
            this.cOperacaoBox.Location = new System.Drawing.Point(72, 39);
            this.cOperacaoBox.Name = "cOperacaoBox";
            this.cOperacaoBox.Size = new System.Drawing.Size(73, 21);
            this.cOperacaoBox.TabIndex = 4;
            // 
            // Operação
            // 
            this.Operação.AutoSize = true;
            this.Operação.Location = new System.Drawing.Point(12, 42);
            this.Operação.Name = "Operação";
            this.Operação.Size = new System.Drawing.Size(54, 13);
            this.Operação.TabIndex = 5;
            this.Operação.Text = "Operação";
            // 
            // FUpdateDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(150, 102);
            this.Controls.Add(this.Operação);
            this.Controls.Add(this.cOperacaoBox);
            this.Controls.Add(this.cDiasBox);
            this.Controls.Add(this.Quantidade);
            this.Controls.Add(this.cAtualizar);
            this.Controls.Add(this.cCancelarButton);
            this.Name = "FUpdateDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUpdateDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cCancelarButton;
        private System.Windows.Forms.Button cAtualizar;
        private System.Windows.Forms.Label Quantidade;
        private System.Windows.Forms.TextBox cDiasBox;
        private System.Windows.Forms.ComboBox cOperacaoBox;
        private System.Windows.Forms.Label Operação;
    }
}