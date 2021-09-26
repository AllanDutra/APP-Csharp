using System.Collections.Generic;
using System.Threading.Tasks;
using AP.Core.Domain;

namespace AP.Manager.Interfaces
{
    public interface IPokemonRepository
    {
         Task<Pokemon> GetPokemonAsync(int id);
         Task<IEnumerable<Pokemon>> GetPokemonsAsync();
    }
}