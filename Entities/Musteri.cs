using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum Role
    {
        None = 0,
        Member = 1,
        Admin = 2
    }
    public class Musteri : CoreEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string TelefonNumarasi { get; set; }
        public Role? Role { get; set; }
        public DateTime? DogumGunu { get; set; }
        public virtual List<Siparis> Siparisler { get; set; }
    }
}
