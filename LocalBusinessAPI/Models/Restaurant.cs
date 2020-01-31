using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LocalBusinessAPI.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Url { get; set; }

        public static List<Restaurant> GetRestaurants(string apiKey)
        {
            var apiCallTask = ApiHelper.ApiCall(apiKey);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            List<Restaurant> restaurantList = JsonConvert.DeserializeObject<List<Restaurant>>(jsonResponse["results"].ToString());
            return restaurantList;
        }
    }
}