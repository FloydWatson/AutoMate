using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Device.Location.GeoCoordinate;

//Testing commit - Jesse

namespace AutoMate.Controllers
{

public class Trip {

    public int MyProperty { get; set; }
    private int UserID { get; set; }
    private int StartLat { get; set; }
    private int StartLong { get; set; } 
    private int EndLat { get; set; }
    private int EndLong { get; set; }
    private DateTime StartTime { get; set; }
    private DateTime EndTime { get; set; }
    private Position Initial { get; set; }
    private Position Finish { get; set; }
    

}


}