using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND.And.Eticaret.Core.Model.Entity
{
   public class Siparis : EntityBase
    {
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        public int KullaniciAdresID { get; set; }
        public KullaniciAdress KullaniciAdress { get; set; }
        public int DurumID { get; set; }
        public Durum Durum { get; set; }
        public decimal ToplamFiyat { get; set; }
        public decimal KdvToplamı { get; set; }
        public decimal İndirimToplamı { get; set; }
        public decimal GenelToplam { get; set; }
        public virtual List<SiparisÖdeme> SiparişÖdemes { get; set; }
        public virtual List<SiparisÜrünleri> SiparisÜrünleris { get; set; }
    }
}
