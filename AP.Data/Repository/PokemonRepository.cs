using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AP.Core.Domain;
using AP.Data.Context;
using AP.Manager.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AP.Data.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly APContext context;

        public PokemonRepository(APContext context)
        {
            this.context = context;
        }

        // Get All
        public async Task<IEnumerable<Pokemon>> GetPokemonsAsync()
        {
            return await context.Pokemons.AsNoTracking().ToListAsync();
        } 

        // Get By ID
        public async Task<Pokemon> GetPokemonAsync(int id)
        {
            return await context.Pokemons.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
            // FindAsync -> sem o AsNoTracking mas ainda com melhor performance
        }
    }
}