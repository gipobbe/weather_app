using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using weather_app.Core.AppHttpClient.Exceptions;

namespace weather_app.Core.AppHttpClient
{
    public class AppHttpClient : IAppHttpClient
  {
    private readonly Dictionary<string, string> _defaultHeaders;

    public AppHttpClient()
    {
      _defaultHeaders = new Dictionary<string, string>
      {
        {"Accept", "application/json"},
        {"Content-Type", "application/json"}
      };
    }
    
    public async Task<T?> Post<T>(string url, string requestBody, AppHttpClientRequestOptions? options = null)
    {
      var responseBody = await Request(HttpMethod.Post, url, requestBody, options);

      if (string.IsNullOrEmpty(responseBody))
      {
        throw new AppHttpClientEmptyResponseBodyException();
      }

      return JsonSerializer.Deserialize<T>(responseBody);
    }

    public async Task<T?> Put<T>(string url, string requestBody, AppHttpClientRequestOptions? options = null)
    {
      var responseBody = await Request(HttpMethod.Put, url, requestBody, options);
      
      if (string.IsNullOrEmpty(responseBody))
      {
        throw new AppHttpClientEmptyResponseBodyException();
      }

      return JsonSerializer.Deserialize<T>(responseBody);
    }

    public async Task<T?> Delete<T>(string url, string requestBody, AppHttpClientRequestOptions? options = null)
    {
      var responseBody = await Request(HttpMethod.Delete, url, requestBody, options);
      
      if (string.IsNullOrEmpty(responseBody))
      {
        throw new AppHttpClientEmptyResponseBodyException();
      }

      return JsonSerializer.Deserialize<T>(responseBody);
    }

    public async Task<T?> Get<T>(string url, AppHttpClientRequestOptions? options = null)
    {
      var responseBody = await Request(HttpMethod.Get, url, null, options);

      if (string.IsNullOrEmpty(responseBody))
      {
        throw new AppHttpClientEmptyResponseBodyException();
      }

      return JsonSerializer.Deserialize<T>(responseBody);
    }
    
    public async Task<string?> Request(HttpMethod method, string url, string? requestBody, AppHttpClientRequestOptions? options = null)
    {
      var req = new FlurlRequest(new Url(url)).WithHeaders(_defaultHeaders);

      if (options?.Headers != null)
      {
        foreach (var (key, value) in options.Headers)
        {
          req = req.WithHeader(key, value);
        }
      }

      try
      {
        var responseBody = await req.SendJsonAsync(method, requestBody).ReceiveString();
        return responseBody;
      }
      catch (FlurlHttpTimeoutException exception)
      {
        var errorMessage = exception.Message;

        throw new AppHttpClientRequestException(errorMessage);
      }
      catch (FlurlHttpException exception)
      {
        var statusCode = exception.StatusCode;
        var errorMessage = exception.Message;

        if (statusCode.HasValue)
        {
          throw new AppHttpClientResponseException(statusCode.Value, errorMessage);
        }
        throw;
      }
    }
    
  }
}