using System;
using AP.Core.Domain;
using AP.Core.Shared.ModelViews;
using AutoMapper;

namespace AP.Manager.Mappings
{
    public class AlteraPokemonMappingProfile : Profile
    {
        public AlteraPokemonMappingProfile()
        {
            CreateMap<AlteraPokemon, Pokemon>()
                .ForMember(d => d.DataAtualizacao, o => o.MapFrom(x => DateTime.Now));
        }
    }
}