using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Wise_FitApp.Data;
using Wise_FitApp.Model;

namespace Wise_FitApp.UI
{
    public partial class KiloGuncelleForm : Form
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
        Kullanici kullanici;


        public KiloGuncelleForm(int id, AppDbContext db)
        {
            InitializeComponent();
            this.id = id;
            this.db = db;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.BackColor = ColorTranslator.FromHtml("#5e8d93");
            panel1.BackColor = ColorTranslator.FromHtml("#5e8d93");
        }
        private void KiloGuncelleForm_Load(object sender, EventArgs e)
        {
            kullanici = db.Kullanici.FirstOrDefault(x => x.kullaniciId == id);
            lblSistemdekiKilo.Text = "Sistemdeki kilonuz : " + kullanici.Kilo.ToString();
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

        private void btnKiloGuncelle_Click(object sender, EventArgs e)
        {
            kullanici.Kilo = (decimal)nudYeniKilo.Value;
            db.SaveChanges();
            lblSistemdekiKilo.Text = "Sistemdeki kilonuz : " + kullanici.Kilo.ToString();
        }


    }
}
