using System.Net.Http.Headers;
using api.shop.Interfaces.Clients;

namespace api.shop.Clients
{
    public class HttpClientBase : IHttpClientBase
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly HttpClient _client;

        public HttpClientBase(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _client = _httpClientFactory.CreateClient();
        }

        public async Task<IEnumerable<T>> GetAsync<T>(string path, string contentType, Dictionary<string, string> headerInfos)
        {
            GenerateHeaders(contentType, headerInfos);

            var response = await _client.GetAsync(path);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<IEnumerable<T>>();

                return result ?? Enumerable.Empty<T>();
            }
            else
            {
                //handle error client (400/500...)
                throw new Exception();
            }
        }

        private void GenerateHeaders(string contentType, Dictionary<string, string> headerInfos)
        {
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType));

            foreach (var item in headerInfos)
            {
                _client.DefaultRequestHeaders.Add(item.Key, item.Value);
            }
        }
    }
}

