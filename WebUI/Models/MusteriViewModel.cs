using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public enum Role
    {
        None = 0,
        Member = 1,
        Admin = 2
    }
    public class MusteriViewModel
    {
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz!")]
        public string Ad { get; set; }
        [Display(Name = "Soyad")]
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz!")]
        public string Soyad { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz!")]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz!")]
        [DisplayFormat(ApplyFormatInEditMode = true, ConvertEmptyStringToNull = false)]
        public string Password { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Lütfen Email Adresini Giriniz!")]
        public string Email { get; set; }
        [Display(Name = "Adres")]
        [Required(ErrorMessage = "Lütfen Adres Alanını Doldurunuz!")]
        public string Adres { get; set; }
        [Display(Name = "Telefon Numarası")]
        [Required(ErrorMessage = "Lütfen Telefon Numaranızı Yazınız!")]
        public string TelefonNumarasi { get; set; }
        public string DosyaYolu { get; set; }
        [NotMapped]
        public IFormFile Resim { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen Rolünüzü Bleirleyiniz.!")]
        public Role? Role { get; set; }
        public DateTime? DogumGunu { get; set; }
    }
}
