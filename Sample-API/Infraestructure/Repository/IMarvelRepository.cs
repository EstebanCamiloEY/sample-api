using Sample_API.Service.Models;

namespace Sample_API.Infraestructure.Repository
{
    public interface IMarvelRepository
    {
        Task<Character> GetCharacterById(string id);
        Task<List<Character>> GetCharacterByName(string name);
    }
}
