using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Entites;
using DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete; 
public class StudentDal : BaseRepository<Student>, IStudentDal
{
    private readonly BaseContext _context;
    public StudentDal(BaseContext context) : base(context)
    {
        _context = context;
    } 
    public List<Student> GetAllStudentByCourse()
    {
        return _context.Students.Include(x => x.Course).ToList();
    } 
    public Student GetStudentByCourse(int id)
    {
        return _context.Students.Include(x => x.Course).SingleOrDefault(x => x.Id == id);
    }
}
