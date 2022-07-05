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
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue100, TextShade.WHITE);
        }
        private bool EmployeeLogin()
        {
            EmployeeProcessor employee = new EmployeeProcessor();
            var empInfo = employee.Login(txtUsername.Text, txtPassword.Text);
            this.employee = (Employee) empInfo;

            bool isValidLogin;
            if (empInfo != null)
            {
                isValidLogin = true;
            }
            else
            {
                isValidLogin = false;
            }

            return isValidLogin;
        }

        private void TimeIn()
        {
            EmpAttendanceProcessor attendanceProcessor = new EmpAttendanceProcessor();
            attendanceProcessor.SetTimeIn(this.employee.ID);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValid = EmployeeLogin();

            if (isValid == true)
            {
                TimeIn();
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
