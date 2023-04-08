using AutoMapper;
using DesafioAlura.DTOs.Pet;
using DesafioAlura.DTOs.Tutor;
using DesafioAlura.Entidades;
using DesafioAlura.Interfaces;
using DesafioAlura.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAlura.Controllers
{
    [ApiController]
    [Route("Pet")]
    public class PetController : ControllerBase
    {
        private IRepository<Pet> _repository;
        private IMapper _mapper;
        private PetServico _petServico;

        public PetController(IRepository<Pet> repository, IMapper mapper)
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
        public IActionResult RecuperaPetPorId(int id)
        {
            var pet = _petServico.GetById(id);
            if (pet == null) return NotFound();
            return Ok(pet);
        }
    }
}
