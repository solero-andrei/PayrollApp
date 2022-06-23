using PayrollSystemLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PayrollSystemLibrary.Models;

namespace PayrollSystemLibrary.DataAccess
{
    public class Repository : IRepository
    {
        public Repository()
        {

        }
        
        private string username = "";
        private string password = "";
        public Repository(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public IUser GetUserDataByAccount(Roles role)
        {
            IUser user = null;
            string tableRole = (role == Roles.Admin) ? "PayrollUserAccount" : "EmployeeDashboardAccount";

            using (SqlConnection connection = new SqlConnection(ConnectionString.CnnString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.Text;
                    command.Connection = connection;
                    command.CommandText = $"select * from {tableRole} where " +
                        $"[Username] = @Username AND [Password] = @Password";
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        user = new PayrollUser();
                        user.FirstName = reader["AdminID"].ToString();
                    }
                }
            }

            return user;
        }
    }
}
