using DesafioAlura.Entidades;
using DesafioAlura.Interfaces;

namespace DesafioAlura.Servicos
{
    public class UsuarioServico : IServico
    {
        private readonly IRepositoryBase<Usuario> _usuarioRepository;

        public UsuarioServico(IRepositoryBase<Usuario> usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Add(Usuario usuario)
        {
            _usuarioRepository.Add(usuario);
        }

        public void Update(Usuario usuario)
        {
            _usuarioRepository.Update(usuario);
        }

        public void Delete(Usuario usuario)
        {
            _usuarioRepository.Delete(usuario);
        }

        public Usuario GetById(Guid id)
        {
            return _usuarioRepository.GetById(id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll();
        }
    }
}
