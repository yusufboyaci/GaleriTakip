using Core.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mapping
{
    public class MusteriMap : CoreMap<Musteri>
    {
        public override void Configure(EntityTypeBuilder<Musteri> builder)
        {
            builder.Property(x => x.Ad).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.Soyad).HasMaxLength(50).IsRequired(false);
            builder.Property(x => x.KullaniciAdi).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Password).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.Adres).HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.TelefonNumarasi).HasMaxLength(100).IsRequired(false);
            builder.Property(x => x.DogumGunu).HasColumnType("datetime2").IsRequired(false);
            builder.HasMany(x => x.Siparisler).WithOne(x => x.Musteri);
            base.Configure(builder);
        }
    }
}
