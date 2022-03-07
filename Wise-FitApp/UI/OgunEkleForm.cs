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
        bool mouseDown;
        private Point offset;
        public OgunEkleForm(int id, AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            this.id = id;
            this.BackColor = ColorTranslator.FromHtml("#5e8d93");
            panel1.BackColor = ColorTranslator.FromHtml("#5e8d93");

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
