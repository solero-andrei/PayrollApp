using PayrollSystemLibrary.DataAccess;
using PayrollSystemLibrary.Interfaces;
using PayrollSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.Logic
{
    public class AdminProcessor : IUserProcessor
    {
        public void Add(IUser user)
        {
            
        }

        public IUser GetUserByID(int userID)
        {
            throw new NotImplementedException();
        }

        public List<IUser> GetUsers()
        {
            throw new NotImplementedException();
        }

        public IUser Login(string username, string password)
        {
            IUserRepository adminRepo = new UserRepository();
            IUser admin = new PayrollUser();

            var adminInfo = adminRepo.GetUserDataByAccount(Roles.Admin, username, password);
            admin = adminInfo;

            return admin;
        }
    }
}
