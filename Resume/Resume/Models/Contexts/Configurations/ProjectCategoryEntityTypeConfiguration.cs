using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Resume.Models.Entities;

namespace Resume.Models.Contexts.Configurations
{
    public class ProjectCategoryEntityTypeConfiguration : IEntityTypeConfiguration<ProjectCategory>
    {
        public void Configure(EntityTypeBuilder<ProjectCategory> builder)
        {
            builder.HasKey(pc => new { pc.ProjectId, pc.CategoryId });
            builder.HasOne(pc => pc.Project)
                   .WithMany()
                   .HasForeignKey(pc => pc.ProjectId);
            builder.HasOne(pc => pc.Category)
                   .WithMany()
                   .HasForeignKey(pc => pc.CategoryId);
            builder.ToTable("ProjectCategories");
        }
    }
}
