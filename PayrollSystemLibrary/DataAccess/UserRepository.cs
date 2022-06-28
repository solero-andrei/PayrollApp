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
    public class UserRepository : IUserRepository
    {     
        public IUser GetUserDataByAccount(Roles role, string username, string password)
        {
            IUser user = null;
            string query = "";

            if (role == Roles.Admin)
            {
                query = $"select payrolluser.*, payrolluseraccount.username, payrolluseraccount.password from payrolluser inner join payrolluseraccount on payrolluser.adminid = payrolluseraccount.adminid where payrolluseraccount.username = @username and payrolluseraccount.password = @password";
            }
            if (role == Roles.Client)
            {
                query = "";
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
                            ID = int.Parse(reader["AdminID"].ToString()),
                            FirstName = reader["FirstName"].ToString(),
                            MiddleName = reader["MiddleName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            ContactNumber = reader["ContactNumber"].ToString(),
                            EmailAddress = reader["EmailAddress"].ToString(),
                            Username = reader["UserName"].ToString(),
                            Password = reader["Password"].ToString(),
                            
                        };
                    }
                }
            }
            
            return user;
        }

        public void AddUser(Roles role, IUser userInfo)
        {
            string query = "";
            if (role == Roles.Client)
            {
                query = "insert into Employee([EmployeeID], [FirstName], [MiddleName], [LastName], [Gender], [EmailAddress], [ContactNumber], [HomeAddress], [DateOfBirth], [DateOfApply])values(@EmployeeID, @FirstName, @MiddleName, @LastName, @Gender, @EmailAddress, @ContactNumber, @HomeAddress, @DateOfBirth, @DateOfApply);" +
                    "insert into EmployeeDashboardAccount([EmployeeID], [Username], [AccountPassword])values(@EmployeeID, @Username, @Password);" +
                    "insert into EmployeeJobInfo([EmployeeID], [JobID])values(@EmployeeID, @JobID)";
            }

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                cn.Open();
                if (userInfo is Employee)
                {
                    Employee emp = (Employee) userInfo;

                    command.Parameters.AddWithValue("@EmployeeID", emp.ID);
                    command.Parameters.AddWithValue("@FirstName", emp.FirstName);
                    command.Parameters.AddWithValue("@MiddleName", emp.MiddleName);
                    command.Parameters.AddWithValue("@LastName", emp.LastName);
                    command.Parameters.AddWithValue("@Gender", emp.Gender);
                    command.Parameters.AddWithValue("@EmailAddress", emp.EmailAddress);
                    command.Parameters.AddWithValue("@ContactNumber", emp.ContactNumber);
                    command.Parameters.AddWithValue("@HomeAddress", emp.HomeAddress);
                    command.Parameters.AddWithValue("@DateOfBirth", emp.DateOfBirth);
                    command.Parameters.AddWithValue("@DateOfApply", emp.DateOfApply);
                    command.Parameters.AddWithValue("@Username", emp.Username);
                    command.Parameters.AddWithValue("@Password", emp.Password);
                    command.Parameters.AddWithValue("@JobID", emp.Job.JobID);

                    @command.ExecuteNonQuery();
                }
            }
        }
    }
}
