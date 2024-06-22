using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class RegionsConfiguration : IEntityTypeConfiguration<Regions>
    {
        public void Configure(EntityTypeBuilder<Regions> builder)
        {
            builder.ToTable("Regions");
            builder.HasKey(r => r.Ddd);
            builder.Property(r => r.Ddd).HasColumnType("INT").IsRequired();
            builder.Property(r => r.RegionName).HasColumnType("VARCHAR(100)").IsRequired();
        }
    }
}
