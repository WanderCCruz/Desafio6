using DesafioAlura.Entidades;

namespace AdoPet.Servicos.Interfaces
{
    public interface IServico
    {
        public void Add(Usuario usuario);

        public void Update(Usuario usuario);

        public void Delete(Usuario usuario);
        public Usuario GetById(Guid id);

        public IEnumerable<Usuario> GetAll();
    }
}
