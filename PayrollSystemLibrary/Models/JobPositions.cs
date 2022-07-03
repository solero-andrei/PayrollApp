using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.Models
{
    public class JobPositions
    {
        public int JobID { get; set; }
        public string JobName { get; set; }
        public decimal MonthlySalary { get; set; }
        public decimal SalaryPerHour { get; set; }
    }
}
