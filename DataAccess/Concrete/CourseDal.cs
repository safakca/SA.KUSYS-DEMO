using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Entites;
using DataAccess.Repositories;

namespace DataAccess.Concrete; 
public class CourseDal : BaseRepository<Course>, ICourseDal
{
    public CourseDal(BaseContext context) : base(context) { }
}
