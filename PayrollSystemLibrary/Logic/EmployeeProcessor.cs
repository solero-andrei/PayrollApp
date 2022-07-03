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
        EmpAttendanceRepository empRepository;
        public EmployeeProcessor()
        {
            repository = new UserRepository();
            empRepository = new EmpAttendanceRepository();
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

        public void SetTimeIn(int empID)
        {
            empRepository.SetAttendance(DateTime.Now, empID);
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
