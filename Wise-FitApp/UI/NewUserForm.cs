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
    public partial class NewUserForm : Form
    {
        AppDbContext db;
        public NewUserForm()
        {
            InitializeComponent();
        }
        
        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdSoyad.Text.Trim()) || string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(txtBoy.Text) || string.IsNullOrEmpty(txtKilo.Text) || string.IsNullOrEmpty(txtKullaniciAdi.Text.Trim()) || string.IsNullOrEmpty(txtSifre.Text.Trim()) || string.IsNullOrEmpty(txtSifreTekrar.Text.Trim()) || string.IsNullOrEmpty(txtYas.Text)||string.IsNullOrEmpty(cmbCinsiyet.Text)) 
            {
                MessageBox.Show("Bu alanlar boş geçilemez.");
            }
            else
            {
                if (txtSifre.Text.Trim()!=txtSifreTekrar.Text.Trim())
                {
                    MessageBox.Show("Şifreler uyuşmuyor.Doğru girdiğinizden emin olun.");
                }
                else
                {
                    db = new AppDbContext();
                    try
                    {
                        if (db.Kullanici.Where(y=>y.Email==txtEmail.Text).Any())
                        {
                            MessageBox.Show("Bu email kullanılmakta,başka bir email giriniz.");
                            txtEmail.Clear();
                        }
                        else
                        {
                            Kullanici yeniKullanici = new Kullanici();
                            yeniKullanici.TamAd = txtAdSoyad.Text.Trim();
                            yeniKullanici.kullaniciAdi = txtKullaniciAdi.Text.Trim();
                            yeniKullanici.Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedIndex;
                            yeniKullanici.Boy = Convert.ToDecimal(txtBoy.Text);
                            yeniKullanici.Kilo = Convert.ToDecimal(txtKilo.Text);
                            yeniKullanici.Email = txtEmail.Text.Trim();
                            yeniKullanici.Yas = Convert.ToInt32(txtYas.Text);
                            yeniKullanici.Sifre = txtSifre.Text;
                            db.Kullanici.Add(yeniKullanici);
                            db.SaveChanges();
                            MessageBox.Show("Kayıt Oldunuz.");
                            this.Hide();
                            LoginForm frmLogin = new LoginForm();
                            frmLogin.ShowDialog();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("lütfen doğru giriş yapınız.");
                    }
                   
                }
                

            }
        }
    }
}
