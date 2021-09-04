using System;

namespace weather_app.Core.AppHttpClient.Exceptions
{
    public class AppHttpClientEmptyResponseBodyException: Exception
    {
        public AppHttpClientEmptyResponseBodyException()
        {
        }
    }
}