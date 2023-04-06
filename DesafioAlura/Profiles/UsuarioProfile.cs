using AutoMapper;
using DesafioAlura.DTOs.Tutor;
using DesafioAlura.DTOs.Usuario;
using DesafioAlura.Entidades;

namespace DesafioAlura.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDTO, Usuario>();
            CreateMap<UpdateUsuarioDTO, Usuario>();
            //CreateMap<Tutor, UpdateTutorDtO>();
        }
    }
}
