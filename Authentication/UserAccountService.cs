using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using SimpleAuthenticationApp.Data;

namespace SimpleAuthenticationApp.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        private string connectionString = "";

        public UserAccountService GetUsers()
        {
            connectionString = @"Data Source=localhost; Integrated Security=true; initial catalog=SimpleAuthenticationApp; user id=LibCommResourcesUser; password=Government1;";


            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = @"SELECT * FROM dbo.Users";
                dbConnection.Open();

                var AllUsers = dbConnection.Query<UserAccount>(sQuery);
                _users = AllUsers.ToList();

            }
            return null;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }



        public UserAccount? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}
