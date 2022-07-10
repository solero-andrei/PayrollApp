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
            string query = "insert into [Payroll] ([AdminID], [EmployeeID], [TotalWorkingHours], [TotalMinutesLate], [TotalOvertime], [TotalAmountLate], [TotalAmountWorkHours], [TotalAmountOvertime], [SSS], [PhilHealth], [PagIBIG], [TotalDeductions], [GrossPay], [NetPay], [DateProcessed], [PayrollStatus])values(@adminID, @employeeID, @totalWorkHours, @totalMinutesLate, @totalOvertime, @late, @workhours, @overtime, @sss, @philhealth, @pagibig, @deductions, @grosspay, @netpay, @dateprocessed, 'Paid');" +
                "insert into [PayrollLogs] ([AdminID], [EmployeeID], [TotalWorkingHours], [TotalMinutesLate], [TotalOvertime], [TotalAmountLate], [TotalAmountWorkHours], [TotalAmountOvertime], [SSS], [PhilHealth], [PagIBIG], [TotalDeductions], [GrossPay], [NetPay], [DateProcessed], [PayrollStatus])values(@adminID, @employeeID, @totalWorkHours, @totalMinutesLate, @totalOvertime, @late, @workhours, @overtime, @sss, @philhealth, @pagibig, @deductions, @grosspay, @netpay, @dateprocessed, 'Paid')";
            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand(query, cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@adminID", payroll.ProccesedBy.ID);
                command.Parameters.AddWithValue("@employeeID", payroll.EmpInformation.ID);
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

        public void ResetPayroll(int empID)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand("delete from Payroll where EmployeeID = @empID", cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@empID", empID);
                command.ExecuteNonQuery();
            }
        }

        public Payroll FilterValidatePayroll(int empID, string anotherCondition)
        {
            Payroll pay = null;

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand($"select Employee.*, Payroll.*, EmployeeJobInfo.*, JobPositions.*, PayrollUser.FirstName as AdminFirstName, PayrollUser.LastName as AdminLastName, PayrollUser.MiddleName as AdminMiddleName from Employee left join Payroll on Payroll.EmployeeID = Employee.EmployeeID inner join EmployeeJobInfo on Employee.EmployeeID = EmployeeJobInfo.EmployeeID inner join JobPositions on EmployeeJobInfo.JobID = JobPositions.JobID left join PayrollUser on Payroll.AdminID = PayrollUser.AdminID where Employee.EmployeeID = @empID  {anotherCondition}", cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@empID", empID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() == true)
                {
                    pay = new Payroll
                    {
                        EmpInformation = new Employee
                        {
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            EmailAddress = reader["EmailAddress"].ToString(),
                            ContactNumber = reader["ContactNumber"].ToString(),
                            Job = new JobPositions
                            {
                                JobName = reader["JobName"].ToString(),
                                MonthlySalary = decimal.Parse(reader["MonthlySalary"].ToString()),
                                SalaryPerHour = decimal.Parse(reader["SalaryPerHour"].ToString())
                            },
                        },
                        PayrollStatus = reader["PayrollStatus"].ToString()
                    };
                }
            }

            return pay;
        }

        public Payroll PayrollHistory(int empID)
        {
            Payroll pay = null;

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand($"select distinct Employee.*, PayrollLogs.*, EmployeeJobInfo.*, JobPositions.*, PayrollUser.FirstName as AdminFirstName, PayrollUser.LastName as AdminLastName, PayrollUser.MiddleName as AdminMiddleName from Employee left join PayrollLogs on PayrollLogs.EmployeeID = Employee.EmployeeID inner join EmployeeJobInfo on Employee.EmployeeID = EmployeeJobInfo.EmployeeID inner join JobPositions on EmployeeJobInfo.JobID = JobPositions.JobID left join PayrollUser on PayrollLogs.AdminID = PayrollUser.AdminID where Employee.EmployeeID = @empID", cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@empID", empID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() == true)
                {
                    try
                    {
                        pay = new Payroll
                        {
                            EmpInformation = new Employee
                            {
                                ID = int.Parse(reader["EmployeeID"].ToString()),
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
                                MiddleName = reader["MiddleName"].ToString(),
                                Job = new JobPositions
                                {
                                    JobName = reader["JobName"].ToString(),
                                    MonthlySalary = decimal.Parse(reader["MonthlySalary"].ToString()),
                                    SalaryPerHour = decimal.Parse(reader["SalaryPerHour"].ToString())
                                },
                                AttendanceInformation = new Attendance
                                {
                                    NumberOfWorkHours = int.Parse(reader["TotalWorkingHours"].ToString()),
                                    Overtime = int.Parse(reader["TotalOvertime"].ToString())
                                }
                            },
                            ProccesedBy = new PayrollUser
                            {
                                FirstName = reader["AdminFirstName"].ToString(),
                                LastName = reader["AdminLastName"].ToString()
                            },

                            TotalLateAmount = decimal.Parse(reader["TotalAmountLate"].ToString()),
                            SSS = decimal.Parse(reader["SSS"].ToString()),
                            PhilHealth = decimal.Parse(reader["Philhealth"].ToString()),
                            PagIBIG = decimal.Parse(reader["PagIBIG"].ToString()),
                            TotalDeductions = decimal.Parse(reader["TotalDeductions"].ToString()),
                            GrossPay = decimal.Parse(reader["GrossPay"].ToString()),
                            NetPay = decimal.Parse(reader["NetPay"].ToString()),
                            DateProcessed = DateTime.Parse(reader["DateProcessed"].ToString()),
                            
                        };
                    }
                    catch (Exception)
                    {

                    }
                }
            }

            return pay;
        }


        public List<Payroll> GetAllPayrollHistory()
        {
            List<Payroll> pay = new List<Payroll>();

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand($"select Employee.*, PayrollLogs.*, EmployeeJobInfo.*, JobPositions.*, PayrollUser.FirstName as AdminFirstName, PayrollUser.LastName as AdminLastName, PayrollUser.MiddleName as AdminMiddleName from Employee left join PayrollLogs on PayrollLogs.EmployeeID = Employee.EmployeeID inner join EmployeeJobInfo on Employee.EmployeeID = EmployeeJobInfo.EmployeeID inner join JobPositions on EmployeeJobInfo.JobID = JobPositions.JobID left join PayrollUser on PayrollLogs.AdminID = PayrollUser.AdminID", cn))
            {
                cn.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    pay.Add(new Payroll
                    {
                        //PayrollID = int.Parse(reader["PayrollID"].ToString()),
                        //EmpInformation = new Employee
                        //{
                        //    ID = int.Parse(reader["EmployeeID"].ToString()),
                        //    FirstName = reader["FirstName"].ToString(),
                        //    LastName = reader["LastName"].ToString(),
                        //    MiddleName = reader["MiddleName"].ToString(),
                        //    Job = new JobPositions
                        //    {
                        //        JobName = reader["JobName"].ToString(),
                        //        MonthlySalary = decimal.Parse(reader["MonthlySalary"].ToString()),
                        //        SalaryPerHour = decimal.Parse(reader["SalaryPerHour"].ToString())
                        //    },
                        //    AttendanceInformation = new Attendance
                        //    {
                        //        NumberOfWorkHours = int.Parse(reader["TotalWorkingHours"].ToString()),
                        //        Overtime = int.Parse(reader["TotalOvertime"].ToString())
                        //    }
                        //},
                        //ProccesedBy = new PayrollUser
                        //{
                        //    FirstName = reader["AdminFirstName"].ToString(),
                        //    LastName = reader["AdminLastName"].ToString()
                        //},

                        //TotalLateAmount = decimal.Parse(reader["TotalAmountLate"].ToString()),
                        //SSS = decimal.Parse(reader["SSS"].ToString()),
                        //PhilHealth = decimal.Parse(reader["Philhealth"].ToString()),
                        //PagIBIG = decimal.Parse(reader["PagIBIG"].ToString()),
                        //TotalDeductions = decimal.Parse(reader["TotalDeductions"].ToString()),
                        //GrossPay = decimal.Parse(reader["GrossPay"].ToString()),
                        //NetPay = decimal.Parse(reader["NetPay"].ToString()),
                        //DateProcessed = DateTime.Parse(reader["DateProcessed"].ToString()),

                    });
                }
            }

            return pay;
        }

        public Payroll FilterValidatePayrollLogs(int empID, string anotherCondition)
        {
            Payroll pay = null;

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand($"select distinct Employee.*, Payroll.*, EmployeeJobInfo.*, JobPositions.*, PayrollUser.FirstName as AdminFirstName, PayrollUser.LastName as AdminLastName, PayrollUser.MiddleName as AdminMiddleName from Employee left join Payroll on Payroll.EmployeeID = Employee.EmployeeID inner join EmployeeJobInfo on Employee.EmployeeID = EmployeeJobInfo.EmployeeID inner join JobPositions on EmployeeJobInfo.JobID = JobPositions.JobID left join PayrollUser on Payroll.AdminID = PayrollUser.AdminID where Employee.EmployeeID = @empID {anotherCondition}", cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@empID", empID);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read() == true)
                {
                    try
                    {

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

            return pay;
        }

        public List<Payroll> GetPayrollLogs(string condition)
        {
            List<Payroll> outputs = new List<Payroll>();

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand($"select distinct Employee.*, Payroll.*, EmployeeJobInfo.*, JobPositions.* from Employee left join Payroll on Payroll.EmployeeID = Employee.EmployeeID inner join EmployeeJobInfo on Employee.EmployeeID = EmployeeJobInfo.EmployeeID inner join JobPositions on EmployeeJobInfo.JobID = JobPositions.JobID {condition}", cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy"));
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    outputs.Add(new Payroll
                    {
                        PayrollID = int.Parse(reader["PayrollID"].ToString()),
                        EmpInformation = new Employee
                        {
                            ID = int.Parse(reader["EmployeeID"].ToString()),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            MiddleName = reader["MiddleName"].ToString(),
                            Job = new JobPositions
                            {
                                JobName = reader["JobName"].ToString()
                            }
                        },
                        PayrollStatus = reader["PayrollStatus"].ToString(),
                        DateProcessed = DateTime.Parse(reader["DateProcessed"].ToString())
                    });
                }
            }

            return outputs;
        }

        public List<Payroll> GetPayrollStatus(string condition)
        {
            List<Payroll> outputs = new List<Payroll>();

            using (SqlConnection cn = new SqlConnection(ConnectionString.CnnString))
            using (SqlCommand command = new SqlCommand($"select distinct Employee.*, Payroll.*, EmployeeJobInfo.*, JobPositions.* from Employee left join Payroll on Payroll.EmployeeID = Employee.EmployeeID inner join EmployeeJobInfo on Employee.EmployeeID = EmployeeJobInfo.EmployeeID inner join JobPositions on EmployeeJobInfo.JobID = JobPositions.JobID {condition}", cn))
            {
                cn.Open();
                command.Parameters.AddWithValue("@date", DateTime.Now.ToString("MM/dd/yyyy"));
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    outputs.Add(new Payroll
                    {
                        EmpInformation = new Employee
                        {
                            ID = int.Parse(reader["EmployeeID"].ToString()),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            MiddleName = reader["MiddleName"].ToString(),
                            Job = new JobPositions
                            {
                                JobName = reader["JobName"].ToString()
                            }
                        },
                    });
                }
            }

            return outputs;
        }

    }
}
