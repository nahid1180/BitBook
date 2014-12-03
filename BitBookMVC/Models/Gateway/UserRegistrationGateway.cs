using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BitBookMVC.Models.Gateway
{
    public class UserRegistrationGateway
    {
        private SqlConnection aConnection;

        public UserRegistrationGateway()
        {
            aConnection = new SqlConnection();
            string connectionString = ConfigurationManager.ConnectionStrings["bitbookDBConnectionString"].ConnectionString;
            aConnection.ConnectionString = connectionString;
        }
        public bool Save(UserProfile aProfile)
        {
            aConnection.Open();
            string query = string.Format("INSERT INTO t_profile VALUES('{0}','{1}','{2}','{3}','{4}')", aProfile.FullName, aProfile.Email, aProfile.Password, aProfile.Birthday, aProfile.Gender);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (total > 0)
                return true;
            return false;
        }

    }
}