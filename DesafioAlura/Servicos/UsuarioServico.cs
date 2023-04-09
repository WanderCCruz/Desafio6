using DesafioAlura.Entidades;
using DesafioAlura.Interfaces;

namespace DesafioAlura.Servicos
{
    public class UsuarioServico
    {
        private readonly IRepository<Usuario> _usuarioRepository;

        public UsuarioServico(IRepository<Usuario> usuarioRepository)
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

        public Usuario GetById(int id)
        {
            return _usuarioRepository.GetById(id);
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
