using AdoPet.Repository;
using AutoMapper;
using DesafioAlura.DTOs.Pet;
using DesafioAlura.DTOs.Tutor;
using DesafioAlura.DTOs.Usuario;
using DesafioAlura.Entidades;
using DesafioAlura.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAlura.Controllers
{
    [ApiController]
    [Route("Pets")]
    public class PetController : ControllerBase
    {
        private IRepositoryBase<Pet> _repository;
        private IMapper _mapper;
        private PetServico _petServico;

        public PetController(IRepositoryBase<Pet> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            _petServico = new PetServico(_repository);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AdicionaPet([FromBody] CreatePetDTO petDTO)
        {
            Pet pet = _mapper.Map<Pet>(petDTO);
            _petServico.Add(pet);
            return CreatedAtAction(nameof(RecuperaPetPorId), new { id = pet.Id }, pet);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaPetPorId(Guid id)
        {
            var pet = _petServico.GetById(id);
            if (pet == null) return NotFound();
            return Ok(pet);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pet>> RecuperarTutores()
        {
            var pet = _petServico.GetAll();
            if (!pet.Any())
                return NotFound();
            return Ok(pet);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaPet(Guid id, [FromBody] UpdatePetDTO updatePetDTo)
        {
            var pet = _petServico.GetById(id);
            if (pet == null) return NotFound();
            _petServico.Update(_mapper.Map(updatePetDTo, pet));
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePet(Guid id)
        {
            var pet = _petServico.GetById(id);
            if (pet == null) return NotFound();
            _petServico.Delete(pet);
            return NoContent();
        }
    }
}
