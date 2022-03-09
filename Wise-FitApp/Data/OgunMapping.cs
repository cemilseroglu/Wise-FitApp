using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wise_FitApp.Model;

namespace Wise_FitApp.Data
{
    public class OgunMapping : EntityTypeConfiguration<Ogun>
    {
        public OgunMapping()
        {
            ToTable("Ogunler");

            Property(x => x.OlusturulmaTarihi).IsRequired();
            Property(x => x.OgunTipi).IsRequired();
            Property(x => x.ToplamKalori).IsOptional();
            Property(x => x.OgunBesinAdi).IsRequired();

        }

    }
}
