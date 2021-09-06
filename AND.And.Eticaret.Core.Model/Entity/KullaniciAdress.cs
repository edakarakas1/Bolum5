using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND.And.Eticaret.Core.Model.Entity
{
   public class KullaniciAdress : EntityBase
    {
        public int KullaniciID { get; set; }
        public Kullanici Kullanici { get; set; }
        public string Baslık { get; set; }
        public string Sehir { get; set; }
        public string Adres { get; set; }
        public bool Aktif { get; set; }
    }
}
