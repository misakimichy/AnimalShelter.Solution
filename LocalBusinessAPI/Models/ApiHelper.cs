using System.Threading.Tasks;
using RestSharp;

namespace LocalBusinessAPI.Models
{
    class ApiHelper
    {
        public static async Task<string> ApiCall(string apiKey)
        {
            //hard coding city Id from Zomato API
            int cityId = 279;
            string city = "Seattle";
            RestClient client = new RestClient($"https://developers.zomato.com/api/v2.1/search?entity_id={cityId}}&entity_type={city}");
            RestRequest request = new RestRequest($"home.json?api-key={apiKey}", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }
    }
}