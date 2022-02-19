using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wise_FitApp.Model
{
    public class Kullanici
    {
        public Kullanici()
        {
            Ogunler = new List<Ogun>();
        }
        public int kullaniciId { get; set; } //guid??
        public string TamAd { get; set; }
        public string Email { get; set; }
        public string kullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public decimal Boy { get; set; }
        public decimal Kilo { get; set; }
        public int Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        //public Amac Amac { get; set; }  //2 adet kalıtım aldırabilir miyiz??Class oluşturup..
        //Amac konusu halen tartışılıyor.Rapor kısmında bu durum belirtile de bilir.

        public virtual List<Ogun> Ogunler { get; set; }
    }
}

public enum Cinsiyet
{
    Erkek,Kadin
}

//public enum Amac
//{
//    KiloVerme,KiloAlma,Koruma
//}
