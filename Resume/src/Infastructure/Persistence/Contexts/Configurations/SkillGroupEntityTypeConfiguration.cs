﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Resume.Models.Entities;

namespace Persistence.Contexts.Configurations
{
    public class SkillGroupEntityTypeConfiguration : IEntityTypeConfiguration<SkillGroup>
    {
        public void Configure(EntityTypeBuilder<SkillGroup> builder)
        {
            builder.Property(sg => sg.Id).HasColumnType("int").UseIdentityColumn();
            builder.Property(sg => sg.TypeId).HasColumnType("int");
            builder.Property(sg => sg.Name).HasColumnType("nvarchar(100)");
            builder.Property(sg => sg.CreatedBy).HasColumnType("int").IsRequired();
            builder.Property(sg => sg.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(sg => sg.LastModifiedBy).HasColumnType("int");
            builder.Property(sg => sg.LastModifiedAt).HasColumnType("datetime");
            builder.Property(sg => sg.DeletedBy).HasColumnType("int");
            builder.Property(sg => sg.DeletedAt).HasColumnType("datetime");
            builder.HasKey(sg => sg.Id);
            builder.HasOne(sg => sg.SkillType)
                   .WithMany()
                   .HasForeignKey(sg => sg.TypeId);
            builder.ToTable("SkillGroup");
        }
    }
}
