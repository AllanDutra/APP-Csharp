using System.Collections.Generic;
using System.Threading.Tasks;
using AP.Core.Domain;
using AP.Core.Shared.ModelViews;

namespace AP.Manager.Interfaces
{
    public interface IPokemonManager
    {
         Task<Pokemon> GetPokemonAsync(int id);
         Task<IEnumerable<Pokemon>> GetPokemonsAsync();

         Task<Pokemon> InsertPokemonAsync(NovoPokemon pokemon);
         Task<Pokemon> UpdatePokemonAsync(Pokemon pokemon);
         Task DeletePokemonAsync(int id);
    }
}