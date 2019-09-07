using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


// Model for Trip

namespace AutoMate.Models
{

public class Trip {

    
    private int UserID { get; set; }
    private Double StartLat { get; set; }
    private Double StartLong { get; set; }
    private Double EndLat { get; set; }
    private Double EndLong { get; set; }
    private DateTime StartTime { get; set; }
    private DateTime EndTime { get; set; }
    

}


}