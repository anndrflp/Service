namespace Service.zCONTROL.Alter
{
    partial class AlterDate
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
            this.button2 = new System.Windows.Forms.Button();
            this.ordemtextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datemaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataFinalmaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ordemtextBox1
            // 
            this.ordemtextBox1.Location = new System.Drawing.Point(114, 21);
            this.ordemtextBox1.Name = "ordemtextBox1";
            this.ordemtextBox1.Size = new System.Drawing.Size(120, 20);
            this.ordemtextBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data inicial";
            // 
            // datemaskedTextBox1
            // 
            this.datemaskedTextBox1.Location = new System.Drawing.Point(114, 50);
            this.datemaskedTextBox1.Mask = "00/00/0000 90:00";
            this.datemaskedTextBox1.Name = "datemaskedTextBox1";
            this.datemaskedTextBox1.Size = new System.Drawing.Size(120, 20);
            this.datemaskedTextBox1.TabIndex = 6;
            this.datemaskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data final";
            // 
            // dataFinalmaskedTextBox1
            // 
            this.dataFinalmaskedTextBox1.Location = new System.Drawing.Point(114, 79);
            this.dataFinalmaskedTextBox1.Mask = "00/00/0000 90:00";
            this.dataFinalmaskedTextBox1.Name = "dataFinalmaskedTextBox1";
            this.dataFinalmaskedTextBox1.Size = new System.Drawing.Size(120, 20);
            this.dataFinalmaskedTextBox1.TabIndex = 8;
            this.dataFinalmaskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // AlterDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(240, 160);
            this.Controls.Add(this.dataFinalmaskedTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datemaskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordemtextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AlterDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ordemtextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox datemaskedTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox dataFinalmaskedTextBox1;
    }
}