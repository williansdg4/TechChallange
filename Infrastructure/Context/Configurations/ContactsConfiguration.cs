using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configurations
{
    public class ContactsConfiguration : IEntityTypeConfiguration<Contacts>
    {
        public void Configure(EntityTypeBuilder<Contacts> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnType("INT").ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(c => c.Name).HasColumnType("VARCHAR(200)").IsRequired();
            builder.Property(c => c.PhoneNumber).HasColumnType("VARCHAR(10)").IsRequired();
            builder.Property(c => c.Email).HasColumnType("VARCHAR(200)").IsRequired();

            builder.HasOne(c => c.Region)
                .WithMany(r => r.Contacts)
                .HasPrincipalKey(c => c.Ddd)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
