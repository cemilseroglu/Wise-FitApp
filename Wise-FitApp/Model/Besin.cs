using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wise_FitApp.Model
{
    public class Besin
    {
        public Besin()
        {
            Ogunler = new List<Ogun>();
        }
        public int BesinId { get; set; }
        public string BesinAdi { get; set; }
        public decimal Miktar { get; set; }
        public decimal Kalori { get; set; }
        public string BesinKategorisi { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; } 
        public virtual List<Ogun> Ogunler { get; set; }  

    }
}



