using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PayrollSystemLibrary.Models;

namespace PayrollSystemLibrary.DataAccess
{
    public class JobRepository
    {
        public List<JobPositions> GetJobs()
        {
            List<JobPositions> jobs = new List<JobPositions>();

            using (SqlConnection connection = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand("select * from [JobPositions]", connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    jobs.Add(new JobPositions
                    {
                        JobID = int.Parse(reader[0].ToString()),
                        JobName = reader[1].ToString(),
                        MonthlySalary = decimal.Parse(reader[2].ToString()),
                        SalaryPerHour = decimal.Parse(reader[3].ToString())
                    });
                }
            }

            return jobs;
        }

        public JobPositions Filter(string jobName)
        {
            string query = "select * from JobPositions where [JobName] = @JobName";
            JobPositions job = new JobPositions();

            using (SqlConnection connection = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                //query = "";
                command.Parameters.AddWithValue("@JobName", jobName);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    job = new JobPositions
                    {
                        JobID = int.Parse(reader[0].ToString()),
                        JobName = reader[1].ToString(),
                        MonthlySalary = decimal.Parse(reader[2].ToString()),
                        SalaryPerHour = decimal.Parse(reader[3].ToString())
                    };
                }
            }

            return job;
        }

    }
}
