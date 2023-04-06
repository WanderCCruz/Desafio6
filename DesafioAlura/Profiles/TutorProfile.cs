using AutoMapper;
using DesafioAlura.DTOs.Tutor;
using DesafioAlura.Entidades;

namespace DesafioAlura.Profiles
{
    public class TutorProfile : Profile
    {
        public TutorProfile()
        {
            CreateMap<CreateTutorDtO, Tutor>();
            CreateMap<UpdateTutorDtO, Tutor>();
            CreateMap<Tutor, UpdateTutorDtO>();
        }
    }
}
