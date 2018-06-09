using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace TYH.EntityFrameworkCore.Configurations
{
    using TYH.Domain.Entities;
    using TYH.EntityFrameworkCore.Extensions;
    public class AdvertistmentPositionConfiguration : DbEntityConfiguration<AdvertistmentPosition>
    {
        public override void Configure(EntityTypeBuilder<AdvertistmentPosition> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(20).IsRequired();
          
        }
    }
}
