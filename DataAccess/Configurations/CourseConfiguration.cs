using DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations;
public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("Courses");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).IsRequired().HasColumnName("Name");

        builder.HasMany(x => x.Students);

        Course[] courses =
        {
             new() { Id=1, Name="Introduction to Computer Science" } ,
             new() { Id=2, Name="Algorithms" } ,
             new() { Id=3, Name="Calculus" } ,
             new() { Id=4, Name="Physics" }
        };

        builder.HasData(courses);
    }
}