namespace Wise_FitApp.UI
{
    partial class RaporForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnButunListe = new System.Windows.Forms.Button();
            this.btnAylikListe = new System.Windows.Forms.Button();
            this.btnHaftalikListe = new System.Windows.Forms.Button();
            this.dgvRaporListesi = new System.Windows.Forms.DataGridView();
            this.lblPeriyodikKaloriToplam = new System.Windows.Forms.Label();
            this.btnBesinIstatistikleri = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 33);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Wise_FitApp.Properties.Resources.icons8_close_64;
            this.pictureBox2.Location = new System.Drawing.Point(925, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnButunListe
            // 
            this.btnButunListe.Location = new System.Drawing.Point(30, 39);
            this.btnButunListe.Name = "btnButunListe";
            this.btnButunListe.Size = new System.Drawing.Size(178, 23);
            this.btnButunListe.TabIndex = 1;
            this.btnButunListe.Text = "Bütün Öğün Listesi";
            this.btnButunListe.UseVisualStyleBackColor = true;
            this.btnButunListe.Click += new System.EventHandler(this.btnButunListe_Click);
            // 
            // btnAylikListe
            // 
            this.btnAylikListe.Location = new System.Drawing.Point(561, 39);
            this.btnAylikListe.Name = "btnAylikListe";
            this.btnAylikListe.Size = new System.Drawing.Size(178, 23);
            this.btnAylikListe.TabIndex = 1;
            this.btnAylikListe.Text = "Son Bir Ayın Öğün Listesi";
            this.btnAylikListe.UseVisualStyleBackColor = true;
            this.btnAylikListe.Click += new System.EventHandler(this.btnAylikListe_Click);
            // 
            // btnHaftalikListe
            // 
            this.btnHaftalikListe.Location = new System.Drawing.Point(297, 39);
            this.btnHaftalikListe.Name = "btnHaftalikListe";
            this.btnHaftalikListe.Size = new System.Drawing.Size(178, 23);
            this.btnHaftalikListe.TabIndex = 1;
            this.btnHaftalikListe.Text = "Son Bir Haftanın Öğün Listesi";
            this.btnHaftalikListe.UseVisualStyleBackColor = true;
            this.btnHaftalikListe.Click += new System.EventHandler(this.btnHaftalikListe_Click);
            // 
            // dgvRaporListesi
            // 
            this.dgvRaporListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRaporListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRaporListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporListesi.Location = new System.Drawing.Point(208, 77);
            this.dgvRaporListesi.MultiSelect = false;
            this.dgvRaporListesi.Name = "dgvRaporListesi";
            this.dgvRaporListesi.ReadOnly = true;
            this.dgvRaporListesi.RowHeadersVisible = false;
            this.dgvRaporListesi.Size = new System.Drawing.Size(734, 429);
            this.dgvRaporListesi.TabIndex = 2;
            // 
            // lblPeriyodikKaloriToplam
            // 
            this.lblPeriyodikKaloriToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPeriyodikKaloriToplam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPeriyodikKaloriToplam.Location = new System.Drawing.Point(12, 96);
            this.lblPeriyodikKaloriToplam.Name = "lblPeriyodikKaloriToplam";
            this.lblPeriyodikKaloriToplam.Size = new System.Drawing.Size(190, 127);
            this.lblPeriyodikKaloriToplam.TabIndex = 3;
            this.lblPeriyodikKaloriToplam.Text = "Günlük Kalori Toplamı  1900 kcal";
            this.lblPeriyodikKaloriToplam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBesinIstatistikleri
            // 
            this.btnBesinIstatistikleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBesinIstatistikleri.Location = new System.Drawing.Point(16, 337);
            this.btnBesinIstatistikleri.Name = "btnBesinIstatistikleri";
            this.btnBesinIstatistikleri.Size = new System.Drawing.Size(186, 59);
            this.btnBesinIstatistikleri.TabIndex = 4;
            this.btnBesinIstatistikleri.Text = "Besin İstatistikleri";
            this.btnBesinIstatistikleri.UseVisualStyleBackColor = true;
            this.btnBesinIstatistikleri.Click += new System.EventHandler(this.btnBesinIstatistikleri_Click);
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(954, 518);
            this.Controls.Add(this.btnBesinIstatistikleri);
            this.Controls.Add(this.lblPeriyodikKaloriToplam);
            this.Controls.Add(this.dgvRaporListesi);
            this.Controls.Add(this.btnHaftalikListe);
            this.Controls.Add(this.btnAylikListe);
            this.Controls.Add(this.btnButunListe);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporForm";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnButunListe;
        private System.Windows.Forms.Button btnAylikListe;
        private System.Windows.Forms.Button btnHaftalikListe;
        private System.Windows.Forms.DataGridView dgvRaporListesi;
        private System.Windows.Forms.Label lblPeriyodikKaloriToplam;
        private System.Windows.Forms.Button btnBesinIstatistikleri;
    }
}