using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Device.Location.GeoCoordinate;

// Model for Trip

namespace AutoMate.Models
{

    public class Trip
    {


        private int UserID { get; set; }
        private Double StartLat { get; set; }
        private Double StartLong { get; set; }
        private Double EndLat { get; set; }
        private Double EndLong { get; set; }
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }
        private Position Initial { get; set; }
        private Position Final { get; set; }

    }
}