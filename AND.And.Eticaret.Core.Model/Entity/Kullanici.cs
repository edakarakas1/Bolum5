using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND.And.Eticaret.Core.Model.Entity
{
   public class Kullanici : EntityBase
    {

        public string KullaniciAdı { get; set; }
        public string KullaniciSoyadı { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string BankaAdı { get; set; }
        public string IBANNumarası { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Şifre { get; set; }
        public bool Aktif { get; set; }
        public bool Admin { get; set; }
        public virtual IEnumerable<KullaniciAdress> KullaniciAdres { get; set; }

    }
}
