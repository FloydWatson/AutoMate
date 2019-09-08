using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMate.Models
{
    public class Location
    {
        public float lat { get; set; }
        public float lon { get; set; }

        public Location(float lat, float lon)
        {
            this.lat = lat;
            this.lon = lon;
        }
    }
}