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
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue100, TextShade.BLACK);
        }
        private bool EmployeeLogin()
        {
            bool isValidLogin = false;
            EmployeeProcessor employee = new EmployeeProcessor();
            var empInfo = employee.Login(txtUsername.Text, txtPassword.Text);
            this.employee = (Employee)empInfo;

            if (empInfo != null)
            {
                isValidLogin = true;
            }

            return isValidLogin;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValid = EmployeeLogin();

            if (isValid == true)
            {
                MessageBox.Show("Valid Login");
            }
            else
            {
                ErrorProvider error = new ErrorProvider();
                error.SetError(btnLogin, "Invalid username or password. Please try again");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
