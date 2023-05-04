using AdoPet.Repository;
using DesafioAlura.Context;
using Microsoft.EntityFrameworkCore;

namespace DesafioAlura.Repository
{
    public class RepositoryBase<T> : IDisposable,IRepositoryBase<T> where T : class
    {
        private readonly AdoPetContext _adoPetContext;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(AdoPetContext adoPetContext)
        {
            _adoPetContext = adoPetContext;
            _dbSet = adoPetContext.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _adoPetContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _adoPetContext.SaveChanges();
        }

        public void Dispose()
        {
            _adoPetContext.Dispose();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _adoPetContext.SaveChanges();
        }
    }
}
