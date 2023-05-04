namespace AdoPet.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(int id);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
    }
}
