namespace DataAccess.Dtos;

public class GetStudentDto
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string BirthDate { get; set; }
    public string CourseName { get; set; }
}
