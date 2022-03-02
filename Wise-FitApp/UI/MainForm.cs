using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wise_FitApp.Data;
using Wise_FitApp.Model;

namespace Wise_FitApp.UI
{
    public partial class MainForm : Form
    {
        private AppDbContext db;
        int girisYapanKullanici;
        public MainForm(int gelenKullaniciId, AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            girisYapanKullanici = gelenKullaniciId;
            gunlukAlinmasiGerekenKalori();
        }

        private void gunlukAlinmasiGerekenKalori()
        {
            Kullanici kullanici = db.Kullanici.FirstOrDefault(x=>x.kullaniciId==girisYapanKullanici);
            if (kullanici.Cinsiyet == Cinsiyet.Kadin)
            {
                lblToplamKalori.Text = "0"+" / "+(Convert.ToDouble(10 * kullanici.Kilo) + (6.25 * Convert.ToDouble(kullanici.Boy)) - (5 * kullanici.Yas) - 161).ToString();
            }
            else
            {
                lblToplamKalori.Text ="0"+" / "+(Convert.ToDouble(10 * kullanici.Kilo) + (6.25 *Convert.ToDouble(kullanici.Boy))- (5 * kullanici.Yas) + 5).ToString();
            }
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporForm raporForm = new RaporForm();
            raporForm.ShowDialog();
        }

        private void egzersizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EgzersizForm egzersizForm = new EgzersizForm();
            egzersizForm.ShowDialog();
        }

        private void besinEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BesinEkleForm frm = new BesinEkleForm(db);
            frm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbOgunEkle_Click(object sender, EventArgs e)
        {
            OgunEkleForm ogunEkleForm = new OgunEkleForm(girisYapanKullanici,db);
            ogunEkleForm.ShowDialog();
        }

        private void pbOgunEkle_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pbOgunEkle_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
