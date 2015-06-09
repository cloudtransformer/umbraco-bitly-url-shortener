using System;
using System.Net;
using System.Web.Helpers;

namespace AgeBase.BitlyUrlShortener.Helpers
{
    public static class BitlyUrlShortenerHelper
    {
        private const string c_BitlyApiUrl = "http://api.bitly.com/v3/shorten?callback=&format=json&apiKey={0}&login={1}&longUrl={2}";

        public static string ShortenUrl(string longUrl, string apiKey, string login)
        {
            if (string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(login))
                throw new ArgumentException("Missing api key and login parameters");

            if (string.IsNullOrWhiteSpace(longUrl))
                return string.Empty;

            using (var client = new WebClient())
            {
                var response = client.DownloadString(string.Format(c_BitlyApiUrl, apiKey, login, longUrl));

                if (string.IsNullOrWhiteSpace(response))
                    return string.Empty;

                dynamic responseObj = Json.Decode(response);

                return responseObj.data.Url ?? string.Empty;
            }
        }
    }
}