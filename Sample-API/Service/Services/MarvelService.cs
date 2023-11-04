using Sample_API.Infraestructure.Repository;
using Sample_API.Service.Models;

namespace Sample_API.Service.Services
{
    public class MarvelService : IMarvelService
    {
        private readonly IMarvelRepository repository;

        public MarvelService(IMarvelRepository marvel)
        {
            repository = marvel;
        }

        public async Task<List<Character>> GetCharacterByName(string name)
        {
            return await repository.GetCharacterByName(name);
        }

        public async Task<Character> GetCharacterById(string id)
        {
            return await repository.GetCharacterById(id);
        }
    }
}
