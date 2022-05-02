using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Siparis : CoreEntity
    {
        public Siparis()
        {
            SiparisDetaylar = new List<SiparisDetay>();
        }
        public Guid MusteriId { get; set; }//FK
        public bool OnaylandiMi { get; set; }
        //Navigation Properties
        public virtual Musteri Musteri { get; set; }
        public virtual List<SiparisDetay> SiparisDetaylar { get; set; }

    }
}
