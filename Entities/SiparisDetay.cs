using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class SiparisDetay : CoreEntity
    {
        public Guid ArabaId { get; set; }//FK
        public decimal? BirimFiyat { get; set; }
        public int? Miktar { get; set; }
        //Navigation Properties
        public virtual Siparis Siparis { get; set; }
        public virtual Araba Araba { get; set; }
    }
}
