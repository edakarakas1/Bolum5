using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND.And.Eticaret.Core.Model.Entity
{
  public  class Tedarikci : EntityBase
    {
        public string TedarıkciID { get; set; }
        public string TedarikciAdı { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
    }
}
