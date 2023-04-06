using DesafioAlura.Entidades;

namespace DesafioAlura.Interfaces
{
    public interface IServico<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
