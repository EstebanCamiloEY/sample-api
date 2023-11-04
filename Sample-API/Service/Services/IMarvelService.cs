using Sample_API.Service.Models;

namespace Sample_API.Service.Services
{
    public interface IMarvelService
    {
        Task<Character> GetCharacterById(string id);
        Task<List<Character>> GetCharacterByName(string name);
    }
}
