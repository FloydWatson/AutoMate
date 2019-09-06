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

    public int MyProperty { get; set; }
    private int UserID { get; set; };
    private int StartLat { get; set; };
    private int StartLong { get; set; }; 
    private int EndLat { get; set; };
    private int EndLong { get; set; };
    private DateTime StartTime { get; set; };
    private DateTime EndTime { get; set; };
    

}


}