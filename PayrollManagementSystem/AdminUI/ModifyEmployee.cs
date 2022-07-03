using MaterialSkin;
using PayrollSystemLibrary.Interfaces;
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

namespace PayrollManagementSystem.AdminUI
{
    public partial class ModifyEmployee : UserControl
    {
        EmployeeProcessor empProcessor;
        Dashboard main;
        public ModifyEmployee(Dashboard main)
        {
            InitializeComponent();
            empProcessor = new EmployeeProcessor();

            this.main = main;

            ListViewData();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue100, TextShade.WHITE);
        }

        private void ListViewData()
        {
            foreach (var employee in Employees())
            {
                ListViewItem lv = new ListViewItem();
                lv = listEmployee.Items.Add(employee.ID.ToString());
                lv.SubItems.Add($"{ employee.LastName }, { employee.FirstName } { employee.MiddleName }");
            }
        }

        private List<IUser> Employees()
        {
            return empProcessor.GetUsers();
        }

        private Employee FilterEmployee()
        {
            int empID = int.Parse(listEmployee.SelectedItems[0].Text);
            return  (Employee) empProcessor.GetUserByID(empID);
        }

        private void listEmployee_Click(object sender, EventArgs e)
        {
            var employeeInformation = FilterEmployee();

            lblFirstName.Text = employeeInformation.FirstName;
            lblMiddleName.Text = employeeInformation.MiddleName;
            lblLastName.Text = employeeInformation.LastName;
            lblGender.Text = employeeInformation.Gender;
            lblEmail.Text = employeeInformation.EmailAddress;
            lblContact.Text = employeeInformation.ContactNumber;
            lblStreetNumber.Text = employeeInformation.StreetAddress;
            lblCity.Text = employeeInformation.City;
            lblDOB.Text = employeeInformation.DateOfBirth;
            lblDateHired.Text = employeeInformation.DateOfApply;
            lblJob.Text = employeeInformation.Job.JobName;
            lblSalary.Text = employeeInformation.Job.MonthlySalary.ToString();
            lblHourlyPay.Text = employeeInformation.Job.SalaryPerHour.ToString();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
           var question = MessageBox.Show("Are you sure you want to modify employee's details?", "Modify Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (question == DialogResult.Yes)
            {
                main.employeeModifier(FilterEmployee());
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
