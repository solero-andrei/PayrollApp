using PayrollSystemLibrary.DataAccess;
using PayrollSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.Logic
{
    public class PayrollProcessor
    {
        PayrollRepository payrollRepo;
        EmpAttendanceRepository attendanceRepo;
        public PayrollProcessor()
        {
            payrollRepo = new PayrollRepository();
            attendanceRepo = new EmpAttendanceRepository();
        }
        public void UploadPayroll(Payroll payroll)
        {
            payrollRepo.InsertPayroll(payroll);
            attendanceRepo.ResetAttendance(payroll.EmpInformation.ID);
        }

        public Payroll FilterPayroll(int empID, string condition)
        {
            return payrollRepo.FilterValidatePayroll(empID, condition);
        }

        public List<Payroll> GetPayrollStatus(string condition)
        {
            return payrollRepo.GetPayrollStatus(condition);
        }

        public Payroll PayrollHistory(int empID)
        {
            return payrollRepo.PayrollHistory(empID);
        }

        public Payroll FilterPayrollLogs(int empID, string condition)
        {
            return payrollRepo.FilterValidatePayrollLogs(empID, condition);
        }

        public List<Payroll> GetPayrollStatusLogs(string condition)
        {
            return payrollRepo.GetPayrollLogs(condition);
        }

        public List<Payroll> GetAllPayrollHistory()
        {
            return payrollRepo.GetAllPayrollHistory();
        }
    }
}
