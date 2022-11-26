using System.Linq.Expressions;

namespace Business.Repositories
{
    public interface IBaseService<T> where T : class
    {
        T Create(T entity);
        bool Delete(int id);
        T Update(T entity);
        List<T> GetAll(Expression<Func<T, bool>> expression = null);
        T GetFilter(Expression<Func<T, bool>> expression);
    }
}
