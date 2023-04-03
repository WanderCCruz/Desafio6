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

        public void AddProduct(Usuario usuario)
        {
            _usuarioRepository.Add(usuario);
        }

        public void UpdateProduct(Usuario usuario)
        {
            _usuarioRepository.Update(usuario);
        }

        public void DeleteProduct(Usuario usuario)
        {
            _usuarioRepository.Delete(usuario);
        }

        public Usuario GetProductById(int id)
        {
            return _usuarioRepository.GetById(id);
        }

        public IEnumerable<Usuario> GetAllProducts()
        {
            return _usuarioRepository.GetAll();
        }
    }
}
