using MaterialSkin.Controls;
using PayrollSystemLibrary.Interfaces;
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
    public partial class Dashboard : MaterialForm
    {
        private Employee employeeDetails;
        public Dashboard()
        {
            InitializeComponent();
            monthCalendar1.TitleBackColor = System.Drawing.Color.Blue;
            monthCalendar1.TrailingForeColor = System.Drawing.Color.Red;
            monthCalendar1.TitleForeColor = System.Drawing.Color.Yellow;
            //timeDate.Enabled = true;
        }

        public Dashboard(Employee user) : this()
        {
            this.employeeDetails = user;
            
        }

        private void timeDate_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("D");
            lblTime.Text = DateTime.Now.ToString("T");

            if (DateTime.Now.Hour <= 12 && DateTime.Now.Hour > 0)
            {
                txtGreeting.Text = $"Hello, Good Morning! {employeeDetails.FirstName} {employeeDetails.LastName}";
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 17)
            {
                txtGreeting.Text = $"Hello, Good Afternoon! {employeeDetails.FirstName} {employeeDetails.LastName}";
            }
            else if (DateTime.Now.Hour >= 17 && DateTime.Now.Hour < 24)
            {
                txtGreeting.Text = $"Hello, Good Evening! {employeeDetails.FirstName} {employeeDetails.LastName}";
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            monthCalendar1.BackColor = Color.Red;
        }
    }
}
