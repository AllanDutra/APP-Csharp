using AP.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace AP.Data.Context
{
    public class APContext : DbContext
    {
        // COLEÇÃO QUE VAI SER FEITA
        public DbSet<Pokemon> Pokemons {get; set;}

        public APContext(DbContextOptions options) : base(options)
        {
        }

    }
}