using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wise_FitApp.Model;

namespace Wise_FitApp.Data
{
    public class KullaniciMapping : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMapping()
        {
            ToTable("Kullanicilar");

            Property(x => x.kullaniciAdi)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(150);
            Property(x => x.Sifre)
                .IsRequired()
                .HasMaxLength(30);
            Property(x => x.TamAd)
                .IsRequired()
                .HasMaxLength(100);
            Property(x => x.Boy)
                .IsRequired();

            Property(x => x.Kilo)
                .IsRequired();

            //List Ogunleri nasıl dahil edeceğiz
            
            //TODO 18/02/2022 Buraya kadar yaptık.Foreign key'ler ve propertyler yazılacak.
            //Migration oluşturularak database ayaklandırılacak....
            //İş bölümü yapılacak.

                

        }
    }
}
