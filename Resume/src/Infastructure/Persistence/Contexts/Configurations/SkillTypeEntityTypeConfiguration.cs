using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Resume.Models.Entities;

namespace Persistence.Contexts.Configurations
{
    public class SkillTypeEntityTypeConfiguration : IEntityTypeConfiguration<SkillType>
    {
        public void Configure(EntityTypeBuilder<SkillType> builder)
        {
            builder.Property(st => st.Id).HasColumnType("int").UseIdentityColumn();
            builder.Property(st => st.Name).HasColumnType("nvarchar(100)");
            builder.Property(st => st.CreatedBy).HasColumnType("int").IsRequired();
            builder.Property(st => st.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(st => st.LastModifiedBy).HasColumnType("int");
            builder.Property(st => st.LastModifiedAt).HasColumnType("datetime");
            builder.Property(st => st.DeletedBy).HasColumnType("int");
            builder.Property(st => st.DeletedAt).HasColumnType("datetime");
            builder.HasKey(st => st.Id);
            builder.ToTable("SkillTypes");
        }
    }
}
