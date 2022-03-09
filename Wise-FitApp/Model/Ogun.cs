using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wise_FitApp.Model
{
    public class Ogun
    {
        public Ogun()
        {
            Besinler = new List<Besin>();

        }

        public int OgunId { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public string OgunTipi { get; set; }
        public string OgunBesinAdi { get; set; }
        public decimal? ToplamKalori { get; set; } 
        public int kullaniciId { get; set; }
        public Kullanici Kullanici { get; set; } //navigation property
        public virtual List<Besin> Besinler { get; set; } //navigation property
    }
}
