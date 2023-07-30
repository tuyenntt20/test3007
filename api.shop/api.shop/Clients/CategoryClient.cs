using System;
using api.shop.Entities;
using api.shop.Interfaces.Clients;

namespace api.shop.Clients
{
    public class CategoryClient : ICategoryClient
    {
        private readonly IHttpClientBase _httpClientBase;

        private const string path = "https://my.api.mockaroo.com/category.json";
        private const string XApiKey = "a33c0d40";

        public CategoryClient(IHttpClientBase httpClientBase)
        {
            _httpClientBase = httpClientBase;

            //read config from setting env: path, x-api-key
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            var headers = new Dictionary<string, string>
            {
                { "x-api-key", XApiKey }
            };

            return await _httpClientBase.GetAsync<Category>(path, "application/json", headers);
        }
    }
}

