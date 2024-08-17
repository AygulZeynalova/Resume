using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Resume.Models.Entities;


namespace Persistence.Contexts.Configurations
{
    public class ProjectEntityTypeConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.Property(p => p.Id).HasColumnType("int").UseIdentityColumn();
            builder.Property(p => p.Title).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(p => p.ImagePath).HasColumnType("varchar(200)").IsRequired();
            builder.Property(p => p.Url).HasColumnType("varchar(300)").IsRequired();
            builder.Property(p => p.CreatedBy).HasColumnType("int").IsRequired();
            builder.Property(p => p.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.LastModifiedBy).HasColumnType("int");
            builder.Property(p => p.LastModifiedAt).HasColumnType("datetime");
            builder.Property(p => p.DeletedBy).HasColumnType("int");
            builder.Property(p => p.DeletedAt).HasColumnType("datetime");
            builder.HasKey(p => p.Id);
            builder.ToTable("Projects");
        }
    }
}
