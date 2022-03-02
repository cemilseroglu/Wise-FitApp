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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinListesiOgun)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOgunTipi
            // 
            this.cmbOgunTipi.FormattingEnabled = true;
            this.cmbOgunTipi.Items.AddRange(new object[] {
            "Kahvaltı",
            "Sabah Atıştırması",
            "Öğle Yemeği",
            "Öğleden Sonra Atıştırması",
            "Akşam Yemeği"});
            this.cmbOgunTipi.Location = new System.Drawing.Point(634, 50);
            this.cmbOgunTipi.Name = "cmbOgunTipi";
            this.cmbOgunTipi.Size = new System.Drawing.Size(168, 21);
            this.cmbOgunTipi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(533, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Öğün Tipi:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(537, 462);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(127, 38);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(670, 462);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(127, 38);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // dgvBesinListesiOgun
            // 
            this.dgvBesinListesiOgun.AllowUserToAddRows = false;
            this.dgvBesinListesiOgun.AllowUserToDeleteRows = false;
            this.dgvBesinListesiOgun.AllowUserToOrderColumns = true;
            this.dgvBesinListesiOgun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBesinListesiOgun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBesinListesiOgun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBesinListesiOgun.Location = new System.Drawing.Point(7, 78);
            this.dgvBesinListesiOgun.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dgvBesinListesiOgun.MultiSelect = false;
            this.dgvBesinListesiOgun.Name = "dgvBesinListesiOgun";
            this.dgvBesinListesiOgun.ReadOnly = true;
            this.dgvBesinListesiOgun.RowHeadersVisible = false;
            this.dgvBesinListesiOgun.RowHeadersWidth = 51;
            this.dgvBesinListesiOgun.RowTemplate.Height = 24;
            this.dgvBesinListesiOgun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBesinListesiOgun.Size = new System.Drawing.Size(795, 363);
            this.dgvBesinListesiOgun.TabIndex = 22;
            // 
            // OgunEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 512);
            this.Controls.Add(this.dgvBesinListesiOgun);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOgunTipi);
            this.Name = "OgunEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgunEkleForm";
            this.Load += new System.EventHandler(this.OgunEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinListesiOgun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbOgunTipi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.DataGridView dgvBesinListesiOgun;
    }
}