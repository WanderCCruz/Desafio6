using AutoMapper;
using DesafioAlura.DTOs.Abrigo;
using DesafioAlura.Entidades;

namespace DesafioAlura.Profiles
{
    public class AbrigoProfile : Profile
    {
        public AbrigoProfile()
        {
            CreateMap<CreateAbrigoDTO, Abrigo>()
               .ForMember(Dto => Dto.Endereco,
                   opt => opt.MapFrom(abg => abg.Endereco));
            CreateMap<UpdateAbrigoDTO, Abrigo>()
               .ForMember(Dto => Dto.Endereco,
                   opt => opt.MapFrom(abg => abg.Endereco));
        }
    }
}
