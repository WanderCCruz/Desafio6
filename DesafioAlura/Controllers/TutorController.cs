using AutoMapper;
using DesafioAlura.Context;
using DesafioAlura.DTOs;
using DesafioAlura.DTOs;
using DesafioAlura.Entidades;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAlura.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TutorController : ControllerBase
    {
        private AdoPetContext _context;
        private IMapper _mapper;

        public TutorController(AdoPetContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AdicionaTutor([FromBody] CreateTutorDtO tutorDTo)
        {
            Tutor tutor = _mapper.Map<Tutor>(tutorDTo);
            _context.Tutores.Add(tutor);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaTutorPorId), new { id = tutor.Id }, tutor);
        }

        [HttpGet]
        public IEnumerable<Tutor> RecuperarTutores()
        {
            return _context.Tutores;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaTutorPorId(int id)
        {
            var tutor = _context.Tutores.FirstOrDefault(t => t.Id == id);
            if (tutor == null) return NotFound();
            return Ok(tutor);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaTutor(int id, [FromBody] UpdateTutorDtO updateTutorDTo)
        {
            var tutor = _context.Tutores.FirstOrDefault(t => t.Id == id);
            if (tutor == null) return NotFound();
            _mapper.Map(updateTutorDTo, tutor);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult AtualizaTutorParcial(int id, JsonPatchDocument <UpdateTutorDtO> tutorPatch)
        {
            var tutor = _context.Tutores.FirstOrDefault(t => t.Id == id);
            if (tutor == null) return NotFound();

            var tutorParaAtualizar = _mapper.Map<UpdateTutorDtO>(tutor);
            tutorPatch.ApplyTo(tutorParaAtualizar,ModelState);
            if (!TryValidateModel(tutorParaAtualizar))
                return ValidationProblem(ModelState);

            _mapper.Map(tutorParaAtualizar, tutor);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTutor(int id)
        {
            var tutor = _context.Tutores.FirstOrDefault(t => t.Id == id);
            if (tutor == null) return NotFound();
            _context.Remove(tutor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
