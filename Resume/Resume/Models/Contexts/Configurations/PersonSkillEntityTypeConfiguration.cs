using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Resume.Models.Entities;

namespace Resume.Models.Contexts.Configurations
{
    public class PersonSkillEntityTypeConfiguration : IEntityTypeConfiguration<PersonSkill>
    {
        public void Configure(EntityTypeBuilder<PersonSkill> builder)
        {
            builder.HasKey(ps => new { ps.PersonId, ps.SkillId });
            builder.Property(ps => ps.Mode).HasColumnType("int");
            builder.Property(ps => ps.Percentage).HasColumnType("tinyint");
            builder.Property(ps => ps.CreatedBy).HasColumnType("int").IsRequired();
            builder.Property(ps => ps.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(ps => ps.LastModifiedBy).HasColumnType("int");
            builder.Property(ps => ps.LastModifiedAt).HasColumnType("datetime");
            builder.Property(ps => ps.DeletedBy).HasColumnType("int");
            builder.Property(ps => ps.DeletedAt).HasColumnType("datetime");
            builder.HasOne(ps => ps.Person)
                   .WithMany()
                   .HasForeignKey(ps => ps.PersonId);
            builder.HasOne(ps => ps.Skill)
                   .WithMany()
                   .HasForeignKey(ps => ps.SkillId);
            builder.ToTable("PersonSkills");
        }
    }
}
