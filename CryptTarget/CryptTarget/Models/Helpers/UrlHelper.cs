using Newtonsoft.Json.Linq;
using System.Net;

namespace CryptTarget.Models.Helpers
{
    public abstract class UrlHelper
    {
        private protected static string ApiKey { get; set; } = "21c47b68-1808-4b90-adab-e9780b7c83e0";
        private protected static string Url { get; set; } = "https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest?";
        public async static Task<JObject> makeAPICall()
        { 
            var request = new HttpRequestMessage(HttpMethod.Get, Url);
            request.Headers.Add("X-CMC_PRO_API_KEY", ApiKey);
            request.Headers.Add("Accepts", "application/json");
            var response = await new HttpClient().SendAsync(request);
             
            JObject obj = JObject.Parse(await response.Content.ReadAsStringAsync());
            return obj;
        }
    }
}
