using PayrollSystemLibrary.DataAccess;
using PayrollSystemLibrary.Interfaces;
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
        public string ImagePath{ private get; set; }
        public EmployeeProcessor()
        {

        }

        public EmployeeProcessor(string imagePath)
        {
            this.ImagePath = imagePath;
        }
        public void Add(IUser user)
        {
            UserRepository repository = new UserRepository();
            repository.AddUser(Roles.Client, user);
        }

        public IUser Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
