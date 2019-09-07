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
       public static int CreateUser(UserModel user)//int UserID,string GivenName, string FamilyName, string MobileNumber, string EmailAddress, string Verification, string UserName, string Rating)
        {

            user.Verification = 1;
        


            string sql = sql = @"insert into dbo.user_profile (user_id, given_name, family_name, mobile_number, email_address, driver_verification, user_Name, rating)
                            values (@UserID, @GivenName, @FamilyName, @MobileNumber, @EmailAddress, @Verification, @UserName, @Rating);";
            return SqlDataAccess.SaveData(sql, user);
        }

        public static UserModel LoadUser(string userName)
        {
            string sql = @"select user_id, given_name, family_name, mobile_number, email_address, driver_verification, user_Name, rating
                            from dbo.user_profile WHERE user_name = @userName;";

            return SqlDataAccess.LoadData<UserModel>(sql);
        }


    }
    //1,'test','test','test','test',1,'test',1
    //
}