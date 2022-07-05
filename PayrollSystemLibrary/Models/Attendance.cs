using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.Models
{
    public class Attendance
    {
        public int ID { get; set; }
        public DateTime AttendanceDate { get; set; }
        public string AttendanceStatus { get; set; }
        public TimeSpan TimeIn { get; set; }
        public TimeSpan TimeOut { get; set; }
        public int NumberOfWorkHours { get; set; } = 0;
        public decimal EstimatedPay { get; set; }
    }
}
