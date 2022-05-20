using Core.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.SqlViews
{
    [NotMapped]
    public class V_ArabaVeGaleriTablosu
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public string Ad { get; set; }
        public decimal? Ucret { get; set; }
        public int? Stok { get; set; }
        public string Birim { get; set; }
        public string DosyaYolu { get; set; }
        public Guid GaleriId { get; set; }
        public string GaleriAd { get; set; }
        public string GaleriAdres { get; set; }
    }
}
