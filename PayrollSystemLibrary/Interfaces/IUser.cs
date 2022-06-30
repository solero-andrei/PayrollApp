using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.Interfaces
{
    public interface IUser
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        string ContactNumber { get; set; }
        string Username { get; set; }
        string Password { get; set; }
    }
}
