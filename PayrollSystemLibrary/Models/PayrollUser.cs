﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollSystemLibrary.Interfaces;

namespace PayrollSystemLibrary.Models
{
    public class PayrollUser : IUser
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public JobPositions JobID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
