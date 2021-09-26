using System.Collections.Generic;
using System.Threading.Tasks;
using AP.Core.Domain;
using AP.Manager.Interfaces;

namespace AP.Manager.Implementation
{
    public class PokemonManager : IPokemonManager
    {
        private readonly IPokemonRepository pokemonRepository;

        public PokemonManager(IPokemonRepository pokemonRepository)
        {
            this.pokemonRepository = pokemonRepository;
        }

        public async Task<IEnumerable<Pokemon>> GetPokemonsAsync()
        {
            return await pokemonRepository.GetPokemonsAsync();
        }

        public async Task<Pokemon> GetPokemonAsync(int id)
        {
            return await pokemonRepository.GetPokemonAsync(id);
        }

        public async Task<Pokemon> InsertPokemonAsync(Pokemon pokemon)
        {
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