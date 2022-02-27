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
            //Kullanicilar = new List<Kullanici>();
        }

        public int OgunId { get; set; } //Aralarında sadece 1-1 ilişki varsa key ve foreign key tanımlanması gerekiyor?(bunu sormalıyız)
        //public string OgunAdi { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public Ogunler Ogunler { get; set; } //OgunTipi olarak değişecek
        public decimal? ToplamKalori { get; set; } // ? eklenmeli nullable sadece ef'de yapıldı.Denenecek.
        //public virtual List<Kullanici> Kullanicilar { get; set; } //Liste yerine kullanici/kullaniciid kullanilabilir çoka çok olmasına gerek yok.bire çok olucak.
        public int kullaniciId { get; set; }
        public Kullanici Kullanici { get; set; } //navigation property
        public virtual List<Besin> Besinler { get; set; }
    }
}

public enum Ogunler //Enuma gerek yok ogun adı gerek yok.Ya enum ya string seçilecek.
{
    Kahvalti,AraOgun1,OgleYemegi,AraOgun2,AraOgun3,AksamYemegi,Kacamak
}
