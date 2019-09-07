using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace AutoMate.Models
{
    public class BusStopAPI
    {
        public string PrimaryKey { get; set; }
        public string SecondaryKey { get; set; }
        private HttpClient Client;

        public BusStopAPI(string primaryKey, string secondaryKey)
        {
            this.PrimaryKey = primaryKey;
            this.SecondaryKey = secondaryKey;
            this.Client = new HttpClient();
            Client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", PrimaryKey);
        }

        // Call with optional lat, lng, and distance parameters
        public async Task<List<BusStop>> getBusStopByDistanceAsync(string lat = "-36.84", string lng = "174.76", string distance = "1000")
        {
            var callback = "";
            var searchByDistanceURL = $"https://api.at.govt.nz/v2/gtfs/stops/geosearch?lat=" + lat + "&lng=" + lng + "&distance=" + distance + "&fbclid=IwAR1zPIVdK634-I4CuvzxT51FE9ZhDvR25PDm0HbvB5eOCAJr8wjBemQHj5M";
            var queryString = HttpUtility.ParseQueryString(string.Empty);
        
            // Request parameters
            queryString["callback"] = callback;
            var uri = searchByDistanceURL + queryString;

            var response = Task.Run(async () => { return await Client.GetAsync(uri); }).Result;
            response.EnsureSuccessStatusCode();

            // Deserialize and put into array of BusStop classes
            var serializer = new JavaScriptSerializer();
            var json = Task.Run(async () => { return await response.Content.ReadAsStringAsync(); }).Result;
            
            // Check if no entries found with query
            if (!string.IsNullOrEmpty(json))
            {
                // Put status, response, and error into object to pull out individual response objects (eg: list of bus stops)
                var responseObject = JObject.Parse(json);
                var responseItemList = responseObject["response"].Children().ToList();

                // Create bus stop list
                List<BusStop> busStopList = new List<BusStop>();  //init new list to store the objects.

                // Iterate through response item list and put into a bus stop list
                foreach (var items in responseItemList)
                {
                    BusStop busStop = items.ToObject<BusStop>();
                    busStopList.Add(busStop);
                }

                // Return list of bus stop objects that matched query
                return busStopList;
            }

            return null;
         }
    }
}