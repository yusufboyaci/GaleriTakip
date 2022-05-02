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
    public class SiparisMap : CoreMap<Siparis>
    {
        public override void Configure(EntityTypeBuilder<Siparis> builder)
        {
            builder.HasOne(x => x.Musteri).WithMany(x => x.Siparisler).HasForeignKey(x => x.MusteriId).OnDelete(DeleteBehavior.NoAction);
            base.Configure(builder);
        }
    }
}
