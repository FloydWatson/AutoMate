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
        private string APIURL;

        public BusStopAPI(string primaryKey, string secondaryKey)
        {
            this.PrimaryKey = primaryKey;
            this.SecondaryKey = secondaryKey;
            this.Client = new HttpClient();

            Client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", PrimaryKey);

            APIURL = "https://api.at.govt.nz/v2/gtfs/stops/stopId/0097-20190819140255_v83.2?";
        }

        // Query string format eg: "stop_name=Papakura Train Station"
        public async Task<List<BusStop>> queryBusStopsAsync(string query, string callback = "")
        {
            
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Check if user submitted query string
            if (!string.IsNullOrEmpty(query))
            {
                queryString = HttpUtility.ParseQueryString(query);
            }

            // Request headers
            var httpclient = new HttpClient();

            httpclient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "a546a8c00a9d40378f95b13c288f6aa6");

            // Request parameters
            queryString["callback"] = callback;
            var uri = APIURL + queryString;

            var response = Task.Run(async () => { return await httpclient.GetAsync(uri); }).Result;
            response.EnsureSuccessStatusCode();
            // Deserialize and put into array of BusStop classes
            var serializer = new JavaScriptSerializer();
            var json = Task.Run(async () => { return await response.Content.ReadAsStringAsync(); }).Result;
            
            if (!string.IsNullOrEmpty(json))
            {
                var result = JObject.Parse(json);   //parses entire stream into JObject, from which you can use to query the bits you need.
                var items = result["response"].Children().ToList();   //Get the sections you need and save as enumerable (will be in the form of JTokens)

                List<BusStop> busstopList = new List<BusStop>();  //init new list to store the objects.

                //iterate through the list and match to an object. If Property names don't match -- you could also map the properties individually. Also useful if you need to dig out nested properties.
                foreach (var subItem in items)
                {
                    BusStop busstop = subItem.ToObject<BusStop>();
                    busstopList.Add(busstop);
                }
                // JsonResponse FullJsonResponse = serializer.Deserialize<JsonResponse>(json);


                return busstopList;
            }

            return null;
            
        }
        
    }
}
