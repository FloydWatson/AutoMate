using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AutoMate.Models
{
    public class BusStop
    {
        [JsonProperty(PropertyName = "stop_id")]
        public string stop_id { get; set; }

        [JsonProperty(PropertyName = "stop_name")]
        public string stop_name { get; set; }

        [JsonProperty(PropertyName = "stop_lat")]
        public string stop_lat { get; set; }

        [JsonProperty(PropertyName = "stop_lon")]
        public string stop_lon { get; set; }

        [JsonProperty(PropertyName = "location_type")]
        public string location_type { get; set; }
    }
}