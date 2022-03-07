using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Wise_FitApp.Data;
using System.Net.Mail;
using System.Runtime.InteropServices;

namespace Wise_FitApp.UI
{
    public partial class LoginForm : Form
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
        public LoginForm()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.BackColor = ColorTranslator.FromHtml("#5e8d93");
            panel1.BackColor = ColorTranslator.FromHtml("#5e8d93");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim())||string.IsNullOrEmpty(txtSifre.Text.Trim()))
            {
                MessageBox.Show("Email ve şifre alanı boş geçilemez.");
            }
            else
            {
                AppDbContext db = new AppDbContext();
                var userBilgileri = db.Kullanici.Where(a => a.Email == txtEmail.Text.Trim()&&a.Sifre==txtSifre.Text.Trim()).FirstOrDefault();
                if (userBilgileri!=null)
                {
                    MainForm frmMain = new MainForm(userBilgileri.kullaniciId,db);
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış şifre veya Email girdiniz.Bilgilerinizi kontrol ediniz.");
                    txtEmail.Clear();
                    txtSifre.Clear();
                }
            }
                
            
        }

        private void linkLabelKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewUserForm frmYeniKayit = new NewUserForm();
            frmYeniKayit.Show();
            this.Hide();
        }



        private void chkGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGoster.CheckState==CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = true;
            }
            else if (chkGoster.CheckState==CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
