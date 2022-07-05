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
        IUserRepository repository;
        public AdminProcessor()
        {
            repository = new UserRepository();
        }

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
            IUser admin = new PayrollUser();

            var adminInfo = repository.GetUserDataByAccount(Roles.Admin, username, password);
            admin = adminInfo;

            return admin;
        }

        public void Update(IUser user)
        {
            repository.UpdateUser(Roles.Client, user);
        }
    }
}
