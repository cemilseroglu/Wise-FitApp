namespace Wise_FitApp.UI
{
    partial class OgunEkleForm
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
            this.cmbOgunTipi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.dgvBesinListesiOgun = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPorsiyon = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinListesiOgun)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsiyon)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOgunTipi
            // 
            this.cmbOgunTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgunTipi.FormattingEnabled = true;
            this.cmbOgunTipi.Items.AddRange(new object[] {
            "Kahvaltı",
            "Sabah Atıştırması",
            "Öğle Yemeği",
            "Öğleden Sonra Atıştırması",
            "Akşam Yemeği"});
            this.cmbOgunTipi.Location = new System.Drawing.Point(362, 31);
            this.cmbOgunTipi.Name = "cmbOgunTipi";
            this.cmbOgunTipi.Size = new System.Drawing.Size(168, 21);
            this.cmbOgunTipi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(266, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğün Tipi:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(252, 429);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(127, 38);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(403, 429);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(127, 38);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // dgvBesinListesiOgun
            // 
            this.dgvBesinListesiOgun.AllowUserToAddRows = false;
            this.dgvBesinListesiOgun.AllowUserToDeleteRows = false;
            this.dgvBesinListesiOgun.AllowUserToOrderColumns = true;
            this.dgvBesinListesiOgun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBesinListesiOgun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBesinListesiOgun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBesinListesiOgun.Location = new System.Drawing.Point(11, 90);
            this.dgvBesinListesiOgun.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dgvBesinListesiOgun.MultiSelect = false;
            this.dgvBesinListesiOgun.Name = "dgvBesinListesiOgun";
            this.dgvBesinListesiOgun.ReadOnly = true;
            this.dgvBesinListesiOgun.RowHeadersVisible = false;
            this.dgvBesinListesiOgun.RowHeadersWidth = 51;
            this.dgvBesinListesiOgun.RowTemplate.Height = 24;
            this.dgvBesinListesiOgun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBesinListesiOgun.Size = new System.Drawing.Size(519, 332);
            this.dgvBesinListesiOgun.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(7, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Besin Listesi:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 32);
            this.panel1.TabIndex = 24;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wise_FitApp.Properties.Resources.icons8_close_64;
            this.pictureBox1.Location = new System.Drawing.Point(523, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(266, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Porsiyon :";
            // 
            // nudPorsiyon
            // 
            this.nudPorsiyon.DecimalPlaces = 2;
            this.nudPorsiyon.Location = new System.Drawing.Point(362, 66);
            this.nudPorsiyon.Name = "nudPorsiyon";
            this.nudPorsiyon.Size = new System.Drawing.Size(120, 20);
            this.nudPorsiyon.TabIndex = 25;
            // 
            // OgunEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 472);
            this.Controls.Add(this.nudPorsiyon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBesinListesiOgun);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOgunTipi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgunEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgunEkleForm";
            this.Load += new System.EventHandler(this.OgunEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinListesiOgun)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsiyon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbOgunTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.DataGridView dgvBesinListesiOgun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPorsiyon;
    }
}