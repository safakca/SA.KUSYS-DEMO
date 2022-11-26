using DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Students");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).IsRequired().HasColumnName("Name");
        builder.Property(x => x.Surname).IsRequired().HasColumnName("Surname");
        builder.Property(x => x.BirthDate).IsRequired().HasColumnName("BirthDate");

        builder.HasOne(x => x.Course);

        Student[] students =
        {
             new() { Id=1, CourseId = 1, Name="Martin", Surname="Fowler", BirthDate="11/11/1960" } ,
             new() { Id=2, CourseId = 2, Name="Jason", Surname="Taylor", BirthDate="12/12/1989" } ,
             new() { Id=3, CourseId = 3, Name="Engin", Surname="Demirog", BirthDate="01/01/1984" } ,
             new() { Id=4, CourseId = 4, Name="Bora", Surname="Kasmer", BirthDate="03/12/1979" },
             new() { Id=5, CourseId = 4, Name="Mark", Surname="Price", BirthDate="04/12/1965" },
             new() { Id=6, CourseId = 2, Name="Robert", Surname="Martin", BirthDate="05/12/1978" }
        };

        builder.HasData(students);
    }
}
