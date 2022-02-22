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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.besinEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egzersizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.besinEkleToolStripMenuItem,
            this.öğünEkleToolStripMenuItem,
            this.egzersizToolStripMenuItem,
            this.raporToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // besinEkleToolStripMenuItem
            // 
            this.besinEkleToolStripMenuItem.Name = "besinEkleToolStripMenuItem";
            this.besinEkleToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.besinEkleToolStripMenuItem.Text = "Besin Ekle";
            // 
            // öğünEkleToolStripMenuItem
            // 
            this.öğünEkleToolStripMenuItem.Name = "öğünEkleToolStripMenuItem";
            this.öğünEkleToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.öğünEkleToolStripMenuItem.Text = "Kalori Takip";
            // 
            // egzersizToolStripMenuItem
            // 
            this.egzersizToolStripMenuItem.Name = "egzersizToolStripMenuItem";
            this.egzersizToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.egzersizToolStripMenuItem.Text = "Egzersiz";
            // 
            // raporToolStripMenuItem
            // 
            this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
            this.raporToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.raporToolStripMenuItem.Text = "Rapor";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem besinEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egzersizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
    }
}