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
    public partial class BesinEkleForm : Form
    {
        private readonly AppDbContext db;
        public BesinEkleForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void BesinEkleForm_Load(object sender, EventArgs e)
        {
            BesinListele();
            KategoriListesi();
            this.dgvBesinListesi.Columns["Kategori"].Visible = false;
            //this.dgvBesinListesi.Columns["BesinId"].Visible = false;
        }

        private void KategoriListesi()
        {
            cmbBesinKategori.DataSource = db.Kategoriler.ToList();
            cmbBesinKategori.DisplayMember = "KategoriAdi";
        }

        private void BesinListele()
        {
            dgvBesinListesi.DataSource = db.Besinler.ToList();
        }

        private void dgvBesinListesi_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvBesinListesi.HitTest(e.X, e.Y);
                dgvBesinListesi.Rows[hit.RowIndex].Selected = true;
            }
        }
        Besin silinecekBesin = new Besin();

        Besin besin = new Besin();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnEkle.Text == "Ekle")
            {
                if (string.IsNullOrEmpty(txtBesinAdi.Text))
                {
                    MessageBox.Show("Besin Adı Boş Olamaz");
                    return;
                }

                besin.BesinAdi = txtBesinAdi.Text;
                besin.Miktar = 1;
                besin.Kalori = nudKalori.Value;
                besin.KategoriId = (cmbBesinKategori.SelectedIndex + 1);
                if (cmbBesinKategori.SelectedIndex==0)
                {
                    besin.BesinKategorisi = "Balıklar";
                }
                else if (cmbBesinKategori.SelectedIndex == 1)
                {
                    besin.BesinKategorisi = "Sakatatlar";
                }
                else if (cmbBesinKategori.SelectedIndex == 2)
                {
                    besin.BesinKategorisi = "Kümes ve Av Hayvanları";
                }
                else if (cmbBesinKategori.SelectedIndex == 3)
                {
                    besin.BesinKategorisi = "Sebzeler ve Baklagiller";
                }
                else if (cmbBesinKategori.SelectedIndex == 4)
                {
                    besin.BesinKategorisi = "Meyveler";
                }
                else if (cmbBesinKategori.SelectedIndex == 5)
                {
                    besin.BesinKategorisi = "Süt ve Süt Ürünleri";
                }
                else if (cmbBesinKategori.SelectedIndex == 6)
                {
                    besin.BesinKategorisi = "Et ve Et Ürünleri";
                }
                else if (cmbBesinKategori.SelectedIndex == 7)
                {
                    besin.BesinKategorisi = "Baharat ve Tat Vericiler";
                }
                else if (cmbBesinKategori.SelectedIndex == 8)
                {
                    besin.BesinKategorisi = "Unlu Mamüller";
                }
                else if (cmbBesinKategori.SelectedIndex == 8)
                {
                    besin.BesinKategorisi = "Tatlılar";
                }
                else if (cmbBesinKategori.SelectedIndex == 8)
                {
                    besin.BesinKategorisi = "Çerez ve Kuru Yemişler";
                }
                else if (cmbBesinKategori.SelectedIndex == 9)
                {
                    besin.BesinKategorisi = "Diğer Besinler";
                }

                db.Besinler.Add(besin);
                db.SaveChanges();
                BesinListele();
                MessageBox.Show("Besin Eklendi");
                txtBesinAdi.Clear();
                nudKalori.Value = 0;

            }
        }

        private void silToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dgvBesinListesi.SelectedRows.Count > 0)
            {
                int Id = (int)dgvBesinListesi.SelectedRows[0].Cells[0].Value;
                silinecekBesin = db.Besinler.FirstOrDefault(x => x.BesinId == Id);
                db.Besinler.Remove(silinecekBesin);
                db.SaveChanges();
                BesinListele();
                txtBesinAdi.Clear();
                nudKalori.Value = 0;
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
