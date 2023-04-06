using DesafioAlura.Entidades;
using DesafioAlura.Interfaces;

namespace DesafioAlura.Servicos
{
    public class TutorServico
    {
        private readonly IRepository<Tutor> _tutorRepository;

        public TutorServico(IRepository<Tutor> tutorRepository)
        {
            _tutorRepository = tutorRepository;
        }

        public void Add(Tutor tutor)
        {
            _tutorRepository.Add(tutor);
        }

        public void Update(Tutor tutor)
        {
            _tutorRepository.Update(tutor);
        }

        public void Delete(Tutor tutor)
        {
            _tutorRepository.Delete(tutor);
        }

        public IEnumerable<Tutor> GetAll()
        {
            return _tutorRepository.GetAll();
        }

        public Tutor GetById(int id)
        {
            return _tutorRepository.GetById(id);
        }
    }
}
