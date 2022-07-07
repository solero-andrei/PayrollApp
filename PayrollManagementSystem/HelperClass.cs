using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

        
        public static void SaveImage(string imagePath, string id)
        {
            string path = Directory.GetCurrentDirectory() + $@"\EmployeeImages\{id}.jpg";
            File.Copy(imagePath, path);
        }

        public static string LoadImage(string id)
        {
            return Directory.GetCurrentDirectory() + $@"\EmployeeImages\{id}.jpg";
        }

        public static string UsernameGenerator(string firstName, string lastName)
        {
            Random random = new Random();
            int number = random.Next(1, 99);
            return firstName.Substring(0, 2) + lastName + number;
        }
        
        public static string CurrencyFormat(decimal amount)
        {
            return amount.ToString("C", CultureInfo.GetCultureInfo("en-ph"));
        }
    }
}
