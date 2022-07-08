using MaterialSkin.Controls;
using MaterialSkin;
using Transitions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayrollSystemLibrary.Models;
using PayrollSystemLibrary.Logic;

namespace PayrollManagementSystem.AdminUI
{
    public partial class Dashboard : MaterialForm
    {
        private PayrollUser adminInformation; 
        private EmpAttendanceProcessor attendanceProcessor;
        private EmployeeProcessor empProcessor;
        public Dashboard()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue100, TextShade.WHITE);

            attendanceProcessor = new EmpAttendanceProcessor();
            empProcessor = new EmployeeProcessor();

            lblMonitoringDate.Text = lblMonitoringDate.Text + DateTime.Now.ToLongDateString();
        }

        public Dashboard(PayrollUser user) : this()
        {
            adminInformation = user;

            LoadTimeKeepingDetails();
            LoadPayrollDetails();
        }

        public void employeeModifier(Employee emp)
        {
            AddEmployee addEmp = new AddEmployee(emp, "Modify Existing Employee", "Modify some informations that are requested");

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(addEmp);
        }

        private void LoadTimeKeepingDetails()
        {
            var attendance =  attendanceProcessor.GetAllEmployeeAttendance();
            
            listAttendance.Items.Clear();
            foreach (var data in attendance)
            {
                ListViewItem lv = new ListViewItem();
                lv = listAttendance.Items.Add($"{data.LastName}, {data.FirstName}");
                lv.SubItems.Add(data.AttendanceInformation.TimeIn.ToString());
                lv.SubItems.Add(data.AttendanceInformation.TimeOut.ToString());
                lv.SubItems.Add(data.AttendanceInformation.AttendanceStatus.ToString());
            }

            foreach (ListViewItem item in listAttendance.Items)
            {
                if (item.SubItems[3].Text == "Late")
                {
                    item.BackColor = Color.Red;
                    item.ForeColor = Color.White;
                }
                else
                {
                    item.BackColor = Color.LightGreen;
                    item.ForeColor = Color.White;
                }
            }
        }

        private void LoadPayrollDetails()
        {
            foreach(var employee in empProcessor.GetUsers())
                {
                ListViewItem lv = new ListViewItem();
                lv = listPayrollEmployee.Items.Add(employee.ID.ToString());
                lv.SubItems.Add($"{ employee.LastName }, { employee.FirstName } { employee.MiddleName }");
            }
        }

        private Employee FilterPayrollDetails()
        {
            int empID = int.Parse(listPayrollEmployee.SelectedItems[0].Text);
            return (Employee) attendanceProcessor.ComputeWorkingHours(empID);
        }

        private Employee FilterEmployee()
        {
            int empID = int.Parse(listPayrollEmployee.SelectedItems[0].Text);
            return (Employee)empProcessor.GetUserByID(empID);
        }

        private decimal ComputeLateDeduction(decimal hourlyRate, int totalMinutesLate)
        {
            return (hourlyRate / 60) * totalMinutesLate;
        }

        private decimal ComputeOvertime(decimal hourlyRate, int overtimeMinutes)
        {
            return (hourlyRate * 1.25M) * overtimeMinutes;
        }

        private void LoadImage(string id)
        {
            try
            {
                employeeImage.Image = Image.FromFile(HelperClass.LoadImage(id));
            }
            catch (Exception)
            {
                employeeImage.Image = Image.FromFile(HelperClass.LoadImage("no-image"));
            }
        }

        private Payroll SetPayrollInformation()
        {
            var empInfo = FilterEmployee();
            var emplAttendanceInfo = FilterPayrollDetails();

            decimal lateAmount = ComputeLateDeduction(empInfo.Job.SalaryPerHour, emplAttendanceInfo.AttendanceInformation.MinutesLate);
            decimal overtimeAmount = ComputeOvertime(empInfo.Job.SalaryPerHour, emplAttendanceInfo.AttendanceInformation.Overtime);

            Payroll payroll = new Payroll
            {
                EmpInformation = new Employee
                {
                    ID = int.Parse(listPayrollEmployee.SelectedItems[0].Text),
                    FirstName = empInfo.FirstName,
                    LastName = empInfo.LastName,
                    Job = new JobPositions
                    {
                        JobID = empInfo.Job.JobID,
                        JobName = empInfo.Job.JobName,
                        SalaryPerHour = empInfo.Job.SalaryPerHour,
                        MonthlySalary = empInfo.Job.MonthlySalary
                    },
                    AttendanceInformation = new Attendance
                    {
                        NumberOfWorkHours = emplAttendanceInfo.AttendanceInformation.NumberOfWorkHours,
                        Overtime = emplAttendanceInfo.AttendanceInformation.Overtime
                    }
                },

                ProccesedBy = new PayrollUser
                {
                    ID = adminInformation.ID,
                    FirstName = adminInformation.FirstName,
                    LastName = adminInformation.LastName,
                }, 

                TotalLateAmount = lateAmount,
                TotalOvertimeAmount = overtimeAmount
            };

            return payroll;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmp = new AddEmployee();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(addEmp);

            btnAddEmployee.Enabled = false;
            btnModifyEmployee.Enabled = true;
        }

        private void dateTime_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();            

            if (DateTime.Now.Hour <= 12 && DateTime.Now.Hour > 0)
            {
                txtGreeting.Text = $"Hello, Good Morning! {adminInformation.FirstName} {adminInformation.LastName}"; 
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 17)
            {
                txtGreeting.Text = $"Hello, Good Afternoon! {adminInformation.FirstName} {adminInformation.LastName}";
            }
            else if (DateTime.Now.Hour >= 17 && DateTime.Now.Hour < 24)
            {
                txtGreeting.Text = $"Hello, Good Evening! {adminInformation.FirstName} {adminInformation.LastName}";
            }
        }

        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            ModifyEmployee modifyEmp = new ModifyEmployee(this);
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(modifyEmp);

            btnAddEmployee.Enabled = true;
            btnModifyEmployee.Enabled = false;
        }

        private void timeKeepingRefresher_Tick(object sender, EventArgs e)
        {
            LoadTimeKeepingDetails();
        }

        private void listPayrollEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var empInfo = FilterEmployee();
                lblPayrollEmail.Text = empInfo.EmailAddress.ToString();
                lblPContactNumber.Text = empInfo.ContactNumber.ToString();
                lblPayrollJobPosition.Text = empInfo.Job.JobName.ToString();
                lblPayrollSalary.Text = HelperClass.CurrencyFormat(empInfo.Job.MonthlySalary);
                lblPayrollHourlyRate.Text = HelperClass.CurrencyFormat(empInfo.Job.SalaryPerHour);

                LoadImage(empInfo.ID.ToString());

                var emplAttendanceInfo = FilterPayrollDetails();
                lblPayrollWorkHours.Text = emplAttendanceInfo.AttendanceInformation.NumberOfWorkHours.ToString() + " Hours";
                lblPayrollOvertime.Text = emplAttendanceInfo.AttendanceInformation.Overtime.ToString() + " Hours";
                lblPayrollMinutesLate.Text = emplAttendanceInfo.AttendanceInformation.MinutesLate.ToString() + " Minutes";


                decimal deduction = ComputeLateDeduction(empInfo.Job.SalaryPerHour, emplAttendanceInfo.AttendanceInformation.MinutesLate);
                lblLateDeduction.Text = HelperClass.CurrencyFormat(deduction);

                decimal overtimeBonus = ComputeOvertime(empInfo.Job.SalaryPerHour, emplAttendanceInfo.AttendanceInformation.Overtime);
                txtOvertimePay.Text = HelperClass.CurrencyFormat(overtimeBonus);                
            }
            catch (Exception)
            {
                lblPayrollWorkHours.Text = "0 Hours";
                lblPayrollOvertime.Text = "0 Hours";
                lblPayrollMinutesLate.Text = "0 Minutes";

                lblLateDeduction.Text = HelperClass.CurrencyFormat(0);
                txtOvertimePay.Text = HelperClass.CurrencyFormat(0);
            }
        }

        private void btnDeductions_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.2;
            Deductions_Contributions deductions = new Deductions_Contributions(SetPayrollInformation(), this);
            deductions.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
