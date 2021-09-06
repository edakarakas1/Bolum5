using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND.And.Eticaret.Core.Model.Entity
{
   public class Ürün : EntityBase
    {
        public string ÜrünKoduID { get; set; }
        public string ÜrünAdı { get; set; }
        public string ÜrünTedarikci { get; set; }
        public string ÜrünKategoriID { get; set; }
        public Kategori Kategori { get; set; }
        public string Model { get; set; }//belki silersin bunu dikkat
        public string ResimUrl { get; set; }
        public string Aciklama { get; set; }
        public decimal AlısFiyat { get; set; }
        public decimal SatısFiyat { get; set; }
        public decimal KDV { get; set; }
        public decimal İndirim { get; set; }
        public int Stok { get; set; }
        public bool Aktif { get; set; }

    }
}
