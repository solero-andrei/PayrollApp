using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.Models
{
    public class Payroll
    {
        public Employee EmpInformation { get; set; }
        public PayrollUser ProccesedBy { get; set; }
        public decimal TotalLateAmount { get; set; }
        public decimal TotalWorkHoursAmount { get; set; }
        public decimal TotalOvertimeAmount { get; set; }
        public decimal SSS { get; set; }
        public decimal PhilHealth { get; set; }
        public decimal PagIBIG { get; set; }
        public decimal TotalDeductions { get; set; }
        public decimal GrossPay { get; set; }
        public decimal NetPay { get; set; }
        public DateTime DateProcessed { get; set; }
        public string PayrollStatus { get; set; }
    }
}
