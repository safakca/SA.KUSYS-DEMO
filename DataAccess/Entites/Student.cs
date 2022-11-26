namespace DataAccess.Entites;  
public class Student : BaseEntity
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string BirthDate { get; set; }
    public virtual Course Course { get; set; }
}
