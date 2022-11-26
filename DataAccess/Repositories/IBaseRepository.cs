using DataAccess.Entites;
using System.Linq.Expressions;

namespace DataAccess.Repositories; 
public interface IBaseRepository<T> where T : BaseEntity
{
    T Create(T entity);
    bool Delete(int id);
    T Update(T entity);
    List<T> GetAll(Expression<Func<T, bool>> expression = null);
    T GetFilter(Expression<Func<T, bool>> expression);
}
