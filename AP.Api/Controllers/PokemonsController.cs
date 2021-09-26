using System.Threading.Tasks;
using AP.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AP.Api.Controllers
{
    public class PokemonsController : ControllerBase
    {
        private readonly IPokemonManager pokemonManager;

        public PokemonsController(IPokemonManager pokemonManager)
        {
            this.pokemonManager = pokemonManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await pokemonManager.GetPokemonsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await pokemonManager.GetPokemonAsync(id));
        }
    }
}