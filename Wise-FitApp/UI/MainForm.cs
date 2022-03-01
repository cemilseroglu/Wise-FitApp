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

namespace Wise_FitApp.UI
{
    public partial class MainForm : Form
    {
        private AppDbContext db;

        public MainForm(int gelenKullaniciId, AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporForm raporForm = new RaporForm();
            raporForm.ShowDialog();
        }

        private void egzersizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EgzersizForm egzersizForm = new EgzersizForm();
            egzersizForm.ShowDialog();
        }

        private void besinEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BesinEkleForm frm = new BesinEkleForm(db);
            frm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbOgunEkle_Click(object sender, EventArgs e)
        {
            OgunEkleForm ogunEkleForm = new OgunEkleForm();
            ogunEkleForm.ShowDialog();
        }

        private void pbOgunEkle_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pbOgunEkle_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
