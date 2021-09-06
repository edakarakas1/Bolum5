using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AND.And.Eticaret.Core.Model
{
   public class EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
        public DateTime OlusturmaTarih { get; set; }
        public int OlusturKullaniciID { get; set; }
        public DateTime? GüncellemeTarih { get; set; }
        public int? KullaniciGüncelleID { get; set; }//?soru işareti boş bırakılır demek

    }
}
