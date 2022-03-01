namespace Wise_FitApp.UI
{
    partial class BesinEkleForm
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
            this.dgvBesinListesi = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbBesinKategori = new System.Windows.Forms.ComboBox();
            this.txtBesinAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.nudKalori = new System.Windows.Forms.NumericUpDown();
            this.btnIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinListesi)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKalori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBesinListesi
            // 
            this.dgvBesinListesi.AllowUserToAddRows = false;
            this.dgvBesinListesi.AllowUserToDeleteRows = false;
            this.dgvBesinListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBesinListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBesinListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBesinListesi.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBesinListesi.Location = new System.Drawing.Point(11, 205);
            this.dgvBesinListesi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dgvBesinListesi.MultiSelect = false;
            this.dgvBesinListesi.Name = "dgvBesinListesi";
            this.dgvBesinListesi.ReadOnly = true;
            this.dgvBesinListesi.RowHeadersVisible = false;
            this.dgvBesinListesi.RowHeadersWidth = 51;
            this.dgvBesinListesi.RowTemplate.Height = 24;
            this.dgvBesinListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBesinListesi.Size = new System.Drawing.Size(768, 363);
            this.dgvBesinListesi.TabIndex = 21;
            this.dgvBesinListesi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvBesinListesi_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click_1);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            // 
            // cmbBesinKategori
            // 
            this.cmbBesinKategori.FormattingEnabled = true;
            this.cmbBesinKategori.Location = new System.Drawing.Point(167, 145);
            this.cmbBesinKategori.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbBesinKategori.Name = "cmbBesinKategori";
            this.cmbBesinKategori.Size = new System.Drawing.Size(240, 21);
            this.cmbBesinKategori.TabIndex = 20;
            // 
            // txtBesinAdi
            // 
            this.txtBesinAdi.Location = new System.Drawing.Point(167, 77);
            this.txtBesinAdi.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtBesinAdi.Name = "txtBesinAdi";
            this.txtBesinAdi.Size = new System.Drawing.Size(240, 20);
            this.txtBesinAdi.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Besin Kalori 100 gr :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Besin Kategorisi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Besin Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(556, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lütfen Girmek İstediginiz Besinin Adı , Kategorisi ve Kalorisini Giriniz";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(664, 138);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(115, 39);
            this.btnEkle.TabIndex = 23;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // nudKalori
            // 
            this.nudKalori.DecimalPlaces = 3;
            this.nudKalori.Location = new System.Drawing.Point(167, 116);
            this.nudKalori.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudKalori.Name = "nudKalori";
            this.nudKalori.Size = new System.Drawing.Size(120, 20);
            this.nudKalori.TabIndex = 22;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(537, 138);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(121, 39);
            this.btnIptal.TabIndex = 24;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // BesinEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 581);
            this.Controls.Add(this.dgvBesinListesi);
            this.Controls.Add(this.cmbBesinKategori);
            this.Controls.Add(this.txtBesinAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudKalori);
            this.Controls.Add(this.btnIptal);
            this.Name = "BesinEkleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BesinEkleForm";
            this.Load += new System.EventHandler(this.BesinEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinListesi)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudKalori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBesinListesi;
        private System.Windows.Forms.ComboBox cmbBesinKategori;
        private System.Windows.Forms.TextBox txtBesinAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.NumericUpDown nudKalori;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
    }
}