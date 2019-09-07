using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Script.Serialization;

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

            Client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", PrimaryKey);

            APIURL = "https://api.at.govt.nz/v2/gtfs/stops?";
        }

        // Query string format eg: "stop_name=Papakura Train Station"
        public async System.Threading.Tasks.Task<BusStops> queryBusStopsAsync(string query, string callback = "")
        {
            
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            // Check if user submitted query string
            if (!string.IsNullOrEmpty(query))
            {
                queryString = HttpUtility.ParseQueryString(query);
            }

            // Request headers
            

            // Request parameters
            queryString["callback"] = callback;
            var uri = APIURL + queryString;

            var response = await Client.GetAsync(uri);

            // Deserialize and put into array of BusStop classes
            var serializer = new JavaScriptSerializer();
            BusStops BusStopList = serializer.Deserialize<BusStops>(response.Content.ReadAsStringAsync().Result);



            return BusStopList;
        }
        
    }
}
