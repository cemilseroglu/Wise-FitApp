namespace Wise_FitApp.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblToplamKalori = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListeYenile = new System.Windows.Forms.Button();
            this.dgvOgunListesiMain = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pbOgunEkle = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egzersizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.besinEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAlinmasiGerekenKalori = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kiloGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunListesiMain)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOgunEkle)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToplamKalori
            // 
            this.lblToplamKalori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKalori.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblToplamKalori.Location = new System.Drawing.Point(33, 303);
            this.lblToplamKalori.Name = "lblToplamKalori";
            this.lblToplamKalori.Size = new System.Drawing.Size(214, 49);
            this.lblToplamKalori.TabIndex = 11;
            this.lblToplamKalori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnListeYenile);
            this.panel1.Controls.Add(this.dgvOgunListesiMain);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbOgunEkle);
            this.panel1.Location = new System.Drawing.Point(259, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 456);
            this.panel1.TabIndex = 9;
            // 
            // btnListeYenile
            // 
            this.btnListeYenile.Location = new System.Drawing.Point(68, 6);
            this.btnListeYenile.Name = "btnListeYenile";
            this.btnListeYenile.Size = new System.Drawing.Size(108, 23);
            this.btnListeYenile.TabIndex = 5;
            this.btnListeYenile.Text = "Listeyi Yenile";
            this.btnListeYenile.UseVisualStyleBackColor = true;
            this.btnListeYenile.Click += new System.EventHandler(this.btnListeYenile_Click);
            // 
            // dgvOgunListesiMain
            // 
            this.dgvOgunListesiMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgunListesiMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOgunListesiMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgunListesiMain.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvOgunListesiMain.Location = new System.Drawing.Point(71, 33);
            this.dgvOgunListesiMain.MultiSelect = false;
            this.dgvOgunListesiMain.Name = "dgvOgunListesiMain";
            this.dgvOgunListesiMain.ReadOnly = true;
            this.dgvOgunListesiMain.RowHeadersVisible = false;
            this.dgvOgunListesiMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgunListesiMain.Size = new System.Drawing.Size(776, 420);
            this.dgvOgunListesiMain.TabIndex = 4;
            this.dgvOgunListesiMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvOgunListesiMain_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(87, 26);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(5, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğün Ekle";
            // 
            // pbOgunEkle
            // 
            this.pbOgunEkle.Image = ((System.Drawing.Image)(resources.GetObject("pbOgunEkle.Image")));
            this.pbOgunEkle.Location = new System.Drawing.Point(6, 6);
            this.pbOgunEkle.Name = "pbOgunEkle";
            this.pbOgunEkle.Size = new System.Drawing.Size(56, 50);
            this.pbOgunEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOgunEkle.TabIndex = 1;
            this.pbOgunEkle.TabStop = false;
            this.pbOgunEkle.Click += new System.EventHandler(this.pbOgunEkle_Click);
            this.pbOgunEkle.MouseEnter += new System.EventHandler(this.pbOgunEkle_MouseEnter);
            this.pbOgunEkle.MouseLeave += new System.EventHandler(this.pbOgunEkle_MouseLeave);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(13, 43);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.raporToolStripMenuItem.Text = "Rapor";
            this.raporToolStripMenuItem.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // egzersizToolStripMenuItem
            // 
            this.egzersizToolStripMenuItem.Name = "egzersizToolStripMenuItem";
            this.egzersizToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.egzersizToolStripMenuItem.Text = "Egzersiz";
            this.egzersizToolStripMenuItem.Click += new System.EventHandler(this.egzersizToolStripMenuItem_Click);
            // 
            // besinEkleToolStripMenuItem
            // 
            this.besinEkleToolStripMenuItem.Name = "besinEkleToolStripMenuItem";
            this.besinEkleToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.besinEkleToolStripMenuItem.Text = "Besin Ekle";
            this.besinEkleToolStripMenuItem.Click += new System.EventHandler(this.besinEkleToolStripMenuItem_Click);
            // 
            // lblAlinmasiGerekenKalori
            // 
            this.lblAlinmasiGerekenKalori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlinmasiGerekenKalori.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAlinmasiGerekenKalori.Location = new System.Drawing.Point(29, 214);
            this.lblAlinmasiGerekenKalori.Name = "lblAlinmasiGerekenKalori";
            this.lblAlinmasiGerekenKalori.Size = new System.Drawing.Size(218, 64);
            this.lblAlinmasiGerekenKalori.TabIndex = 10;
            this.lblAlinmasiGerekenKalori.Text = "Alınması Gereken Günlük Kalori";
            this.lblAlinmasiGerekenKalori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.besinEkleToolStripMenuItem,
            this.egzersizToolStripMenuItem,
            this.raporToolStripMenuItem,
            this.kiloGüncelleToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(463, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 37);
            this.panel2.TabIndex = 13;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wise_FitApp.Properties.Resources.icons8_close_64;
            this.pictureBox1.Location = new System.Drawing.Point(1081, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // kiloGüncelleToolStripMenuItem
            // 
            this.kiloGüncelleToolStripMenuItem.Name = "kiloGüncelleToolStripMenuItem";
            this.kiloGüncelleToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.kiloGüncelleToolStripMenuItem.Text = "Kilo Güncelle";
            this.kiloGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kiloGüncelleToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1121, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblToplamKalori);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblAlinmasiGerekenKalori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunListesiMain)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbOgunEkle)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblToplamKalori;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egzersizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem besinEkleToolStripMenuItem;
        private System.Windows.Forms.Label lblAlinmasiGerekenKalori;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvOgunListesiMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbOgunEkle;
        private System.Windows.Forms.Button btnListeYenile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem kiloGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}