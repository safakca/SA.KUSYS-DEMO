using DataAccess.Entites;
using DataAccess.Repositories;

namespace DataAccess.Abstract; 
public interface IStudentDal : IBaseRepository<Student>
{
    List<Student> GetAllStudentByCourse();
    Student GetStudentByCourse(int id);
}
