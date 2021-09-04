using System;

namespace weather_app.Core.AppHttpClient.Exceptions
{
    public class AppHttpClientRequestException : Exception
    {
        public AppHttpClientRequestException(string message) : base(message)
        {
        }
    }
}