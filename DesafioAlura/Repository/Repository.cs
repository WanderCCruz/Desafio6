using DesafioAlura.Context;
using DesafioAlura.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DesafioAlura.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AdoPetContext _adoPetContext;
        private readonly DbSet<T> _dbSet;

        public Repository(AdoPetContext adoPetContext)
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

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
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
