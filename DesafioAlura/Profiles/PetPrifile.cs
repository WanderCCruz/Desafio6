using AutoMapper;
using DesafioAlura.DTOs.Pet;
using DesafioAlura.DTOs.Tutor;
using DesafioAlura.DTOs.Usuario;
using DesafioAlura.Entidades;

namespace DesafioAlura.Profiles
{
    public class PetPrifile :Profile
    {
        public PetPrifile()
        {
            CreateMap<CreatePetDTO, Pet>();
            CreateMap<UpdatePetDTO, Pet>();
        }
    }
}
