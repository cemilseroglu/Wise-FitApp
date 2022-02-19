using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wise_FitApp.Model;

namespace Wise_FitApp.Data
{
    public class KategoriMapping : EntityTypeConfiguration<Kategori>
    {
        public KategoriMapping()
        {
            ToTable("Kategoriler");

            Property(x => x.KategoriAdi)
                .IsRequired()
                .HasMaxLength(50);

            //List Besinleri nasıl dahil edeceğiz?
        }
    }
}
