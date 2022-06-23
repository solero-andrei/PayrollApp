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
using PayrollSystemLibrary.Logic;

namespace PayrollManagementSystem.AdminUI
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        }

        private void txtAccount_Proceed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                bool isValidLogin = LoginUser(txtUsername.Text, txtPassword.Text);
                if (isValidLogin == true)
                {
                    Dashboard adminDashboard = new Dashboard();
                    adminDashboard.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }
        }

        private bool LoginUser(string username, string password)
        {
            LoginProcessor adminLogin = new LoginProcessor();
            bool isValidLogin = adminLogin.AdminLogin(username, password);

            return isValidLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isValidLogin = LoginUser(txtUsername.Text, txtPassword.Text);
            if (isValidLogin == true)
            {
                Dashboard adminDashboard = new Dashboard();
                adminDashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid");
            }
        }
    }
}
