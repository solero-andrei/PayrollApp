using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.Interfaces
{
    public interface IUserProcessor
    {
        IUser Login(string username, string password);
        void Add(IUser user);
    }
}
