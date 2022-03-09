using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wise_FitApp.Data;
using Wise_FitApp.Model;
using System.Runtime.InteropServices;

namespace Wise_FitApp.UI
{
    public partial class RaporForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
           );

        bool mouseDown;
        private Point offset;
        private readonly AppDbContext db;
        private readonly int id;
        DateTime dt = DateTime.Now;
        public RaporForm(AppDbContext db, int id)
        {
            InitializeComponent();
            this.id = id;
            this.db = db;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.BackColor = ColorTranslator.FromHtml("#5e8d93");
            panel1.BackColor = ColorTranslator.FromHtml("#5e8d93");

        }

        private void RaporForm_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm(id, db);
            this.Hide();
            frm.Show();
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

        private void ButunOgunuListele()
        {
            dgvRaporListesi.DataSource = db.Ogunler.Where(x => x.kullaniciId == id).ToList();
            dgvRaporListesi.Columns["OgunId"].Visible = false;
            dgvRaporListesi.Columns["kullaniciId"].Visible = false;
            dgvRaporListesi.Columns["Kullanici"].Visible = false;
            decimal total = dgvRaporListesi.Rows.Cast<DataGridViewRow>()
.Sum(t => Convert.ToDecimal(t.Cells[4].Value));
            lblPeriyodikKaloriToplam.Text = "Bütün Öğünlerin Kalori Toplamı " + total.ToString() + " kcal";
        }

        private void btnHaftalikListe_Click(object sender, EventArgs e)
        {
            int oncekiGun = 7;
            SeciliPeriyoduListele(oncekiGun);
            dgvRaporListesi.Columns["OgunId"].Visible = false;
            dgvRaporListesi.Columns["kullaniciId"].Visible = false;
            dgvRaporListesi.Columns["Kullanici"].Visible = false;
            decimal total = dgvRaporListesi.Rows.Cast<DataGridViewRow>()
.Sum(t => Convert.ToDecimal(t.Cells[4].Value));
            lblPeriyodikKaloriToplam.Text = "Son Haftanın Kalori Toplamı " + total.ToString() + " kcal";
        }



        private void SeciliPeriyoduListele(int oncekiGunSayisi)
        {
            dgvRaporListesi.DataSource = db.Ogunler.Where(x => x.kullaniciId == id && x.OlusturulmaTarihi >= System.Data.Entity.DbFunctions.AddDays(DateTime.Now, -oncekiGunSayisi)).ToList();
        }

        private void btnAylikListe_Click(object sender, EventArgs e)
        {
            int oncekiGun = 30;
            SeciliPeriyoduListele(oncekiGun);
            dgvRaporListesi.Columns["OgunId"].Visible = false;
            dgvRaporListesi.Columns["kullaniciId"].Visible = false;
            dgvRaporListesi.Columns["Kullanici"].Visible = false;
            decimal total = dgvRaporListesi.Rows.Cast<DataGridViewRow>()
.Sum(t => Convert.ToDecimal(t.Cells[4].Value));
            lblPeriyodikKaloriToplam.Text = "Aylık Öğünlerin Kalori Toplamı " + total.ToString() + " kcal";
        }

        private void btnButunListe_Click(object sender, EventArgs e)
        {
            ButunOgunuListele();
        }

        private void btnBesinIstatistikleri_Click(object sender, EventArgs e)
        {
            BesinIstatistikleriForm frm = new BesinIstatistikleriForm();
            frm.ShowDialog();
        }
    }
}
