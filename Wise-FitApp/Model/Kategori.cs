using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wise_FitApp.Model
{
    public class Kategori
    {
        public Kategori()
        {
            Besinler = new List<Besin>();
        }
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public virtual List<Besin> Besinler { get; set; }
    }
}
