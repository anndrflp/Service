namespace Service.CONTROL.Relatorio
{
    partial class FServiceAll
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
            this.serviceGridView = new System.Windows.Forms.DataGridView();
            this.diaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.equipecomboBox = new System.Windows.Forms.ComboBox();
            this.statuscomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.referenciacomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cExitButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.serviceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cExitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceGridView
            // 
            this.serviceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.serviceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.serviceGridView.Location = new System.Drawing.Point(188, 1);
            this.serviceGridView.Name = "serviceGridView";
            this.serviceGridView.Size = new System.Drawing.Size(713, 554);
            this.serviceGridView.TabIndex = 0;
            this.serviceGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serviceGridView_CellDoubleClick);
            // 
            // diaTimePicker
            // 
            this.diaTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.diaTimePicker.Location = new System.Drawing.Point(65, 18);
            this.diaTimePicker.Name = "diaTimePicker";
            this.diaTimePicker.Size = new System.Drawing.Size(117, 20);
            this.diaTimePicker.TabIndex = 1;
            this.diaTimePicker.ValueChanged += new System.EventHandler(this.diaTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Equipe";
            // 
            // equipecomboBox
            // 
            this.equipecomboBox.FormattingEnabled = true;
            this.equipecomboBox.Location = new System.Drawing.Point(65, 44);
            this.equipecomboBox.Name = "equipecomboBox";
            this.equipecomboBox.Size = new System.Drawing.Size(117, 21);
            this.equipecomboBox.TabIndex = 4;
            this.equipecomboBox.SelectedIndexChanged += new System.EventHandler(this.equipecomboBox_SelectedIndexChanged);
            this.equipecomboBox.Click += new System.EventHandler(this.equipecomboBox_Click);
            // 
            // statuscomboBox
            // 
            this.statuscomboBox.FormattingEnabled = true;
            this.statuscomboBox.Location = new System.Drawing.Point(65, 71);
            this.statuscomboBox.Name = "statuscomboBox";
            this.statuscomboBox.Size = new System.Drawing.Size(117, 21);
            this.statuscomboBox.TabIndex = 6;
            this.statuscomboBox.Click += new System.EventHandler(this.statuscomboBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // referenciacomboBox
            // 
            this.referenciacomboBox.FormattingEnabled = true;
            this.referenciacomboBox.Location = new System.Drawing.Point(65, 97);
            this.referenciacomboBox.Name = "referenciacomboBox";
            this.referenciacomboBox.Size = new System.Drawing.Size(117, 21);
            this.referenciacomboBox.TabIndex = 8;
            this.referenciacomboBox.Click += new System.EventHandler(this.referenciacomboBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Referen.";
            // 
            // cExitButton
            // 
            this.cExitButton.Image = global::Service.Properties.Resources.exit__1_;
            this.cExitButton.Location = new System.Drawing.Point(113, 135);
            this.cExitButton.Name = "cExitButton";
            this.cExitButton.Size = new System.Drawing.Size(69, 71);
            this.cExitButton.TabIndex = 11;
            this.cExitButton.TabStop = false;
            this.cExitButton.Click += new System.EventHandler(this.cExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Service.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(16, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 71);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FServiceAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(893, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cExitButton);
            this.Controls.Add(this.referenciacomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statuscomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.equipecomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diaTimePicker);
            this.Controls.Add(this.serviceGridView);
            this.Name = "FServiceAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "todosServicos";
            ((System.ComponentModel.ISupportInitialize)(this.serviceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cExitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView serviceGridView;
        private System.Windows.Forms.DateTimePicker diaTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox equipecomboBox;
        private System.Windows.Forms.ComboBox statuscomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox referenciacomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox cExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}