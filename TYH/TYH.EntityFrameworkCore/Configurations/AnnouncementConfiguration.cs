using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TYH.Domain.Entities;
using TYH.EntityFrameworkCore.Extensions;

namespace TYH.EntityFrameworkCore.Configurations
{
   public class AnnouncementConfiguration:DbEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(128).IsRequired();

        }
    }
}
