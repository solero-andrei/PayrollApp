using PayrollSystemLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.DataAccess
{
    public interface IUserRepository
    {
        IUser GetUserDataByAccount(Roles role, string username, string password);
    }
}
