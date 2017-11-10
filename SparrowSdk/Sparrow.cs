using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SparrowSdk
{
    /// <summary>
    /// Docs at: http://foresight.sparrowone.com/
    /// </summary>
    public partial class Sparrow
    {
        private const string _url = "https://secure.sparrowone.com/Payments/Services_api.aspx";

        private HttpClient _client;
        private string _apiKey;

        public Sparrow(string apiKey, HttpClient client = null)
        {
            _apiKey = apiKey;
            _client = client ?? new HttpClient();
        }

        private async Task<Dictionary<string, string>> MakeRequest(Dictionary<string, string> data)
        {
            var content = new FormUrlEncodedContent(data);
            var response = await _client.PostAsync(_url, content);
            var responseString = await response.Content.ReadAsStringAsync();
            var responseValues = ParseResponse(responseString);

            return responseValues;
        }

        private Dictionary<string, string> ParseResponse(string responseString)
        {
            var parts = responseString.Split('&');
            var values = parts.Select(p =>
            {
                var keyValue = p.Split('=');
                var key = keyValue[0];
                var value = keyValue[1];
                return new
                {
                    key,
                    value
                };
            }).ToDictionary(x => x.key, x => x.value);

            return values;
        }
    }
}
