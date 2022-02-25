using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wise_FitApp.Model;

namespace Wise_FitApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext():base("name=WiseDbContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KategoriMapping());
            modelBuilder.Configurations.Add(new BesinMapping());
            modelBuilder.Configurations.Add(new OgunMapping());
            modelBuilder.Configurations.Add(new KullaniciMapping());

            //TODO : Tablo isimlerini oluştururken otomatik olarak çoğul yapmasını engelleyen kod girildi!
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Besin> Besinler { get; set; }
    }


}



