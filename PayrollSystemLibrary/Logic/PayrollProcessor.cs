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

        /// <summary>
        /// Used to validate the payroll status of the employee
        /// </summary>
        /// <param name="empID"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public Payroll FilterPayroll(int empID, string condition)
        {
            return payrollRepo.FilterValidatePayroll(empID, condition);
        }

        /// <summary>
        /// Used to get all employee list for payroll processing
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<Payroll> GetPayrollList(string condition)
        {
            return payrollRepo.GetPayrollStatus(condition);
        }

        /// <summary>
        /// Return filtered payroll history
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public Payroll PayrollHistory(string condition)
        {
            return payrollRepo.FilterPayrollHistory(condition);
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
