namespace TYH.EntityFrameworkCore.Configurations
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TYH.Domain.Entities;
    using TYH.EntityFrameworkCore.Extensions;
    public class SystemConfigConfiguration : DbEntityConfiguration<SystemConfig>
    {
        public override void Configure(EntityTypeBuilder<SystemConfig> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
           
        }
    }
}
