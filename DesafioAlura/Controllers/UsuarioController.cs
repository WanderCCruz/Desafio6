using AutoMapper;
using DesafioAlura.DTOs.Tutor;
using DesafioAlura.DTOs.Usuario;
using DesafioAlura.Entidades;
using DesafioAlura.Interfaces;
using DesafioAlura.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAlura.Controllers
{
    [ApiController]
    [Route("Usuarios")]
    public class UsuarioController : ControllerBase
    {
        private IMapper _mapper;
        private readonly IRepository<Usuario> _repository;
        private readonly UsuarioServico _usuarioServico;

        public UsuarioController(IMapper mapper, IRepository<Usuario> repository)
        {
            _mapper = mapper;
            _repository = repository;
            _usuarioServico = new UsuarioServico(_repository);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AdicionaTutor([FromBody] CreateUsuarioDTO usuarioDTo)
        {
            Usuario usuario = _mapper.Map<Usuario>(usuarioDTo);
            _usuarioServico.Add(usuario);
            return CreatedAtAction(nameof(RecuperaUsuarioPorId), new { id = usuario.Id }, usuario);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaUsuarioPorId(Guid id)
        {
            var usuario = _usuarioServico.GetById(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> RecuperarUsuarios()
        {
            var usuarios = _usuarioServico.GetAll();
            if (!usuarios.Any())
                return NotFound();
            return Ok(usuarios);
        }
        [HttpPut("{id}")]
        public IActionResult AtualizaTutor(Guid id, [FromBody] UpdateUsuarioDTO updateUsuarioDTo)
        {
            var usuario = _usuarioServico.GetById(id);
            if (usuario == null) return NotFound();
            _usuarioServico.Update(_mapper.Map(updateUsuarioDTo, usuario));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(Guid id)
        {
            var usuario = _usuarioServico.GetById(id);
            if (usuario == null) return NotFound();
            _usuarioServico.Delete(usuario);
            return NoContent();
        }
    }
}
