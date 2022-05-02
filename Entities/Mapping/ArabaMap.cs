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
    public class ArabaMap : CoreMap<Araba>
    {
        public override void Configure(EntityTypeBuilder<Araba> builder)
        {
            builder.Property(x => x.Ad).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Birim).HasMaxLength(50).IsRequired(false);
            builder.HasOne(x => x.Galeri).WithMany(x => x.Arabalar).HasForeignKey(x => x.GaleriId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(x => x.SiparisDetaylar).WithOne(x => x.Araba);
            base.Configure(builder);
        }
    }
}
