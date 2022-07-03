using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using PayrollSystemLibrary.Interfaces;
using PayrollSystemLibrary.Logic;
using PayrollSystemLibrary.Models;

namespace PayrollManagementSystem.AdminUI
{
    public partial class Login : MaterialForm
    {
        private PayrollUser admin;
        public Login()
        {
            InitializeComponent();
        }

        private void txtAccount_Proceed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private bool AdminLogin()
        {
            bool isValidLogin = false;
            AdminProcessor admin = new AdminProcessor();
            var adminInfo = admin.Login(txtUsername.Text, txtPassword.Text);
            this.admin = (PayrollUser) adminInfo;

            if (adminInfo != null)
            {
                isValidLogin = true;
            }

            return isValidLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValid = AdminLogin();

            if (isValid == true)
            {
                Dashboard adminDashboard = new Dashboard(admin);
                adminDashboard.ShowDialog();
            }
            else
            {
                error.SetError(btnLogin, "Invalid username or password. Please try again");
            }
        }
    }
}
