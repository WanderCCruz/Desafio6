namespace DesafioAlura.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}
