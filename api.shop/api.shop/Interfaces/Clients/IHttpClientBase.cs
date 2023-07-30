namespace api.shop.Interfaces.Clients
{
    public interface IHttpClientBase
    {
        Task<IEnumerable<T>> GetAsync<T>(string path, string contentType, Dictionary<string, string> headerInfos);
    }
}

