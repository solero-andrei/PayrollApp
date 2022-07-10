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
        public bool SetAttendance(DateTime timein, int empID)
        {
            bool setAttendance = false;

            if (AttendanceValidation(timein, empID) == true)
            {
                setAttendance = false;
            }
            else
            {
                string query = "insert into [Attendance]([AttendanceID], [EmployeeID], [AttendanceDate], [AttendanceStatus], [Att_TimeIn], [NumberOfWorkHours], [Att_TimeOut], [EstimatedPay], [MinutesLate], [NumberOfOvertimeHours])values(@AttendanceID, @EmployeeID, @AttendanceDate, @AttendanceStatus, " +
                    "@TimeIn, 0, '00:00:00', 0, @minutesLate, 0);" +
                    "insert into [AttendanceLogs]([AttendanceID], [EmployeeID], [AttendanceDate], [AttendanceStatus], [Att_TimeIn], [NumberOfWorkHours], [Att_TimeOut], [EstimatedPay], [MinutesLate], [NumberOfOvertimeHours])values(@AttendanceID, @EmployeeID, @AttendanceDate, @AttendanceStatus, " +
                    "@TimeIn, 0, '00:00:00', 0, @minutesLate, 0)";
                string AttendanceStatus = "";

                TimeSpan requiredTime = TimeSpan.Parse("8:30");
                TimeSpan userTimeIn = TimeSpan.Parse(timein.ToString("HH:mm"));
                var TotalMinutesLate = (userTimeIn - requiredTime).TotalMinutes;

                if (userTimeIn < requiredTime) TotalMinutesLate = 0;

                if (userTimeIn <= requiredTime) AttendanceStatus = "Present";
                else if (userTimeIn > requiredTime) AttendanceStatus = "Late";

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
                    command.Parameters.AddWithValue("@TimeIn", userTimeIn);
                    command.Parameters.AddWithValue("@minutesLate", TotalMinutesLate);

                    command.ExecuteNonQuery();
                }

                setAttendance = true;
            }

            return setAttendance;
        }

        public bool AttendanceValidation(DateTime date, int empID)
        {
            bool attendanceFound = false;
            string query = "select * from [Attendance] where AttendanceDate = @AttendanceDate and EmployeeID = @empID";

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                cn.Open();

                command.Parameters.AddWithValue("@empID", empID);
                command.Parameters.AddWithValue("@AttendanceDate", date.ToString("M/d/yyyy"));

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read() == true)
                {
                    attendanceFound = true;
                }
            }

            return attendanceFound;
        }

        public void UpdateAttendance(DateTime timeout, int attendanceID, int workHours, decimal pay)
        {
            TimeSpan timein = TimeSpan.Parse("00:00:00");
            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand("select * from Attendance where [AttendanceID] = @attendanceid", cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@attendanceid", attendanceID);
                SqlDataReader reader = command.ExecuteReader();
                
                if(reader.Read())
                {
                    timein = TimeSpan.Parse(reader["Att_TimeIn"].ToString());
                }
            }
            //-------------

            var overtime = (TimeSpan.Parse(timeout.ToString("HH:mm:ss")) - timein).TotalHours - 9;

            if (overtime < 0) overtime = 0;
            
            string query = "update Attendance set [Att_TimeOut] = @TimeOut, [NumberOfWorkHours] = @NumberOfWorkHours, [EstimatedPay] = @EstimatePay, [NumberOfOvertimeHours] = @overtime where [AttendanceID] = @AttendanceID;" +
                "update AttendanceLogs set [Att_TimeOut] = @TimeOut, [NumberOfWorkHours] = @NumberOfWorkHours, [EstimatedPay] = @EstimatePay, [NumberOfOvertimeHours] = @overtime where [AttendanceID] = @AttendanceID";
            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@TimeOut", timeout);
                command.Parameters.AddWithValue("@AttendanceID", attendanceID);
                command.Parameters.AddWithValue("@NumberOfWorkHours", workHours - 1);
                command.Parameters.AddWithValue("@EstimatePay", pay);
                command.Parameters.AddWithValue("@overtime", overtime);

                command.ExecuteNonQuery();
            }
        }

        public void ResetAttendance(int empID)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand("delete from Attendance where EmployeeID = @empID", cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@empID", empID);
                command.ExecuteNonQuery();
            }
        }

        public Employee GetAttendance(int empID)
        {
            Employee emp = null;
            string query = "select Employee.*, JobPositions.JobID, JobPositions.JobName, JobPositions.MonthlySalary, JobPositions.SalaryPerHour, EmployeeDashboardAccount.Username, EmployeeDashboardAccount.AccountPassword, Attendance.AttendanceID, Attendance.AttendanceDate, Attendance.AttendanceStatus, Attendance.Att_TimeIn, Attendance.Att_TimeOut, Attendance.NumberOfWorkHours, Attendance.MinutesLate, Attendance.NumberOfOvertimeHours from EmployeeJobInfo inner join JobPositions on EmployeeJobInfo.JobID = JobPositions.JobID inner join Employee on Employee.EmployeeID = EmployeeJobInfo.EmployeeID inner join EmployeeDashboardAccount on Employee.EmployeeID = EmployeeDashboardAccount.EmployeeID inner join Attendance on Attendance.EmployeeID = Employee.EmployeeID where Employee.EmployeeID = @empID and Attendance.AttendanceDate = @DateToday order by Attendance.Att_TimeIn desc";

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
                            NumberOfWorkHours = int.Parse(reader["NumberOfWorkHours"].ToString()),
                            MinutesLate = int.Parse(reader["MinutesLate"].ToString()),
                            Overtime = int.Parse(reader["NumberOfOvertimeHours"].ToString())
                        }
                    };
                }
            }

            return emp;
        }

        public Employee FilterAttendanceLogs(DateTime date , int empID)
        {
            Employee output = null;
            string query = "select Employee.*, JobPositions.JobID, JobPositions.JobName, JobPositions.MonthlySalary, JobPositions.SalaryPerHour, EmployeeDashboardAccount.Username, EmployeeDashboardAccount.AccountPassword, AttendanceLogs.AttendanceID, AttendanceLogs.AttendanceDate, AttendanceLogs.AttendanceStatus, AttendanceLogs.Att_TimeIn, AttendanceLogs.Att_TimeOut, AttendanceLogs.NumberOfWorkHours, AttendanceLogs.EstimatedPay, AttendanceLogs.MinutesLate, AttendanceLogs.NumberOfOvertimeHours from EmployeeJobInfo inner join JobPositions on EmployeeJobInfo.JobID = JobPositions.JobID inner join Employee on Employee.EmployeeID = EmployeeJobInfo.EmployeeID inner join EmployeeDashboardAccount on Employee.EmployeeID = EmployeeDashboardAccount.EmployeeID inner join AttendanceLogs on AttendanceLogs.EmployeeID = Employee.EmployeeID where Employee.EmployeeID = @empID and AttendanceLogs.AttendanceDate = @FilterDate";

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
                            TimeIn = TimeSpan.Parse(reader["Att_TimeIn"].ToString()),
                            MinutesLate = int.Parse(reader["MinutesLate"].ToString()),
                            Overtime = int.Parse(reader["NumberOfOvertimeHours"].ToString())
                        }
                    };
                }
            }

            return output;
        }

        public List<Employee> GetAttendanceDetails(string condition)
        {
            List<Employee> output = new List<Employee>();

            string query = $"select Employee.*, JobPositions.JobID, JobPositions.JobName, JobPositions.MonthlySalary, JobPositions.SalaryPerHour, EmployeeDashboardAccount.Username, EmployeeDashboardAccount.AccountPassword, Attendance.AttendanceID, Attendance.AttendanceDate, Attendance.AttendanceStatus, Attendance.Att_TimeIn, Attendance.Att_TimeOut, Attendance.NumberOfWorkHours, Attendance.MinutesLate, Attendance.NumberOfOvertimeHours from EmployeeJobInfo inner join JobPositions on EmployeeJobInfo.JobID = JobPositions.JobID inner join Employee on Employee.EmployeeID = EmployeeJobInfo.EmployeeID inner join EmployeeDashboardAccount on Employee.EmployeeID = EmployeeDashboardAccount.EmployeeID inner join Attendance on Attendance.EmployeeID = Employee.EmployeeID where Attendance.AttendanceDate = @DateToday {condition} order by Attendance.Att_TimeIn desc";

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@DateToday", DateTime.Now.ToString("M/d/yyyy"));
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    output.Add(new Employee
                    {
                        FirstName = reader["FirstName"].ToString(),
                        MiddleName = reader["MiddleName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        AttendanceInformation = new Attendance 
                        {
                            AttendanceStatus = reader["AttendanceStatus"].ToString(),
                            MinutesLate = int.Parse(reader["MinutesLate"].ToString()),
                            NumberOfWorkHours = int.Parse(reader["NumberOfWorkHours"].ToString()),
                            TimeIn = TimeSpan.Parse(reader["Att_TimeIn"].ToString()),
                            TimeOut = TimeSpan.Parse(reader["Att_TimeOut"].ToString()),
                            Overtime = int.Parse(reader["NumberOfOvertimeHours"].ToString())
                        }
                    });
                }
            }

            return output;
        }

        public Employee ComputeWorkHours(int empID)
        {
            Employee emp = null;
            string query = "select sum(NumberOfWorkHours) as TotalWorkHours, sum(MinutesLate) as TotalMinutesLate, sum(NumberOfOvertimeHours) as TotalOvertimeHours from Attendance where EmployeeID = @empID";

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@empID", empID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    try
                    {
                        emp = new Employee
                        {
                            AttendanceInformation = new Attendance
                            {
                                NumberOfWorkHours = int.Parse(reader["TotalWorkHours"].ToString()),
                                MinutesLate = int.Parse(reader["TotalMinutesLate"].ToString()),
                                Overtime = int.Parse(reader["TotalOvertimeHours"].ToString())
                            }
                        };
                    }
                    catch (Exception)
                    {
                        emp = new Employee
                        {
                            AttendanceInformation = new Attendance
                            {
                                NumberOfWorkHours = 0,
                                MinutesLate = 0,
                                Overtime = 0
                            }
                        };
                    }
                    
                }
            }

            return emp;
        }
    }
}
