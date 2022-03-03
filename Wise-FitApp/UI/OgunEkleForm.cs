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
    public partial class OgunEkleForm : Form
    {
        private readonly AppDbContext db;
        private readonly int id;
        public OgunEkleForm(int id, AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            this.id = id;
            
        }



        private void OgunEkleForm_Load(object sender, EventArgs e)
        {
            besinleriListele();

            dgvBesinListesiOgun.Columns["Kategori"].Visible = false;
            dgvBesinListesiOgun.Columns["BesinId"].Visible = false;
            this.Text = DateTime.Now.ToString();
        }

        private void besinleriListele()
        {
            dgvBesinListesiOgun.DataSource = db.Besinler.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {     

            Ogun yeniOgun = new Ogun();
            yeniOgun.OlusturulmaTarihi = DateTime.Now.Date;
            yeniOgun.kullaniciId = id;
            yeniOgun.OgunTipi = this.cmbOgunTipi.GetItemText(this.cmbOgunTipi.SelectedItem);
            //yeniOgun.Besinler.Add(
            //{
            //    //BesinAdi = dgvBesinListesiOgun.SelectedRows[0].Cells[1].ToString(),
            //    //BesinKategorisi = dgvBesinListesiOgun.SelectedRows[0].Cells[4].ToString(),
            //    //Kalori = (decimal)dgvBesinListesiOgun.SelectedRows[0].Cells[3].Value,
            //    //KategoriId = (int)dgvBesinListesiOgun.SelectedRows[0].Cells[5].Value,
            //    //Miktar = (int)dgvBesinListesiOgun.SelectedRows[0].Cells[2].Value,
            //    //BesinId = (int)dgvBesinListesiOgun.SelectedRows[0].Cells[0].Value
            //});
            yeniOgun.ToplamKalori = (decimal)dgvBesinListesiOgun.SelectedRows[0].Cells[3].Value;
            yeniOgun.OgunBesinAdi = dgvBesinListesiOgun.SelectedRows[0].Cells[1].Value.ToString();
            db.Ogunler.Add(yeniOgun);
            db.SaveChanges();
            MessageBox.Show("Öğün Eklendi.");
            //yeniOgun.Besinler = ???
            //TODO: dgvBesinListesiOgun'un seçili satırı eklenecekOgun.Besinler database'ine kaydedilmesini istiyorum.
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
