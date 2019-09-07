using AutoMate.Models;
using AutoMate.DBFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AutoMate.DBFunctions
{
    public static class UserProcessor
    {
       public static int CreateUser(UserModel user)
        {
            
            if (user.DriverVerification)
            {
                user.Verification = 1;
            } else
            {
                user.Verification = 0;
            }

            string sql = sql = @"insert into dbo.Employee (user_id, given_name, family_name, mobile_number, email_address, driver_verification, userUserName, rating)
                            values (@user.UserID, @user.GivenName, @user.FamilyName, @user.MobileNumber, @user.EmailAddress, @verification, @user.UserName, @user.Rating);";
            return SqlDataAccess.SaveData(sql, user);
        }
    }
        
        
}