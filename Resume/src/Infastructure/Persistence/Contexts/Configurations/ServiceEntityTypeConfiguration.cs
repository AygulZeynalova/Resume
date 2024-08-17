using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Resume.Models.Entities;

namespace Persistence.Contexts.Configurations
{
    public class ServiceEntityTypeConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.Property(s => s.Id).HasColumnType("int").UseIdentityColumn();
            builder.Property(s => s.CssClass).HasColumnType("varchar(100)");
            builder.Property(s => s.Title).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(s => s.Description).HasColumnType("nvarchar(500)");
            builder.Property(s => s.CreatedBy).HasColumnType("int").IsRequired();
            builder.Property(s => s.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(s => s.LastModifiedBy).HasColumnType("int");
            builder.Property(s => s.LastModifiedAt).HasColumnType("datetime");
            builder.Property(s => s.DeletedBy).HasColumnType("int");
            builder.Property(s => s.DeletedAt).HasColumnType("datetime");
            builder.HasKey(s => s.Id);
            builder.ToTable("Services");
        }
    }
}
