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
using PayrollSystemLibrary.Models;
using System.IO;

namespace PayrollManagementSystem.AdminUI
{
    public partial class Login : MaterialForm
    {
        private PayrollUser admin;
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue100, TextShade.WHITE);

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
                this.Hide();
                Dashboard adminDashboard = new Dashboard(admin);
                adminDashboard.Show();
            }
            else
            {
                error.SetError(btnLogin, "Invalid username or password. Please try again");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\EmployeeImages";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
