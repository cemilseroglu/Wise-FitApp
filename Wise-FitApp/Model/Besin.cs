using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wise_FitApp.Model
{
    public class Besin
    {
        //Porsiyon kısmında araştırmalar devam edecek.
        public Besin()
        {
            Ogunler = new List<Ogun>();
        }
        public int BesinId { get; set; }
        public string BesinAdi { get; set; }
        public decimal Miktar { get; set; }
        public decimal Kalori { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; } //TODO : Navigation Property
        public virtual List<Ogun> Ogunler { get; set; }  //virtual mantığını hoca ile görüşeceğiz.
        public Porsiyon Porsiyonlar { get; set; }
        //public BesinTipi BesinTipi { get; set; }  //Hangisi daha mantıklı class mı enum mı?

    }
}

public enum Porsiyon
{
    Dilim,SuBardagi,YemekKasigi,Adet //Çoğaltılabilir..
        //Porsiyon konusunda son karar : Ana birim bazında gr seçilerek ona göre ölçeklendirme yapılacaktır.
}

//public enum BesinTipi
//{
//    Baliklar,Sakatatlar, KumesveAvHayvanlari //http://www.hanimeliyemek.com.tr/kalori-cetveli.html
//}
