using PayrollSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.Interfaces
{
    public interface IAttendance
    {
        bool SetTimeIn(int EmpID);
        void SetTimeOut(int AttendanceID, int workHours, decimal pay);
        Employee GetAttendanceDetails(int EmpID);
        Employee FilterAttendanceLogs(DateTime date, int empID);
        Employee ComputeWorkingHours(int empID);
    }
}
