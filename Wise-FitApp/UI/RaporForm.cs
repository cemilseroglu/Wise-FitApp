using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wise_FitApp.Data;
using Wise_FitApp.Model;

namespace Wise_FitApp.UI
{
    public partial class RaporForm : Form
    {
        private readonly AppDbContext db;
        private readonly int id;
        public RaporForm(AppDbContext db, int id )
        {
            InitializeComponent();
            this.id = id;
            this.db = db;

        }
        //Kullanıcının öğünlerini alıp foreachde dönüp kalori miktarını alabiliriz.
        private void GunlukKaloriSay()
        {
            var kullanıcıOgunler = db.Kullanici.FirstOrDefault(x => x.kullaniciId == id).Ogunler;

            foreach (var ogun in kullanıcıOgunler)
            {

            }
        }
        //burada öğün adını ve zamanı verip ortalamayı buluyorum.
        private void kullanıcıOrtalamaKaloriHesabı(string besinAdı, DateTime dt)
        {
            List<Ogun> kullanıcıOgunListesi = db.Ogunler.Where(x => x.OgunBesinAdi == besinAdı && x.OlusturulmaTarihi.Date > dt.Date).ToList();
            decimal? totalCal = kullanıcıOgunListesi.Sum(z => z.ToplamKalori);

            if (totalCal > 0)
            {
                int totalMeal = kullanıcıOgunListesi.Count();
                decimal? avg = totalCal / totalMeal;
            }
        }
        //Öğun ve zamana bağlı kalori hesabı
        private void ortalamaKaloriHesabı(string ogunAdı, Label label, DateTime dt)
        {
            List<Ogun> ogunListesi = db.Ogunler.Where(x => x.OgunTipi == ogunAdı && DbFunctions.TruncateTime(x.OlusturulmaTarihi.Date) > dt.Date).ToList();
            decimal? totalCal = ogunListesi.Sum(z => z.ToplamKalori);

            if (totalCal > 0)
            {
                int totalMeal = ogunListesi.Count();
                decimal? avg = totalCal / totalMeal;
            }
        }
    }
}
