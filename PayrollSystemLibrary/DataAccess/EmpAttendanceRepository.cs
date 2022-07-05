using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PayrollSystemLibrary.Models;

namespace PayrollSystemLibrary.DataAccess
{
    public class EmpAttendanceRepository
    {
        public void SetAttendance(DateTime timein, int empID)
        {
            string query = "insert into [Attendance]([AttendanceID], [EmployeeID], [AttendanceDate], [AttendanceStatus], " +
                    "[Att_TimeIn], [NumberOfWorkHours], [Att_TimeOut], [EstimatedPay])values(@AttendanceID, @EmployeeID, @AttendanceDate, @AttendanceStatus, " +
                    "@TimeIn, 0, '00:00:00', 0)";
            string AttendanceStatus = "";

            if (timein.Hour <= 8) AttendanceStatus = "Present";
            else if (timein.Hour <= 12 && timein.Hour > 8) AttendanceStatus = "Late";
            else AttendanceStatus = "Absent";

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                cn.Open();

                Random ran = new Random();
                int attID = ran.Next(1000000, 9999999);

                command.Parameters.AddWithValue("@AttendanceID", attID);
                command.Parameters.AddWithValue("@EmployeeID", empID);
                command.Parameters.AddWithValue("@AttendanceDate", timein.ToString("M/d/yyyy"));
                command.Parameters.AddWithValue("@AttendanceStatus", AttendanceStatus);
                command.Parameters.AddWithValue("@TimeIn", timein);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateAttendance(DateTime timeout, int attendanceID, int workHours, decimal pay)
        {
            string query = "update Attendance set [Att_TimeOut] = @TimeOut, [NumberOfWorkHours] = @NumberOfWorkHours, [EstimatedPay] = @EstimatePay where [AttendanceID] = @AttendanceID";
            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@TimeOut", timeout);
                command.Parameters.AddWithValue("@AttendanceID", attendanceID);
                command.Parameters.AddWithValue("@NumberOfWorkHours", workHours);
                command.Parameters.AddWithValue("@EstimatePay", pay);

                command.ExecuteNonQuery();
            }
        }

        public Employee GetAttendance(int empID)
        {
            Employee emp = null;
            string query = "select Employee.*, JobPositions.JobID, JobPositions.JobName, JobPositions.MonthlySalary, JobPositions.SalaryPerHour, EmployeeDashboardAccount.Username, EmployeeDashboardAccount.AccountPassword, Attendance.AttendanceID, Attendance.AttendanceDate, Attendance.AttendanceStatus, Attendance.Att_TimeIn, Attendance.Att_TimeOut, Attendance.NumberOfWorkHours from EmployeeJobInfo inner join JobPositions on EmployeeJobInfo.JobID = JobPositions.JobID inner join Employee on Employee.EmployeeID = EmployeeJobInfo.EmployeeID inner join EmployeeDashboardAccount on Employee.EmployeeID = EmployeeDashboardAccount.EmployeeID inner join Attendance on Attendance.EmployeeID = Employee.EmployeeID where Employee.EmployeeID = @empID and Attendance.AttendanceDate = @DateToday";

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@empID", empID);
                command.Parameters.AddWithValue("@DateToday", DateTime.Now.ToString("M/d/yyyy"));
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    emp = new Employee
                    {
                        Job = new JobPositions {
                            SalaryPerHour = decimal.Parse(reader["SalaryPerHour"].ToString())
                        },
                        AttendanceInformation = new Attendance
                        {
                            ID = int.Parse(reader["AttendanceID"].ToString()),
                            AttendanceDate = DateTime.Parse(reader["AttendanceDate"].ToString()),
                            AttendanceStatus = reader["AttendanceStatus"].ToString(),
                            TimeIn = TimeSpan.Parse(reader["Att_TimeIn"].ToString()),
                            NumberOfWorkHours = int.Parse(reader["NumberOfWorkHours"].ToString())
                        }
                    };
                }
            }

            return emp;
        }

        public Employee FilterAttendanceLogs(DateTime date , int empID)
        {
            Employee output = null;
            string query = "select Employee.*, JobPositions.JobID, JobPositions.JobName, JobPositions.MonthlySalary, JobPositions.SalaryPerHour, EmployeeDashboardAccount.Username, EmployeeDashboardAccount.AccountPassword, Attendance.AttendanceID, Attendance.AttendanceDate, Attendance.AttendanceStatus, Attendance.Att_TimeIn, Attendance.Att_TimeOut, Attendance.NumberOfWorkHours, Attendance.EstimatedPay from EmployeeJobInfo inner join JobPositions on EmployeeJobInfo.JobID = JobPositions.JobID inner join Employee on Employee.EmployeeID = EmployeeJobInfo.EmployeeID inner join EmployeeDashboardAccount on Employee.EmployeeID = EmployeeDashboardAccount.EmployeeID inner join Attendance on Attendance.EmployeeID = Employee.EmployeeID where Employee.EmployeeID = @empID and Attendance.AttendanceDate = @FilterDate";

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@empID", empID);
                command.Parameters.AddWithValue("@FilterDate", date.ToString("M/dd/yyyy"));
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    output = new Employee
                    {
                        AttendanceInformation = new Attendance { 
                            AttendanceDate = DateTime.Parse(reader["AttendanceDate"].ToString()),
                            EstimatedPay = decimal.Parse(reader["EstimatedPay"].ToString()),
                            NumberOfWorkHours = int.Parse(reader["NumberOfWorkHours"].ToString()),
                            TimeOut = TimeSpan.Parse(reader["Att_TimeOut"].ToString()),
                            AttendanceStatus = reader["AttendanceStatus"].ToString(),
                            TimeIn = TimeSpan.Parse(reader["Att_TimeIn"].ToString())
                        }
                    };
                }
            }


            return output;
        }
    }
}
