using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND.And.Eticaret.Core.Model.Entity
{
  public  class SiparisÜrünleri : EntityBase
    {
        public string PazarlamacıID { get; set; }
        public string ÜrünKoduID { get; set; }
        public string Adet { get; set; }
        public int Tutar { get; set; }
    }
}
