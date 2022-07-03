using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PayrollSystemLibrary.Models;

namespace PayrollSystemLibrary.DataAccess
{
    public class EmployeeRepository
    {
        public void SetAttendance(DateTime timein, int empID)
        {
            string query = "insert into [Attendance]([AttendanceID], [EmployeeID], [AttendanceDate], [AttendanceStatus], " +
                    "[Att_TimeIn])values(@AttendanceID, @EmployeeID, @AttendanceDate, @AttendanceStatus, " +
                    "@TimeIn)";
            string AttendanceStatus = "";

            if(timein.Hour <= 8 && timein.Minute < 10) AttendanceStatus = "Present";
            else if(timein.Hour <= 12 && timein.Hour > 8) AttendanceStatus = "Late";

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                cn.Open();

                Random ran = new Random();
                int attID = ran.Next(1000000, 9999999);

                command.Parameters.AddWithValue("@AttendanceID", attID);
                command.Parameters.AddWithValue("@EmployeeID", empID);
                command.Parameters.AddWithValue("@AttendanceDate", DateTime.Now.ToString("HH:mm:ss"));
                command.Parameters.AddWithValue("@AttendanceStatus", AttendanceStatus);
                command.Parameters.AddWithValue("@TimeIn", timein);

                command.ExecuteNonQuery();
            }
        }
    }
}
