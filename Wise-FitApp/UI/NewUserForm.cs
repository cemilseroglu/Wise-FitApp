﻿using System;
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
        bool altiKarakter;
        bool birSayi;
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
                            if (txtSifre.Text.Contains("a"))
                            {

                            }
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

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            birSayi = false;
            altiKarakter = false;
            lblGereksinim.Visible = true;
            btnKullanıcıEkle.Enabled = false;
            if (!String.IsNullOrEmpty(txtSifre.Text))
            {
                char[] karakterler = txtSifre.Text.ToCharArray();
                karakterSayisi();
                void karakterSayisi()
                {
                    if (karakterler.Length>=6)
                    {
                        altiKarakter = true;
                        lbl6Karakter.ForeColor = Color.Green;
                    }
                    else
                    {
                        altiKarakter = false;
                        lbl6Karakter.ForeColor = Color.Red;
                    }
                    sayiKontrol();
                }
                void sayiKontrol()
                {
                    foreach (char karakter in karakterler)
                    {
                        if (char.IsNumber(karakter) == true)
                        {
                            birSayi = true;
                            break;
                        }
                    }
                    if (birSayi == true)
                    {
                        lblEnAz1Sayi.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblEnAz1Sayi.ForeColor = Color.Red;
                    }
                    sonlandir();
                }
                void sonlandir()
                {
                    if (birSayi && altiKarakter)
                    {
                        btnKullanıcıEkle.Enabled = true;
                        lblGereksinim.Visible = false;
                    }
                }

            }
           
        }
    }
}
