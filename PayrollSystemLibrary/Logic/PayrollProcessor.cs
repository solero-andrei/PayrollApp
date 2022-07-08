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
        public PayrollProcessor()
        {
            payrollRepo = new PayrollRepository();
        }
        public void UploadPayroll(Payroll payroll)
        {
            payrollRepo.InsertPayroll(payroll);
        }
    }
}
