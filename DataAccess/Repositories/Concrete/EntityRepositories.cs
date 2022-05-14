using Core.Enum;
using DataAccess.Context;
using Entities;
using Entities.SqlViews;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace DataAccess.Repositories.Concrete
{
    public class ArabaRepository : Repository<Araba>
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public ArabaRepository(AppDbContext context, IWebHostEnvironment env) : base(context)
        {
            _context = context;
            _env = env;
        }
        public List<V_ArabaVeGaleriTablosu> ArabaVeGaleriTablosuListele()
        {
            return _context.ArabaVeGaleriTablosu.Where(x => x.Status == Status.Active).ToList();
        }
        public void ResimKaydet(Araba araba)
        {
            if (araba.Resim != null)
            {
                string resimler = Path.Combine(_env.WebRootPath,"images");
                if (araba.Resim.Length > 0)
                {
                    using(FileStream file = new FileStream(Path.Combine(resimler,araba.Resim.FileName), FileMode.Create))
                    {
                        araba.Resim.CopyTo(file);
                    }
                }
                araba.ResimYolu = araba.Resim.FileName;
            }
        }
    }
    public class GaleriRepository : Repository<Galeri>
    {
        private readonly AppDbContext _context;
        public GaleriRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
    public class SiparisRepository : Repository<Siparis>
    {
        private readonly AppDbContext _context;
        public SiparisRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public List<Siparis> OnaylanmamisSiparisleriListele()
        {
            return GetDefault(x => x.Status == Status.Active && x.OnaylandiMi == false).OrderByDescending(x => x.CreatedDate).ToList();
        }
        public int OnaylanmamisSiparislerinSayisiniGoster()
        {
            return GetDefault(x => x.Status == Status.Active && x.OnaylandiMi == false).ToList().Count;
        }
    }
    public class SiparisDetayRepository : Repository<SiparisDetay>
    {
        private readonly AppDbContext _context;
        public SiparisDetayRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
    public class MusteriRepository : Repository<Musteri>
    {
        private readonly AppDbContext _context;
        public MusteriRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public Musteri MusteriyiKullaniciAdiylaGetir(string kullaniciAdi)
        {
            return GetByDefault(x => x.KullaniciAdi == kullaniciAdi);
        }
        public bool KimlikKontrolEt(string kullaniciAdi, string sifre)
        {
            return Any(x => x.KullaniciAdi == kullaniciAdi && x.Password == sifre);
        }
    }
}
