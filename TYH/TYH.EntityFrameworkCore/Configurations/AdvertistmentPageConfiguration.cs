using System;
using System.Collections.Generic;
using System.Text;

namespace TYH.EntityFrameworkCore.Configurations
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TYH.Domain.Entities;
    using TYH.EntityFrameworkCore.Extensions;
   public class AdvertistmentPageConfiguration: DbEntityConfiguration<AdvertistmentPage>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPage> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();

        }
    }
}
