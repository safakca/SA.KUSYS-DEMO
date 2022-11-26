using Business.Repositories;
using DataAccess.Entites;

namespace Business.Abstract;

public interface IStudentService : IBaseService<Student>
{
    List<Student> GetAllStudentByCourse();
    Student GetStudentByCourse(int id);
}
