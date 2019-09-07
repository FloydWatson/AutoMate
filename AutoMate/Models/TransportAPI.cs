using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;

namespace AutoMate.Models
{
    public class TransportAPI
    {
        public string PrimaryKey { get; set; }
        public string SecondaryKey { get; set; }
        public BusStopAPI MyBusStopAPI { get; }
        private HttpClient Client;

        public TransportAPI(string primaryKey = "a546a8c00a9d40378f95b13c288f6aa6", string secondaryKey = "88e79404950d4e95b6a41be6402bef9b")
        {
            this.PrimaryKey = primaryKey;
            this.SecondaryKey = secondaryKey;
            this.MyBusStopAPI = new BusStopAPI(this.PrimaryKey, this.SecondaryKey);
        }
    }
}