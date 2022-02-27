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
    }
}
