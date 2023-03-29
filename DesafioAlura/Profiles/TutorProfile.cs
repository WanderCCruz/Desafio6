using AutoMapper;
using DesafioAlura.DTos;
using DesafioAlura.Entidades;

namespace DesafioAlura.Profiles
{
    public class TutorProfile : Profile
    {
        public TutorProfile()
        {
            CreateMap<CreateTutorDto, Tutor>();
            CreateMap<UpdateTutorDto, Tutor>();
            CreateMap<Tutor, UpdateTutorDto>();
        }
    }
}
