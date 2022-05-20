using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Galeri : CoreEntity
    {
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string DosyaYolu { get; set; }
        //Navigation Property
        public virtual List<Araba> Arabalar { get; set; }
    }
}
