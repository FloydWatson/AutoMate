//using AutoMate.Models;
//using AutoMate.DBFunctions;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;


//namespace AutoMate.DBFunctions
//{
//    public static class UserProcessor
//    {
//       public static int CreateUser(UserModel user)//int UserID,string GivenName, string FamilyName, string MobileNumber, string EmailAddress, string Verification, string UserName, string Rating)
//        {

//            user.Verification = 1;
        


//            string sql = sql = @"insert into dbo.user_profile (user_id, given_name, family_name, mobile_number, email_address, driver_verification, user_Name, rating)
//                            values (@UserID, @GivenName, @FamilyName, @MobileNumber, @EmailAddress, @Verification, @Username, @Rating);";
//            return SqlDataAccess.SaveData(sql, user);
//        }

//        public static UserModel LoadUser(string userName)
//        {
//            UserModel data = new UserModel();
//            data.Username = userName;

//            string sql = @"SELECT user_id, given_name, family_name, mobile_number, email_address, driver_verification, user_name, rating from dbo.user_profile
//                    WHERE user_id = 2";

//            List<UserModel> userList = SqlDataAccess.LoadData<UserModel>(sql);
//            foreach (var user in userList)
//            {
//                if (user.Username != null)
//                {
//                    UserModel test = new UserModel();
//                    test.GivenName = user.GivenName;
//                    return test;
//                }

//            }

//            return null;
//        }


//    }
//    //1,'test','test','test','test',1,'test',1
//    //select user_id, given_name, family_name, mobile_number, email_address, driver_verification, user_Name, rating
//    //from dbo.user_profile WHERE user_name = @UserName;
//}