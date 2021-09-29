using System.Collections.Generic;
using System.Threading.Tasks;
using AP.Core.Domain;
using AP.Core.Shared.ModelViews;
using AP.Manager.Interfaces;
using AutoMapper;

namespace AP.Manager.Implementation
{
    public class PokemonManager : IPokemonManager
    {
        private readonly IPokemonRepository pokemonRepository;
        private readonly IMapper mapper;

        public PokemonManager(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            this.pokemonRepository = pokemonRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<Pokemon>> GetPokemonsAsync()
        {
            return await pokemonRepository.GetPokemonsAsync();
        }

        public async Task<Pokemon> GetPokemonAsync(int id)
        {
            return await pokemonRepository.GetPokemonAsync(id);
        }

        public async Task<Pokemon> InsertPokemonAsync(NovoPokemon novoPokemon)
        {
            var pokemon = mapper.Map<Pokemon>(novoPokemon);
            return await pokemonRepository.InsertPokemonAsync(pokemon);
        }

        public async Task<Pokemon> UpdatePokemonAsync(Pokemon pokemon)
        {
            return await pokemonRepository.UpdatePokemonAsync(pokemon);
        }

        public async Task DeletePokemonAsync(int id)
        {
            await pokemonRepository.DeletePokemonAsync(id);
        }
    }
}