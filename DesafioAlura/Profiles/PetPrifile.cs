using AutoMapper;
using DesafioAlura.DTOs.Pet;
using DesafioAlura.DTOs.Tutor;
using DesafioAlura.Entidades;

namespace DesafioAlura.Profiles
{
    public class PetPrifile :Profile
    {
        public PetPrifile()
        {
            CreateMap<CreatePetDTO, Pet>();
        }
    }
}
