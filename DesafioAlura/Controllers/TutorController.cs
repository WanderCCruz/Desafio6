using AutoMapper;
using DesafioAlura.Context;
using DesafioAlura.DTOs.Tutor;
using DesafioAlura.Entidades;
using DesafioAlura.Interfaces;
using DesafioAlura.Repository;
using DesafioAlura.Servicos;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace DesafioAlura.Controllers
{
    [ApiController]
    [Route("Tutores")]
    public class TutorController : ControllerBase
    {
        private IRepository<Tutor> _repository;
        private IMapper _mapper;
        private TutorServico _tutorServico;

        public TutorController(IMapper mapper, IRepository<Tutor> repository)
        {
            _mapper = mapper;
            _repository = repository;
            _tutorServico = new TutorServico(_repository);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult AdicionaTutor([FromBody] CreateTutorDtO tutorDTo)
        {
            Tutor tutor = _mapper.Map<Tutor>(tutorDTo);
            _tutorServico.Add(tutor);
            return CreatedAtAction(nameof(RecuperaTutorPorId), new { id = tutor.Id }, tutor);
        }

        [HttpGet]
        public IEnumerable<Tutor> RecuperarTutores()
        {
            var tutores = _tutorServico.GetAll();
            if (!tutores.Any()) 
                return (IEnumerable<Tutor>)NotFound();
            return _tutorServico.GetAll();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaTutorPorId(int id)
        {
            var tutor = _tutorServico.GetById(id);
            if (tutor == null) return NotFound();
            return Ok(tutor);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult AtualizaTutor(int id, [FromBody] UpdateTutorDtO updateTutorDTo)
        {
            var tutor = _tutorServico.GetById(id);
            if (tutor == null) return NotFound();
             _tutorServico.Update(_mapper.Map(updateTutorDTo, tutor));
            return CreatedAtAction(nameof(RecuperaTutorPorId), new { id = tutor.Id},tutor);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult AtualizaTutorParcial(int id, JsonPatchDocument <UpdateTutorDtO> tutorPatch)
        {
            var tutor = _tutorServico.GetById(id);
            if (tutor == null) return NotFound();

            var tutorParaAtualizar = _mapper.Map<UpdateTutorDtO>(tutor);
            tutorPatch.ApplyTo(tutorParaAtualizar,ModelState);
            if (!TryValidateModel(tutorParaAtualizar))
                return ValidationProblem(ModelState);

            _tutorServico.Update(_mapper.Map(tutorParaAtualizar, tutor));
            return CreatedAtAction(nameof(RecuperaTutorPorId), new { id = tutor.Id, tutor });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTutor(int id)
        {
            var tutor = _tutorServico.GetById(id);
            if (tutor == null) return NotFound();
            _tutorServico.Delete(tutor);
            return NoContent();
        }
        [Route("Email")]
        public IActionResult RecuperaTutorPorEmail(String email)
        {
            var tutor = _tutorServico.GetByEmail(email);
            if (tutor == null) return NotFound();
            return Ok(tutor);
        }
    }
}
