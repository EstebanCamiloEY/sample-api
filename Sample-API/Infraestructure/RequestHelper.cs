using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;

namespace Sample_API.Infraestructure
{
    public class RequestHelper
    {
        public static async Task<HttpResponseMessage> GetAsync(IHttpClientFactory _httpClientFactory, string uri)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri)
            {
                Headers = { { HeaderNames.Accept, "application/json" } }
            };

            var httpClient = _httpClientFactory.CreateClient();

            return await httpClient.SendAsync(httpRequestMessage);
        }
    }
}
