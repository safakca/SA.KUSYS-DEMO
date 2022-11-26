using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Entites;
using System.Linq.Expressions;

namespace Business.Concrete;

public class StudentManager : IStudentService
{
    private readonly IStudentDal _studentDal;

    public StudentManager(IStudentDal studentDal)
    {
        _studentDal = studentDal;
    }

    public Student Create(Student entity) => _studentDal.Create(entity);
    public bool Delete(int id) => _studentDal.Delete(id);
    public Student Update(Student entity) => _studentDal.Update(entity);
    public Student GetFilter(Expression<Func<Student, bool>> expression) => _studentDal.GetFilter(expression);
    public List<Student> GetAll(Expression<Func<Student, bool>> expression = null) => _studentDal.GetAll(expression); 
    public List<Student> GetAllStudentByCourse() => _studentDal.GetAllStudentByCourse();
    public Student GetStudentByCourse(int id) => _studentDal.GetStudentByCourse(id);
}
