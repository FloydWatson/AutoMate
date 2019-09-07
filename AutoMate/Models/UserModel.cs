using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoMate.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "You need to provide a given name")]
        [Display(Name = "Given Name")]
        public string GivenName { get; set; }

        [Required(ErrorMessage = "You need to provide a family name")]
        [Display(Name = "Family Name")]
        public string FamilyName { get; set; }

        [Required(ErrorMessage = "You need to provide a mobile number")]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You need to provide an email address")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [DataType(DataType.EmailAddress)]
        [Compare("EmailAddress", ErrorMessage = "The emails must match")]
        [Display(Name = "Confirm Email Address")]
        public string ConfirmEmailAddress { get; set; }

        [Required(ErrorMessage = "You need to provide a User ID")]
        [Display(Name = "User ID")]
        public int UserID { get; set; }

        public bool DriverVerification { get; set; } = true;

        [Required(ErrorMessage = "You need to provide a username")]
        public string Username { get; set; }

        public float Rating { get; set; }

        public int Verification { get; set; }

    }
}