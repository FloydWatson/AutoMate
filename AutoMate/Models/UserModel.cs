using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoMate.Models
{
    public class UserModel
    {
        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public string MobileNumber { get; set; }

        public string EmailAddress { get; set; }

        public int UserID { get; set; }

        public bool DriverVerification { get; set; }

        public string UserName { get; set; }

        public double Rating { get; set; }

    }
}