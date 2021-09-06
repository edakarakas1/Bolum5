using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND.And.Eticaret.Core.Model.Entity
{
   public class Sepet : EntityBase
    {
        public int PazarlamaciID { get; set; }
        public int ÜrünID { get; set; }
        public Ürün Ürün { get; set; }
        public int Adet { get; set; }
    }
}
