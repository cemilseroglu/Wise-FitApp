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
            ogunleriListele();
            gunlukAlinmasiGerekenKalori();
        }

        private void ogunleriListele()
        {
            dgvOgunListesiMain.DataSource = db.Ogunler.Where(x =>x.kullaniciId == girisYapanKullanici && x.OlusturulmaTarihi == monthCalendar1.SelectionRange.Start.Date).ToList();//TODO
        }

        private void gunlukAlinmasiGerekenKalori()
        {
            //for (int i = 0; i < dgvOgunListesiMain.Rows.Count; i++)
            //{
            //    sum += Convert.ToDecimal(dgvOgunListesiMain.Rows[i].Cells[4].Value);
            //}
            //label3.Text=sum.ToString();
            decimal total = dgvOgunListesiMain.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells[4].Value));
            Kullanici kullanici = db.Kullanici.FirstOrDefault(x=>x.kullaniciId==girisYapanKullanici);
            if (kullanici.Cinsiyet == Cinsiyet.Kadin)
            {
                lblToplamKalori.Text = total.ToString()+" / "+(Convert.ToDouble(10 * kullanici.Kilo) + (6.25 * Convert.ToDouble(kullanici.Boy)) - (5 * kullanici.Yas) - 161).ToString();
            }
            else
            {
                lblToplamKalori.Text =total.ToString()+" / "+(Convert.ToDouble(10 * kullanici.Kilo) + (6.25 *Convert.ToDouble(kullanici.Boy))- (5 * kullanici.Yas) + 5).ToString();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvOgunListesiMain.Columns["OgunId"].Visible = false;
            dgvOgunListesiMain.Columns["kullaniciId"].Visible = false;
            dgvOgunListesiMain.Columns["Kullanici"].Visible = false;
            ogunleriListele();
            gunlukAlinmasiGerekenKalori();
        }

        private void btnListeYenile_Click(object sender, EventArgs e)
        {
            ogunleriListele();
            gunlukAlinmasiGerekenKalori();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ogunleriListele();
            gunlukAlinmasiGerekenKalori();
        }

        private void dgvOgunListesiMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvOgunListesiMain.HitTest(e.X, e.Y);
                dgvOgunListesiMain.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOgunListesiMain.SelectedRows.Count > 0)
            {
                int silinecekId = (int)dgvOgunListesiMain.SelectedRows[0].Cells[0].Value;
                Ogun silinecekOgun = db.Ogunler.FirstOrDefault(x => x.OgunId == silinecekId);
                db.Ogunler.Remove(silinecekOgun);
                db.SaveChanges();
                ogunleriListele();
                gunlukAlinmasiGerekenKalori();
            }
        }
    }
}
