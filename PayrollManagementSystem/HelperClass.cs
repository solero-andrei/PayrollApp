using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSystem
{
    public static class HelperClass
    {
        public static int GenerateID()
        {
            Random ran = new Random();
            return ran.Next(1000000, 9999999);
        }

        public static string UsernameGenerator(string firstName, string lastName)
        {
            Random random = new Random();
            int number = random.Next(1, 99);
            return firstName.Substring(0, 2) + lastName + number;
        }
    }
}
