using PayrollSystemLibrary.DataAccess;
using PayrollSystemLibrary.Interfaces;
using PayrollSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystemLibrary.Logic
{
    public class EmployeeProcessor : IUserProcessor
    {
        IUserRepository repository;
        public EmployeeProcessor()
        {
            repository = new UserRepository();
        }
        public void Add(IUser user)
        {
            repository.AddUser(Roles.Client, user);
        }

        public IUser GetUserByID(int userID)
        {
            return repository.GetUserDataByID(Roles.Client, userID);
        }

        public List<IUser> GetUsers()
        {
            return repository.GetAllUsers(Roles.Client);            
        }

        public IUser Login(string username, string password)
        {
            IUserRepository adminRepo = new UserRepository();
            IUser emp = new Employee();

            var empInfo = adminRepo.GetUserDataByAccount(Roles.Client, username, password);
            emp = empInfo;

            return emp;
        }
    }
}
