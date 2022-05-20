using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace Entities
{
    public class Araba : CoreEntity
    {
        public string Ad { get; set; }
        public decimal? Ucret { get; set; }
        public int? Stok { get; set; }
        public string Birim { get; set; }
        public string DosyaYolu { get; set; }
        public Guid GaleriId { get; set; }//FK
        //Navigation Property
        public virtual Galeri Galeri { get; set; }
        public virtual List<SiparisDetay> SiparisDetaylar { get; set; }

    }
}
