using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Resume.Models.Entities;

namespace Persistence.Contexts.Configurations
{
    public class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(p => p.Id).HasColumnType("int").UseIdentityColumn();
            builder.Property(p => p.FullName).HasColumnType("nvarchar(200)");
            builder.Property(p => p.Experience).HasColumnType("tinyint");
            builder.Property(p => p.DateOfBirth).HasColumnType("date");
            builder.Property(p => p.Location).HasColumnType("nvarchar(200)");
            builder.Property(p => p.Degree).HasColumnType("nvarchar(50)");
            builder.Property(p => p.Bio).HasColumnType("nvarchar(max)");
            builder.Property(p => p.Fax).HasColumnType("varchar(50)");
            builder.Property(p => p.Website).HasColumnType("varchar(200)");
            builder.Property(p => p.AttachmentPath).HasColumnType("varchar(100)");
            builder.Property(p => p.CareerLevel).HasColumnType("nvarchar(50)");
            builder.Property(p => p.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.HasKey(p => p.Id);
            builder.ToTable("Persons");
        }
    }
}
