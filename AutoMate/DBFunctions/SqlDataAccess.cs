using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using System.Web;

namespace AutoMate.DBFunctions
{
    public static class SqlDataAccess
    {
        public static string GetConnectionString(string connectionName = "AutoMateDB")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadData<T>(string sql) // t is the model of the data
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                
                return cnn.Query<T>(sql).ToList(); // actually IEnum origianlly
            }
        }

        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }
    }
}