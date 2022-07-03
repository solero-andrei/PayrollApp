using MaterialSkin;
using MaterialSkin.Controls;
using PayrollSystemLibrary.Logic;
using PayrollSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagementSystem.ClientUI
{
    public partial class Login : MaterialForm
    {
        private Employee employee;
        public Login()
        {
            InitializeComponent();
        }
        private bool EmployeeLogin()
        {
            bool isValidLogin = false;
            EmployeeProcessor employee = new EmployeeProcessor();
            var empInfo = employee.Login(txtUsername.Text, txtPassword.Text);
            this.employee = (Employee) empInfo;

            if (empInfo != null)
            {
                isValidLogin = true;
            }

            TimeIn();
            return isValidLogin;
        }

        private void TimeIn()
        {
            EmployeeProcessor empProcessor = new EmployeeProcessor();
            empProcessor.SetTimeIn(this.employee.ID);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValid = EmployeeLogin();

            if (isValid == true)
            {
                Dashboard employeeDashboard = new Dashboard(employee);
                employeeDashboard.ShowDialog();
            }
            else
            {
                ErrorProvider error = new ErrorProvider();
                error.SetError(btnLogin, "Invalid username or password. Please try again");
            }
        }
    }
}
