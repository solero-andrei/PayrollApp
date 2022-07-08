using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSystem
{
    public class PayrollDeductionProcessor
    {
        private decimal monthlySalary = 0;
        public PayrollDeductionProcessor(decimal monthlySalary)
        {
            this.monthlySalary = monthlySalary;
        }

        public decimal SSSContribution()
        {
            return 581.30M;
        }

        public decimal PhilhealthContribution()
        {
            if (monthlySalary > 40000)
            {
                return 1100;
            }
            else
            {
                return monthlySalary * 0.0275M;
            }
        }

        public decimal PagIBIGContribution()
        {
            return 100;
        }

    }
}
