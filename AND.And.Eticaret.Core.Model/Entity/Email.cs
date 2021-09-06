using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND.And.Eticaret.Core.Model.Entity
{
  public  class Email : EntityBase
    {
        public string KullanıcıMailAdresi { get; set; }
        public string Konu { get; set; }
    }
}
