using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Resume.Models.Entities;

namespace Resume.Models.Contexts.Configurations
{
    public class BlogPostEntityTypeConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.Property(p => p.Id).HasColumnType("int").UseIdentityColumn();
            builder.Property(p => p.Title).HasColumnType("nvarchar(200)").IsRequired();
            builder.Property(p => p.Body).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(p => p.ImagePath).HasColumnType("varchar(100)");
            builder.Property(p => p.CreatedBy).HasColumnType("int").IsRequired();
            builder.Property(p => p.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(p => p.PublishedBy).HasColumnType("int");
            builder.Property(p => p.PublishedAt).HasColumnType("datetime");
            builder.Property(p => p.LastModifiedBy).HasColumnType("int");
            builder.Property(p => p.LastModifiedAt).HasColumnType("datetime");
            builder.Property(p => p.DeletedBy).HasColumnType("int");
            builder.Property(p => p.DeletedAt).HasColumnType("datetime");

            builder.HasKey(p => p.Id);
            builder.ToTable("BlogPosts");
        }
    }
}
