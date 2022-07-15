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
        private PayrollProcessor payProcessor;
        public Dashboard()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue100, TextShade.WHITE);

            attendanceProcessor = new EmpAttendanceProcessor();
            empProcessor = new EmployeeProcessor();
            payProcessor = new PayrollProcessor();
        }

        public Dashboard(PayrollUser user) : this()
        {
            adminInformation = user;

            LoadTimeKeepingDetails("");
            LoadPayrollDetails();
            LoadPayrollLogs();
        }

        public void employeeModifier(Employee emp)
        {
            AddEmployee addEmp = new AddEmployee(emp, "Modify Existing Employee", "Modify some informations that are requested");

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(addEmp);
        }

        private void LoadTimeKeepingDetails(string condition)
        {
            var attendance =  attendanceProcessor.GetAllEmployeeAttendance(condition);
            
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

        private List<Payroll> PayrollDetails()
        {
            return payProcessor.GetPayrollList("");
        }

        private void LoadPayrollDetails()
        {
            listPayrollEmployee.Items.Clear();
            foreach(var employee in PayrollDetails())
            {
                ListViewItem lv = new ListViewItem();
                lv = listPayrollEmployee.Items.Add(employee.EmpInformation.ID.ToString());
                lv.SubItems.Add($"{ employee.EmpInformation.LastName }, { employee.EmpInformation.FirstName } { employee.EmpInformation.MiddleName }");
            }
        }

        private Payroll FilterPayrollValidation()
        {
            int empID = int.Parse(lblSelectedEmployee.Text);
            return payProcessor.FilterPayroll(empID, "");
        }

        private Employee FilterPayrollDetails()
        {
            int empID = int.Parse(lblSelectedEmployee.Text);
            return (Employee) attendanceProcessor.ComputeWorkingHours(empID);
        }

        private Employee FilterEmployee()
        {
            int empID = int.Parse(lblSelectedEmployee.Text);
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
                    ID = int.Parse(lblSelectedEmployee.Text),
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

        private List<Payroll> GetPayrollLogs()
        {
            var payroll = new List<Payroll>();

            try
            {
                payroll = payProcessor.GetPayrollStatusLogs($"");
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
            var list = GetPayrollLogs();
            foreach (var employee in list)
            {
                ListViewItem lv = new ListViewItem();
                lv = listPayrollLogs.Items.Add(employee.PayrollID.ToString());
                lv.SubItems.Add($"{employee.ProccesedBy.LastName}, {employee.ProccesedBy.FirstName}");
                lv.SubItems.Add($"{employee.EmpInformation.LastName}, {employee.EmpInformation.FirstName}");
            }
        }

        private bool PayrollValidation()
        {
            bool isEnabled;
            if (DateTime.Now.Day == 15)
            {
                isEnabled = true;
            }
            else if (DateTime.Now.Day == 30)
            {
                isEnabled = true;
            }
            else if (DateTime.Now.Month == 2 && DateTime.Now.Day == 29)
            {
                isEnabled = true;
            }
            else
            {
                isEnabled = false;
            }

            return isEnabled;
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
            //payrollPanel.Enabled = PayrollValidation();
            //lblNote.Visible = !PayrollValidation();

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
            lblMonitoringDate.Text = DateTime.Now.ToLongDateString();
            LoadTimeKeepingDetails("");
            LoadPayrollDetails();
        }

        private int workingHours = 0;
        private void listPayrollEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                lblSelectedEmployee.Text = listPayrollEmployee.SelectedItems[0].Text;
                var empInfo = FilterPayrollValidation();
                LoadImage(lblSelectedEmployee.Text);

                lblPayrollEmail.Text = empInfo.EmpInformation.EmailAddress.ToString();
                lblPContactNumber.Text = empInfo.EmpInformation.ContactNumber.ToString();
                lblPayrollJobPosition.Text = empInfo.EmpInformation.Job.JobName.ToString();
                lblPayrollSalary.Text = HelperClass.CurrencyFormat(empInfo.EmpInformation.Job.MonthlySalary);
                lblPayrollHourlyRate.Text = HelperClass.CurrencyFormat(empInfo.EmpInformation.Job.SalaryPerHour);

                var emplAttendanceInfo = FilterPayrollDetails();
                lblPayrollWorkHours.Text = emplAttendanceInfo.AttendanceInformation.NumberOfWorkHours.ToString() + " Hours";
                workingHours = emplAttendanceInfo.AttendanceInformation.NumberOfWorkHours;
                lblPayrollOvertime.Text = emplAttendanceInfo.AttendanceInformation.Overtime.ToString() + " Hours";
                lblPayrollMinutesLate.Text = emplAttendanceInfo.AttendanceInformation.MinutesLate.ToString() + " Minutes";


                decimal deduction = ComputeLateDeduction(empInfo.EmpInformation.Job.SalaryPerHour, emplAttendanceInfo.AttendanceInformation.MinutesLate);
                lblLateDeduction.Text = HelperClass.CurrencyFormat(deduction);

                decimal overtimeBonus = ComputeOvertime(empInfo.EmpInformation.Job.SalaryPerHour, emplAttendanceInfo.AttendanceInformation.Overtime);
                txtOvertimePay.Text = HelperClass.CurrencyFormat(overtimeBonus);

            }
            catch (Exception exe)
            {
                lblPayrollWorkHours.Text = "0 Hours";
                lblPayrollOvertime.Text = "0 Hours";
                lblPayrollMinutesLate.Text = "0 Minutes";

                lblLateDeduction.Text = HelperClass.CurrencyFormat(0);
                txtOvertimePay.Text = HelperClass.CurrencyFormat(0);

                MessageBox.Show(exe.Message);
            }
        }

        private void btnDeductions_Click(object sender, EventArgs e)
        {
            var empInfo = FilterPayrollValidation();
            if (empInfo.PayrollStatus == "Paid")
            {
                MessageBox.Show("Employee is alread paid.", "Unable to pay", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(workingHours < 20)
            {
                MessageBox.Show("Employee cannot be paid due to insufficient Working hours rendered." +
                    "\nRequired Working hours: 20+", "Unable to pay", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.Opacity = 0.2;
                Deductions_Contributions deductions = new Deductions_Contributions(SetPayrollInformation(), this);
                deductions.ShowDialog();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();

            btnAddEmployee.Enabled = true;
            btnModifyEmployee.Enabled = true;
        }

        private void radLate_CheckedChanged(object sender, EventArgs e)
        {
            LoadTimeKeepingDetails("and AttendanceStatus = 'Late'");
            timeKeepingRefresher.Enabled = false;
        }

        private void radOntime_CheckedChanged(object sender, EventArgs e)
        {
            LoadTimeKeepingDetails("and AttendanceStatus = 'Present'");
            timeKeepingRefresher.Enabled = false;
        }

        private void btnResetAttendance_Click(object sender, EventArgs e)
        {
            LoadTimeKeepingDetails("");
            timeKeepingRefresher.Enabled = true;
            radLate.Checked = false;
            radOntime.Checked = false;
        }

        private void listPayrollLogs_Click(object sender, EventArgs e)
        {
            var payrollInfo = payProcessor.PayrollHistory("where PayrollLogs.PayrollID = " + listPayrollLogs.SelectedItems[0].Text);

            lblPayWorkHours.Text = payrollInfo.EmpInformation.AttendanceInformation.NumberOfWorkHours.ToString() + " Hours";
            lblPayHistoryLate.Text = payrollInfo.EmpInformation.AttendanceInformation.MinutesLate.ToString() + " Minutes";
            lblPayOvertime.Text = payrollInfo.EmpInformation.AttendanceInformation.Overtime.ToString() + " Hours";
            lblPayLateAmountDeduction.Text = HelperClass.CurrencyFormat(payrollInfo.TotalLateAmount);
            lblPayAmountWorkHours.Text = HelperClass.CurrencyFormat(payrollInfo.TotalWorkHoursAmount);
            lblPayAmountOvertime.Text = HelperClass.CurrencyFormat(payrollInfo.TotalOvertimeAmount);
            lblPaySSS.Text = HelperClass.CurrencyFormat(payrollInfo.SSS);
            lblPayPhilhealth.Text = HelperClass.CurrencyFormat(payrollInfo.PhilHealth);
            lblPayPagibig.Text = HelperClass.CurrencyFormat(payrollInfo.PagIBIG);
            lblPayDeductions.Text = HelperClass.CurrencyFormat(payrollInfo.TotalDeductions);
            lblPayGrosspay.Text = HelperClass.CurrencyFormat(payrollInfo.GrossPay);
            lblPayNetPay.Text = HelperClass.CurrencyFormat(payrollInfo.NetPay);
            lblPayDateProcessed.Text = payrollInfo.DateProcessed.ToString("MM/dd/yyyy");

            
        }
    }
}
