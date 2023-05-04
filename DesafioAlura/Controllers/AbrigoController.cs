using AdoPet.Repository;
using AutoMapper;
using DesafioAlura.DTOs.Abrigo;
using DesafioAlura.DTOs.Pet;
using DesafioAlura.DTOs.Usuario;
using DesafioAlura.Entidades;
using DesafioAlura.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAlura.Controllers
{
    [ApiController]
    [Route("Abrigos")]
    public class AbrigoController : ControllerBase
    {
        private IRepositoryBase<Abrigo> _repository;
        private IMapper _mapper;
        private AbrigoService _abrigoServico;

        public AbrigoController(IRepositoryBase<Abrigo> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _abrigoServico = new AbrigoService(_repository);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AdicionaAbrigo([FromBody] CreateAbrigoDTO abrigoDTO)
        {
            Abrigo abrigo = _mapper.Map<Abrigo>(abrigoDTO);
            _abrigoServico.Add(abrigo);
            return CreatedAtAction(nameof(RecuperaAbrigoPorId), new { id = abrigo.Id }, abrigo);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaAbrigoPorId(Guid id)
        {
            var abrigo = _abrigoServico.GetById(id);
            if (abrigo == null) return NotFound();
            return Ok(abrigo);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Abrigo>> RecuperarAbrigos()
        {
            var abrigo = _abrigoServico.GetAll();
            if (!abrigo.Any())
                return NotFound();
            return Ok(abrigo);
        }
        [HttpPut("{id}")]
        public IActionResult AtualizaAbrigo(Guid id, [FromBody] UpdateAbrigoDTO updateAbrigoDTo)
        {
            var abrigo = _abrigoServico.GetById(id);
            if (abrigo == null) return NotFound();
            _abrigoServico.Update(_mapper.Map(updateAbrigoDTo, abrigo));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbrigo(Guid id)
        {
            var abrigo = _abrigoServico.GetById(id);
            if (abrigo == null) return NotFound();
            _abrigoServico.Delete(abrigo);
            return NoContent();
        }
    }
 }

