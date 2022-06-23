using PayrollSystemLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.DataAccess
{
    public interface IRepository
    {
        IUser GetUserDataByAccount(Roles role);
    }
}
