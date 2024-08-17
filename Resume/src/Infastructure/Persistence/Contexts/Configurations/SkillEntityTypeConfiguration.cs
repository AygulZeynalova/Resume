using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Resume.Models.Entities;

namespace Persistence.Contexts.Configurations
{
    public class SkillEntityTypeConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.Property(s => s.Id).HasColumnType("int").UseIdentityColumn();
            builder.Property(s => s.Name).HasColumnType("nvarchar(100)");
            builder.Property(s => s.GroupId).HasColumnType("int");
            builder.Property(s => s.CreatedBy).HasColumnType("int").IsRequired();
            builder.Property(s => s.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(s => s.LastModifiedBy).HasColumnType("int");
            builder.Property(s => s.LastModifiedAt).HasColumnType("datetime");
            builder.Property(s => s.DeletedBy).HasColumnType("int");
            builder.Property(s => s.DeletedAt).HasColumnType("datetime");
            builder.HasKey(s => s.Id);
            builder.HasOne(s => s.SkillGroup)
                   .WithMany()
                   .HasForeignKey(s => s.GroupId);
            builder.ToTable("Skills");
        }
    }
}
