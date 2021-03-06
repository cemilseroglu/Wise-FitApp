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
using System.Runtime.InteropServices;

namespace Wise_FitApp.UI
{
    public partial class OgunEkleForm : Form
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



        private readonly AppDbContext db;
        private readonly int id;
        bool mouseDown;
        private Point offset;
        public OgunEkleForm(int id, AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            this.id = id;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
            yeniOgun.ToplamKalori = ((decimal)dgvBesinListesiOgun.SelectedRows[0].Cells[3].Value)*nudPorsiyon.Value;
            yeniOgun.OgunBesinAdi = dgvBesinListesiOgun.SelectedRows[0].Cells[1].Value.ToString();
            db.Ogunler.Add(yeniOgun);
            db.SaveChanges();
            MessageBox.Show("Öğün Eklendi.");
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm(id, db);
            this.Hide();
            frm.Show();
        }
    }
}
