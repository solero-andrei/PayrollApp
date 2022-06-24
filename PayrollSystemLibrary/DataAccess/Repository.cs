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
            string query = "";

            if (role == Roles.Admin)
            {
                query = $"select PayrollUser.*, PayrollUserAccount.Username, PayrollUserAccount.Password from PayrollUser inner join PayrollUserAccount on PayrollUser.AdminID = PayrollUserAccount.AdminID where PayrollUserAccount.Username = @UserName and PayrollUserAccount.Password = @Password";
            }
            if (role == Roles.Client)
            {
                query = $"select Employee.*, EmployeeDashboardAccount.Username, EmployeeDashboardAccount.Password from Employee inner join EmployeeDashboardAccount on Employee.AdminID = EmployeeDashboardAccount.AdminID where EmployeeDashboardAccount.Username = @UserName and EmployeeDashboardAccount.Password = @Password";
            }

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (role == Roles.Admin)
                    {
                        user = new PayrollUser
                        {
                            
                            ID = int.Parse(reader[0].ToString()),
                            FirstName = reader[1].ToString(),
                            MiddleName = reader[2].ToString(),
                            LastName = reader[3].ToString(),
                            ContactNumber = reader[4].ToString(),
                            EmailAddress = reader[5].ToString(),
                            Username = reader[7].ToString(),
                            Password = reader[8].ToString()
                        };
                    }
                    if (role == Roles.Client)
                    {

                    }
                }

            }
            
            return user;
        }
    }
}
