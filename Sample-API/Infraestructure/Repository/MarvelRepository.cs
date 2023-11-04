using AutoMapper;
using Newtonsoft.Json;
using Sample_API.Infraestructure.DAO;
using Sample_API.Service.Models;

namespace Sample_API.Infraestructure.Repository
{
    public class MarvelRepository : IMarvelRepository
    {
        private readonly IMapper _mapper;
        private readonly IHttpClientFactory _httpClientFactory;

        private readonly string hash = "a73040fe2921522f6ff1edf2873d8c99";
        private readonly string uriPath = "https://gateway.marvel.com:443";
        private readonly string publicKey = "af7d16a062c5840e7558ba608cac3522";

        public MarvelRepository(IHttpClientFactory httpClientFactory, IMapper mapper)
        {
            _mapper = mapper;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<Character>> GetCharacterByName(string name)
        {
            var httpResponseMessage = await RequestHelper.GetAsync(_httpClientFactory, uriPath + $"/v1/public/characters?name={name}&&apikey={publicKey}&hash={hash}&ts={1}");

            string responseJson = await httpResponseMessage.Content.ReadAsStringAsync();

            var resultDAO = JsonConvert.DeserializeObject<CharacterDAO>(responseJson);

            var result = _mapper.Map<List<CharacterDAO.Result>, List<Character>>(resultDAO.data.results.ToList());

            return result;
        }

        public async Task<Character> GetCharacterById(string id)
        {
            var httpResponseMessage = await RequestHelper.GetAsync(_httpClientFactory, uriPath + $"/v1/public/characters/{id}?apikey={publicKey}&hash={hash}&ts={1}");

            string responseJson = await httpResponseMessage.Content.ReadAsStringAsync();

            var resultDAO = JsonConvert.DeserializeObject<CharacterDAO>(responseJson)?.data.results.First();

            var result = (resultDAO != null) ? _mapper.Map<CharacterDAO.Result, Character>(resultDAO) : null;

            return result;
        }
    }
}
