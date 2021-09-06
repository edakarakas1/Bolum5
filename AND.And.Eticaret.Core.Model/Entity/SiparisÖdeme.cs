using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND.And.Eticaret.Core.Model.Entity
{
   public class SiparisÖdeme : EntityBase
    {
        public int SiparisID { get; set; }
        public _SiparisÖdeme SSiparisÖdeme { get; set; }
        public decimal Fiyat { get; set; }
        public string Banka { get; set; }
    }
    public enum _SiparisÖdeme
    {
        Havale = 0,
        Kredikartı = 1
    }
}
