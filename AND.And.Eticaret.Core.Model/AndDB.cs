using AND.And.Eticaret.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND.And.Eticaret.Core.Model
{
   public class AndDB : DbContext
    {
        //Tablolar
        public AndDB()
          : base(@"Data Source=DESKTOP-BFA5AD8;Initial Catalog=ANDAndEticaretDB;Integrated Security=True")
        {
        }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Pazarlamaci> Pazarlamacis { get; set; }
        public DbSet<KullaniciAdress> KullaniciAdres { get; set; }
        public DbSet<Ürün> Ürüns { get; set; }
        public DbSet<Durum> Durums { get; set; }
        public DbSet<Sepet> Sepets { get; set; }

        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<SiparisÜrünleri> SiparisÜrünleris { get; set; }
        public DbSet<SiparisÖdeme> SiparişÖdemes { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
        public DbSet<OfisElemanı> OfisElemanıs { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<ParaDurumu> ParaDurumus { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
