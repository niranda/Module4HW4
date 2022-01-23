using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShopApp.EntityConfigurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.ProjectId);
            builder.Property(p => p.ProjectId).IsRequired().HasColumnName("ProjectId").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
            builder.Property(p => p.Budget).IsRequired().HasColumnName("Budget");
            builder.Property(p => p.StartedDate).IsRequired().HasColumnName("StartedName").HasMaxLength(7);
        }
    }
}
