using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Entites;
using System.Linq.Expressions;

namespace Business.Concrete;

public class CourseManager : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public Course Create(Course entity) => _courseDal.Create(entity);
    public bool Delete(int id) => _courseDal.Delete(id);
    public Course Update(Course entity) => _courseDal.Update(entity);
    public Course GetFilter(Expression<Func<Course, bool>> expression) => _courseDal.GetFilter(expression);
    public List<Course> GetAll(Expression<Func<Course, bool>> expression = null) => _courseDal.GetAll(expression);
}