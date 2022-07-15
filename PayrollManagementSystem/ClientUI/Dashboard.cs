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
    public partial class Dashboard : MaterialForm
    {
        private Employee employeeDetails;
        private Employee fullDetails;
        private EmpAttendanceProcessor attendanceProcessor;
        private PayrollProcessor payProcessor;
        private int numberOfHours;
        private decimal estimate;
        public Dashboard()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue100, TextShade.WHITE);
            timeDate.Enabled = true;
        }

        public Dashboard(Employee user) : this()
        {
            attendanceProcessor = new EmpAttendanceProcessor();
            payProcessor = new PayrollProcessor();

            this.employeeDetails = user;
            this.fullDetails = attendanceProcessor.GetAttendanceDetails(employeeDetails.ID);

            LoadFullDetails();
            LoadPayrollLogs();
        }

        private void LoadFullDetails()
        {
            lblTimein.Text = fullDetails.AttendanceInformation.TimeIn.ToString();
            lblStatus.Text = fullDetails.AttendanceInformation.AttendanceStatus.ToString();
            lblHourlyPay.Text = HelperClass.CurrencyFormat(fullDetails.Job.SalaryPerHour);
            lblAttendanceID.Text = fullDetails.AttendanceInformation.ID.ToString();
            lblUserID.Text = employeeDetails.ID.ToString();
            lblMinutesLate.Text = fullDetails.AttendanceInformation.MinutesLate.ToString();
        }

        private void SetTimeOut()
        {
            attendanceProcessor.SetTimeOut(fullDetails.AttendanceInformation.ID, int.Parse(lblHoursOfWork.Text), estimate);
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

        private void FilterAttendance()
        {
            attendanceProcessor = new EmpAttendanceProcessor();
            var history = attendanceProcessor.FilterAttendanceLogs(DateTime.Parse(calendar.SelectionRange.Start.ToString("M/dd/yyyy")), employeeDetails.ID);

            if(history == null)
            {
                MessageBox.Show("Not Found");
            }
            else
            {
                lblHistoryTimeIn.Text = history.AttendanceInformation.TimeIn.ToString();
                lblHistoryAttendance.Text = history.AttendanceInformation.AttendanceStatus;
                lblHistoryTimeOut.Text = history.AttendanceInformation.TimeOut.ToString();
                lblHistoryWorkHours.Text = history.AttendanceInformation.NumberOfWorkHours.ToString();
                lblHistoryPay.Text = HelperClass.CurrencyFormat(history.AttendanceInformation.EstimatedPay);
                lblHistoryDate.Text = history.AttendanceInformation.AttendanceDate.ToString("M/dd/yyyy");
                lblHistoryLate.Text = history.AttendanceInformation.MinutesLate.ToString();
                lblOvertime.Text = history.AttendanceInformation.Overtime.ToString();
            }  
        }
        
        private List<Payroll> GetPayrollLogs()
        {
            var payroll = new List<Payroll>();

            try
            {
                payroll = payProcessor.GetPayrollStatusLogs($"where Employee.EmployeeID = {employeeDetails.ID}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return payroll;
        }

        private void LoadPayrollLogs()
        {
            listPayrollLogs.Items.Clear();
            foreach (var employee in GetPayrollLogs())
            {
                ListViewItem lv = new ListViewItem();
                lv = listPayrollLogs.Items.Add(employee.PayrollID.ToString());
                lv.SubItems.Add(employee.DateProcessed.ToString("MM/dd/yyyy"));
            }
        }

        private void timeDate_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("D");
            lblTime.Text = DateTime.Now.ToString("T");

            numberOfHours = DateTime.Now.Hour - this.fullDetails.AttendanceInformation.TimeIn.Hours;
            estimate = numberOfHours * fullDetails.Job.SalaryPerHour;

            lblHoursOfWork.Text = numberOfHours.ToString();
            lblEstimatedPay.Text = HelperClass.CurrencyFormat(estimate);

            Greetings();
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult question = MessageBox.Show("Are you sure you want to logout?\n" +
                "Note: By Logging out, it will be served as your time out.", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (question == DialogResult.Yes)
            {
                SetTimeOut();
                this.Dispose();
                this.Close();
            }
        }

        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (calendar.SelectionRange.Start.Date.ToString("M/dd/yyyy") == DateTime.Now.ToString("M/dd/yyyy"))
            {
                MessageBox.Show("Today's Attendance Information is still processing until the end of the work hours", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FilterAttendance();
            }
        }

        private void listPayrollLogs_Click(object sender, EventArgs e)
        {
            var payrollInfo = payProcessor.PayrollHistory("where Employee.EmployeeID = " + employeeDetails.ID);

            lblDateProcessed.Text = "Date Processed: " + payrollInfo.DateProcessed.ToString("MM/dd/yyyy");
            lblProcessedBy.Text = "Processed By: " + payrollInfo.ProccesedBy.LastName + ", " + payrollInfo.ProccesedBy.FirstName;

            lblEmpID.Text = payrollInfo.EmpInformation.ID.ToString();
            lblEmpName.Text = payrollInfo.EmpInformation.LastName + ", " + payrollInfo.EmpInformation.FirstName;
            lblJobPosition.Text = payrollInfo.EmpInformation.Job.JobName;
            lblMonthlySalary.Text = HelperClass.CurrencyFormat(payrollInfo.EmpInformation.Job.MonthlySalary);
            lblPayrollHourlyRate.Text = HelperClass.CurrencyFormat(payrollInfo.EmpInformation.Job.SalaryPerHour);
            lblPayrollWorkhours.Text = payrollInfo.EmpInformation.AttendanceInformation.NumberOfWorkHours.ToString();
            lblPayrollOvertime.Text= payrollInfo.EmpInformation.AttendanceInformation.Overtime.ToString();
            lblPayrollLateAmount.Text = HelperClass.CurrencyFormat(payrollInfo.TotalLateAmount);
            lblPayrollSSS.Text = HelperClass.CurrencyFormat(payrollInfo.SSS);
            lblPayrollPhilhealth.Text = HelperClass.CurrencyFormat(payrollInfo.PhilHealth);
            lblPayrollPagibig.Text = HelperClass.CurrencyFormat(payrollInfo.PagIBIG);
            lblPayrollTotalDeductions.Text = HelperClass.CurrencyFormat(payrollInfo.TotalDeductions);
            lblPayrollGrossPay.Text = HelperClass.CurrencyFormat(payrollInfo.GrossPay);
            lblPayrollNetPay.Text = HelperClass.CurrencyFormat(payrollInfo.NetPay);
        }
    }
}
