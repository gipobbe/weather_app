using System;

namespace weather_app.Core.AppHttpClient.Exceptions
{
    public class AppHttpClientResponseException : Exception
    {
        private int StatusCode { get; init; }

        public AppHttpClientResponseException(int statusCode, string? message = null) : base(message)
        {
            StatusCode = statusCode!;
        }

        public AppHttpClientResponseException(string? message = null) : base(message)
        {
        }
    }
}