using System;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace DataManipulation
{
    public static class DataLink
    {
        public static async Task<string> MakeRequest()
        {
            //Hard coded search values for demo
            var client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);


            queryString["callback"] = "data";

            // Request headers
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "1b38bc2646024c8fa286a0e42c934186");

            var uri = "https://api.at.govt.nz/v2/gtfs/stops?/geosearch?lat=-36.84&lng=174.76&distance=100&" + queryString;

            var response = await client.GetAsync(uri);


            return response.Content.ReadAsStringAsync().Result;

            //var final = JObject.Parse(json);

            //return final;
        }
    }
}	