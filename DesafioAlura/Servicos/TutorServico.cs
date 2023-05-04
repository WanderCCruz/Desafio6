using AdoPet.Repository;
using DesafioAlura.Entidades;

namespace DesafioAlura.Servicos
{
    public class TutorServico
    {
        private readonly IRepositoryBase<Tutor> _tutorRepository;

        public TutorServico(IRepositoryBase<Tutor> tutorRepository)
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

        public Tutor GetByEmail(string email)
        {
            return _tutorRepository.GetAll().FirstOrDefault(x => x.Email == email);
        }
    }
}
