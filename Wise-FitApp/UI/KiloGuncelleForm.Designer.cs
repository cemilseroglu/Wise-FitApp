namespace Wise_FitApp.UI
{
    partial class KiloGuncelleForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSistemdekiKilo = new System.Windows.Forms.Label();
            this.nudYeniKilo = new System.Windows.Forms.NumericUpDown();
            this.btnKiloGuncelle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYeniKilo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 31);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wise_FitApp.Properties.Resources.icons8_close_64;
            this.pictureBox1.Location = new System.Drawing.Point(341, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblSistemdekiKilo
            // 
            this.lblSistemdekiKilo.AutoSize = true;
            this.lblSistemdekiKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSistemdekiKilo.Location = new System.Drawing.Point(12, 48);
            this.lblSistemdekiKilo.Name = "lblSistemdekiKilo";
            this.lblSistemdekiKilo.Size = new System.Drawing.Size(153, 16);
            this.lblSistemdekiKilo.TabIndex = 1;
            this.lblSistemdekiKilo.Text = "Sistemdeki Kilonuz :  ";
            // 
            // nudYeniKilo
            // 
            this.nudYeniKilo.DecimalPlaces = 2;
            this.nudYeniKilo.Location = new System.Drawing.Point(15, 106);
            this.nudYeniKilo.Name = "nudYeniKilo";
            this.nudYeniKilo.Size = new System.Drawing.Size(150, 20);
            this.nudYeniKilo.TabIndex = 2;
            // 
            // btnKiloGuncelle
            // 
            this.btnKiloGuncelle.Location = new System.Drawing.Point(183, 83);
            this.btnKiloGuncelle.Name = "btnKiloGuncelle";
            this.btnKiloGuncelle.Size = new System.Drawing.Size(90, 63);
            this.btnKiloGuncelle.TabIndex = 3;
            this.btnKiloGuncelle.Text = "Kilomu Güncelle";
            this.btnKiloGuncelle.UseVisualStyleBackColor = true;
            this.btnKiloGuncelle.Click += new System.EventHandler(this.btnKiloGuncelle_Click);
            // 
            // KiloGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 173);
            this.Controls.Add(this.btnKiloGuncelle);
            this.Controls.Add(this.nudYeniKilo);
            this.Controls.Add(this.lblSistemdekiKilo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KiloGuncelleForm";
            this.Text = "KiloGuncelleForm";
            this.Load += new System.EventHandler(this.KiloGuncelleForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYeniKilo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSistemdekiKilo;
        private System.Windows.Forms.NumericUpDown nudYeniKilo;
        private System.Windows.Forms.Button btnKiloGuncelle;
    }
}