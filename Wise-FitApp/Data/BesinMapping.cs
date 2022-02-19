using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wise_FitApp.Model;

namespace Wise_FitApp.Data
{
    public class BesinMapping : EntityTypeConfiguration<Besin>
    {
        public BesinMapping()
        {
            ToTable("Besinler");

            Property(x => x.BesinAdi).IsRequired().HasMaxLength(50);

            Property(x => x.Miktar).IsRequired();

            Property(x => x.Kalori).IsRequired();

            Property(x => x.Kalori).IsRequired();

            //KategoriId ???
            //List Ogunler ???

        }
    }
}
