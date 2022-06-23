using PayrollSystemLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.Logic
{
    public class LoginProcessor
    {
        public bool AdminLogin(string username, string password)
        {
            bool isValid = false;
            Repository repo = new Repository(username, password);
            if(repo.GetUserDataByAccount(Roles.Admin) != null)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
