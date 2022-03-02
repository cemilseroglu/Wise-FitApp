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
        public OgunEkleForm(int id, AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
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
    }
}
