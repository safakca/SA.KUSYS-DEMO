namespace DataAccess.Entites; 
public class Course : BaseEntity
{
    public string Name { get; set; }
    public virtual ICollection<Student> Students { get; set; }
}
