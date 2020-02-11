using AutoMapper;
using TesteAutoMapper.Domain;

namespace TesteAutoMapper.Application
{
    public class ExemploMapProfile : Profile
    {
        public ExemploMapProfile()
        {
            CreateMap<ExemploDto, Exemplo>()
            .ReverseMap();
        }
     }
 }