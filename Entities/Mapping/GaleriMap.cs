using Core.Mapping;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mapping
{
    public class GaleriMap : CoreMap<Galeri>
    {
        public override void Configure(EntityTypeBuilder<Galeri> builder)
        {
            builder.Property(x => x.Ad).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Adres).HasMaxLength(500).IsRequired(false);
            builder.HasMany(x => x.Arabalar).WithOne(x => x.Galeri).HasForeignKey(x => x.GaleriId);
            base.Configure(builder);
        }
    }
}
