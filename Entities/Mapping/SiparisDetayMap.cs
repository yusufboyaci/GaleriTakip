using Core.Mapping;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Mapping
{
    public class SiparisDetayMap : CoreMap<SiparisDetay>
    {
        public override void Configure(EntityTypeBuilder<SiparisDetay> builder)
        {
            builder.Property(x => x.Miktar).IsRequired(false);
            base.Configure(builder);
        }
    }
}
