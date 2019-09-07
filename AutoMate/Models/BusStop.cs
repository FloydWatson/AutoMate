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
    }
}