using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace AutoMate.Models
{
    public class JsonResponse
    {
        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }

        [JsonProperty(PropertyName = "response")]
        public BusStop response { get; set; }

        [JsonProperty(PropertyName = "error")]
        public string error { get; set; }

    }
}