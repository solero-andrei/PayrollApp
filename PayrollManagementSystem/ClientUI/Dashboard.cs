using MaterialSkin.Controls;
using PayrollSystemLibrary.DataAccess;
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
        private Employee fullDetails;
        public Dashboard()
        {
            InitializeComponent();
            timeDate.Enabled = true;
        }

        public Dashboard(Employee user) : this()
        {
            this.employeeDetails = user;
            EmpAttendanceRepository attendanceRepo = new EmpAttendanceRepository();
            this.fullDetails = attendanceRepo.GetAttendance(employeeDetails.ID);

            LoadFullDetails();
        }

        private void LoadFullDetails()
        {
            lblTimein.Text = fullDetails.AttendanceInformation.TimeIn.ToString();
            lblStatus.Text = fullDetails.AttendanceInformation.AttendanceStatus.ToString();
            lblHourlyPay.Text = fullDetails.Job.SalaryPerHour.ToString();
        }

        private void Greetings()
        {
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

        private void timeDate_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("D");
            lblTime.Text = DateTime.Now.ToString("T");

            var numberOfHours = DateTime.Now.Hour - this.fullDetails.AttendanceInformation.TimeIn.Hours;
            var estimate = numberOfHours * fullDetails.Job.SalaryPerHour;

            lblHoursOfWork.Text = numberOfHours.ToString();
            lblEstimatedPay.Text = estimate.ToString();

            Greetings();
        }
    }
}
