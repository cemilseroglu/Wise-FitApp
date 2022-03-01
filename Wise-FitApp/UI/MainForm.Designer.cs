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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblToplamKalori = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pbOgunEkle = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egzersizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.besinEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAlinmasiGerekenKalori = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOgunEkle)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblToplamKalori
            // 
            this.lblToplamKalori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKalori.Location = new System.Drawing.Point(22, 301);
            this.lblToplamKalori.Name = "lblToplamKalori";
            this.lblToplamKalori.Size = new System.Drawing.Size(214, 49);
            this.lblToplamKalori.TabIndex = 11;
            this.lblToplamKalori.Text = "0/2100 (kcal)";
            this.lblToplamKalori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbOgunEkle);
            this.panel1.Location = new System.Drawing.Point(259, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 401);
            this.panel1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 385);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğün Ekle";
            // 
            // pbOgunEkle
            // 
            this.pbOgunEkle.Image = ((System.Drawing.Image)(resources.GetObject("pbOgunEkle.Image")));
            this.pbOgunEkle.Location = new System.Drawing.Point(9, 19);
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
            this.monthCalendar1.Location = new System.Drawing.Point(10, 41);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
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
            this.lblAlinmasiGerekenKalori.Location = new System.Drawing.Point(18, 212);
            this.lblAlinmasiGerekenKalori.Name = "lblAlinmasiGerekenKalori";
            this.lblAlinmasiGerekenKalori.Size = new System.Drawing.Size(218, 64);
            this.lblAlinmasiGerekenKalori.TabIndex = 10;
            this.lblAlinmasiGerekenKalori.Text = "Alınması Gereken Günlük Kalori";
            this.lblAlinmasiGerekenKalori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.besinEkleToolStripMenuItem,
            this.egzersizToolStripMenuItem,
            this.raporToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1121, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 450);
            this.Controls.Add(this.lblToplamKalori);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblAlinmasiGerekenKalori);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOgunEkle)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbOgunEkle;
    }
}