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

namespace Wise_FitApp.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text.Trim())||string.IsNullOrEmpty(txtSifre.Text.Trim()))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanı boş geçilemez.");
            }
            else
            {
                AppDbContext db = new AppDbContext();
                 //int id=db.Kullanici.Where(x=>x.kullaniciId )
                var userBilgileri = db.Kullanici.Where(a => a.kullaniciAdi == txtKullaniciAdi.Text.Trim()&&a.Sifre==txtSifre.Text.Trim()).FirstOrDefault();
                if (userBilgileri!=null)
                {
                    MainForm frmMain = new MainForm(userBilgileri.kullaniciId,db);
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış şifre veya kullanıcı adı girdiniz.Bilgilerinizi kontrol ediniz.");
                    txtKullaniciAdi.Clear();
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

        private void linkLabelSifreUnut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttumForm frmSifre = new SifremiUnuttumForm();
            frmSifre.ShowDialog();
        }
    }
}
