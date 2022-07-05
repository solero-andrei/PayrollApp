﻿using PayrollSystemLibrary.DataAccess;
using PayrollSystemLibrary.Interfaces;
using PayrollSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.Logic
{
    public class EmpAttendanceProcessor : IAttendance
    {
        EmpAttendanceRepository empRepository;
        public EmpAttendanceProcessor()
        {
            empRepository = new EmpAttendanceRepository();
        }

        public Employee FilterAttendanceLogs(DateTime date, int empID)
        {
            return empRepository.FilterAttendanceLogs(date, empID);
        }

        public Employee GetAttendanceDetails(int EmpID)
        {
            return empRepository.GetAttendance(EmpID);
        }

        public void SetTimeIn(int EmpID)
        {
            empRepository.SetAttendance(DateTime.Now, EmpID);
        }

        public void SetTimeOut(int AttendanceID, int workHours, decimal pay)
        {
            empRepository.UpdateAttendance(DateTime.Now, AttendanceID, workHours, pay);
        }
    }
}