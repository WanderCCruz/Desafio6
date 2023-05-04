using AdoPet.Repository;
using DesafioAlura.Entidades;
using DesafioAlura.Migrations;

namespace DesafioAlura.Servicos
{
    public class PetServico
    {
        private readonly IRepositoryBase<Pet> _petRepository;

        public PetServico(IRepositoryBase<Pet> petRepository)
        {
            _petRepository = petRepository;
        }

        public void Add(Pet pet)
        {
            _petRepository.Add(pet);
        }

        public void Update(Pet pet)
        {
            _petRepository.Update(pet);
        }

        public void Delete(Pet pet)
        {
            _petRepository.Delete(pet);
        }

        public IEnumerable<Pet> GetAll()
        {
            return _petRepository.GetAll();
        }

        public Pet GetById(int id)
        {
            return _petRepository.GetById(id);
        }
        public Pet GetById(Guid id)
        {
            return _petRepository.GetById(id);
        }
    }
}
