using System;
using AP.Core.Domain;
using AP.Core.Shared.ModelViews;
using AutoMapper;

namespace AP.Manager.Mappings
{
    public class NovoPokemonMappingProfile : Profile
    {
        public NovoPokemonMappingProfile()
        {
            CreateMap<NovoPokemon, Pokemon>()
                .ForMember(d => d.DataCriacao, o => o.MapFrom(x => DateTime.Now));
        }
    }
}