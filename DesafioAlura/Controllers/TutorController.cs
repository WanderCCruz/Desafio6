using DesafioAlura.Context;
using DesafioAlura.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAlura.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TutorController : ControllerBase
    {
        private AdoPetContext _context;

        public TutorController(AdoPetContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AdicionaTutor([FromBody] Tutor tutor)
        {
            _context.Tutores.Add(tutor);
            _context.SaveChanges();
            return StatusCode(201);
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
        public IActionResult AtualizaTutor(int id, [FromBody] Tutor tutorUpdate)
        {
            var tutor = _context.Tutores.FirstOrDefault(t => t.Id == id);
            if (tutor == null) return NotFound();
            tutor = tutorUpdate;
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
