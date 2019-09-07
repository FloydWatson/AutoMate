using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMate.Models
{
    public class Test
    {
        [JsonProperty(PropertyName = "stop_lat")]
        public float Lat { get; set; }
        [JsonProperty(PropertyName = "stop_lon")]
        public float Lon { get; set; }
        [JsonProperty(PropertyName = "location_type")]
        public int TransportType { get; set; }
    }
}