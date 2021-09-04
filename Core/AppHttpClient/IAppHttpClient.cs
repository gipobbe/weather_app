using System.Threading.Tasks;

namespace weather_app.Core.AppHttpClient
{
    public interface IAppHttpClient
    {
        public Task<T?> Get<T>(string url, AppHttpClientRequestOptions? options = null);

        public Task<T?> Post<T>(string url, string requestBody, AppHttpClientRequestOptions? options = null);

        public Task<T?> Put<T>(string url, string requestBody, AppHttpClientRequestOptions? options = null);

        public Task<T?> Delete<T>(string url, string requestBody, AppHttpClientRequestOptions? options = null);
    }
}