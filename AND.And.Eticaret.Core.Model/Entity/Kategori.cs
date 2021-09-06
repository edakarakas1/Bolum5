using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND.And.Eticaret.Core.Model.Entity
{
   public class Kategori : EntityBase
    {
        public int AltÜtsKategoriID { get; set; } = 0;
        public string KategoriAdı { get; set; }
        public bool Aktif { get; set; }
    }
}
