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
    public partial class RaporForm : Form
    {
        private readonly AppDbContext db;
        private readonly int gelenID;
        public RaporForm(AppDbContext db,int gelenKullaniciId)
        {
            InitializeComponent();
            this.gelenID = gelenKullaniciId;
            this.db = db;
            
        }
    }
}
