using PayrollSystemLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PayrollSystemLibrary.Models
{
    public class Employee : IUser
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public string HomeAddress { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfApply { get; set; }
        public JobPositions Job { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
