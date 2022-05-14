using Entities.SqlViews;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.SqlViewsMapping
{
    public class V_ArabaVeGaleriTablosuMap : IEntityTypeConfiguration<V_ArabaVeGaleriTablosu>
    {
        public void Configure(EntityTypeBuilder<V_ArabaVeGaleriTablosu> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
