using DataAccess.Context;
using DataAccess.Entites;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Repositories; 
public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private readonly BaseContext _context; 
    public BaseRepository(BaseContext context)
    {
        _context = context;
    } 
    public T Create(T entity)
    {
        _context.Set<T>().Add(entity);
        _context.SaveChanges();
        return entity;
    } 
    public T Update(T entity)
    {
        _context.Set<T>().Update(entity);
        _context.SaveChanges();
        return entity;
    }
    public bool Delete(int id)
    {
        var result = GetFilter(x => x.Id == id);
        _context.Remove(result);
        _context.SaveChanges();
        return true;
    } 
    public List<T> GetAll(Expression<Func<T, bool>> expression = null)
    {
        return expression == null
           ? _context.Set<T>().AsNoTracking().ToList()
           : _context.Set<T>().Where(expression).AsNoTracking().ToList();
    } 
    public T GetFilter(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().SingleOrDefault(expression);
    }
}
