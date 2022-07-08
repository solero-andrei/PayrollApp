using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PayrollSystemLibrary.Models;

namespace PayrollSystemLibrary.DataAccess
{
    public class PayrollRepository
    {
        public void InsertPayroll(Payroll payroll)
        {
            string query = "insert into [Payroll] ([AdminID], [TotalWorkingHours], [TotalMinutesLate], [TotalOvertime], [TotalAmountLate], [TotalAmountWorkHours], [TotalAmountOvertime], [SSS], [PhilHealth], [PagIBIG], [TotalDeductions], [GrossPay], [NetPay], [DateProcessed])values(@adminID, @totalWorkHours, @totalMinutesLate, @totalOvertime, @late, @workhours, @overtime, @sss, @philhealth, @pagibig, @deductions, @grosspay, @netpay, @dateprocessed)";
            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@adminID", payroll.ProccesedBy.ID);
                command.Parameters.AddWithValue("@totalWorkHours", payroll.EmpInformation.AttendanceInformation.NumberOfWorkHours);
                command.Parameters.AddWithValue("@totalMinutesLate", payroll.EmpInformation.AttendanceInformation.MinutesLate);
                command.Parameters.AddWithValue("@totalOvertime", payroll.EmpInformation.AttendanceInformation.Overtime);
                command.Parameters.AddWithValue("@late", payroll.TotalLateAmount);
                command.Parameters.AddWithValue("@workhours", payroll.TotalWorkHoursAmount);
                command.Parameters.AddWithValue("@overtime", payroll.TotalOvertimeAmount);
                command.Parameters.AddWithValue("@sss", payroll.SSS);
                command.Parameters.AddWithValue("@philhealth", payroll.PhilHealth);
                command.Parameters.AddWithValue("@pagibig", payroll.PagIBIG);
                command.Parameters.AddWithValue("@deductions", payroll.TotalDeductions);
                command.Parameters.AddWithValue("@grosspay", payroll.GrossPay);
                command.Parameters.AddWithValue("@netpay", payroll.NetPay);
                command.Parameters.AddWithValue("@dateprocessed", DateTime.Now.ToString("MM/dd/yyy"));

                command.ExecuteNonQuery();
            }
        }
    }
}
