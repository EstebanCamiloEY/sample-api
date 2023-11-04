using Microsoft.AspNetCore.Mvc;
using Sample_API.Service.Models;
using Sample_API.Service.Services;

namespace Sample_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarvelController : ControllerBase
    {
        private readonly IMarvelService _marvel;


        public MarvelController(IMarvelService marvel)
        {
            _marvel = marvel;
        }

        [HttpGet("characterByName/{name}")]
        public async Task<List<Character>> GetByNameAsync(string name)
        {
            if (name is null) throw new ArgumentNullException(nameof(name));

            return await _marvel.GetCharacterByName(name);
        }

        [HttpGet("characterById/{id}")]
        public async Task<Character> GetByIdAsync(string id)
        {
            if (id is null) throw new ArgumentNullException(nameof(id));

            return await _marvel.GetCharacterById(id);
        }
    }
} 