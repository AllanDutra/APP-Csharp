using System.Collections.Generic;
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

        // Post
        public async Task<Pokemon> InsertPokemonAsync(Pokemon pokemon)
        {
            await context.Pokemons.AddAsync(pokemon);
            await context.SaveChangesAsync();
            return pokemon;
        }

        // Put
        public async Task<Pokemon> UpdatePokemonAsync(Pokemon pokemon)
        {
            var pokemonConsultado = await context.Pokemons.FindAsync(pokemon.Id);
            
            if(pokemonConsultado == null)
            {
                return null;
            }

            // atualizando todos os campos com correspondência de atributo
            context.Entry(pokemonConsultado).CurrentValues.SetValues(pokemon);
            await context.SaveChangesAsync();
            return pokemonConsultado;

        }

        // Delete
        public async Task DeletePokemonAsync(int id)
        {
            var pokemonConsultado = await context.Pokemons.FindAsync(id);
            context.Pokemons.Remove(pokemonConsultado);
            await context.SaveChangesAsync();
        }

    }
}