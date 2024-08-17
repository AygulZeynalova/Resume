using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Resume.Models.Entities;

namespace Persistence.Contexts.Configurations
{
    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Id).HasColumnType("int").UseIdentityColumn();
            builder.Property(c => c.Name).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(c => c.CreatedBy).HasColumnType("int").IsRequired();
            builder.Property(c => c.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(c => c.LastModifiedBy).HasColumnType("int");
            builder.Property(c => c.LastModifiedAt).HasColumnType("datetime");
            builder.Property(c => c.DeletedBy).HasColumnType("int");
            builder.Property(c => c.DeletedAt).HasColumnType("datetime");
            builder.HasKey(c => c.Id);
            builder.ToTable("Categories");
        }
    }
}
