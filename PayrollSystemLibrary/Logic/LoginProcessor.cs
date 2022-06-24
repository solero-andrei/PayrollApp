using PayrollSystemLibrary.DataAccess;
using PayrollSystemLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.Logic
{
    public class LoginProcessor
    {
        public bool UserLogin(string username, string password, out IUser userInformation)
        {
            bool isValid = false;
            Repository repo = new Repository(username, password);
            var userInfo = repo.GetUserDataByAccount(Roles.Admin);

            if (userInfo != null)
            {
                isValid = true;
            }

            userInformation = userInfo;

            return isValid;
        }
    }
}
