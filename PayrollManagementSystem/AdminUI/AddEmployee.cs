using PayrollSystemLibrary.Interfaces;
using PayrollSystemLibrary.Logic;
using PayrollSystemLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollManagementSystem.AdminUI
{
    public partial class AddEmployee : UserControl
    {
        public AddEmployee()
        {
            InitializeComponent();

            ShowJobs();
            cmbJobPosition.SelectedItem = null;
        }

        public AddEmployee(Employee employee) : this()
        {
            btnGenerateID.Enabled = false;
            linkAccountGenerator.Enabled = false;

            txtID.Text = employee.ID.ToString();
            txtFirstName.Text = employee.FirstName;
            txtMiddleName.Text = employee.MiddleName;
            txtLastName.Text = employee.LastName;
            dateOfBirth.Text = employee.DateOfBirth;
            txtStreet.Text = employee.StreetAddress;
            txtCity.Text = employee.City;
            txtEmail.Text = employee.EmailAddress;
            txtContactNumber.Text = employee.ContactNumber;
            cmbJobPosition.Text = employee.Job.JobName;
            lblJobID.Text = employee.Job.JobID.ToString();
            lblMonthlySalary.Text = employee.Job.MonthlySalary.ToString();
            lblUserName.Text = employee.Username;
            lblPassword.Text = "*******";
        }

        private void ResetControls()
        {
            foreach (var textbox in basicInformation.Controls.OfType<MaterialSkin.Controls.MaterialTextBox>().ToList())
            {
                textbox.Clear();
            }

            foreach (MaterialSkin.Controls.MaterialTextBox textbox in contactInformation.Controls)
            {
                textbox.Clear();
            }

            radFemale.Checked = false;
            radMale.Checked = false;
            dateOfBirth.Value = DateTime.Now;
            lblUserName.Text = "Username";
            lblPassword.Text = "Password";
        }

        private void btnGenerateID_Click(object sender, EventArgs e)
        {
            this.txtID.Text = HelperClass.GenerateID().ToString();
            lblPassword.Text = HelperClass.GenerateID().ToString();
        }

        private void ShowJobs()
        {
            JobsProcessor jobProcessor = new JobsProcessor();
            var jobs = jobProcessor.Jobs();

            cmbJobPosition.DisplayMember = "JobName";
            cmbJobPosition.DataSource = jobs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblUserName.Text == "Username")
            {
                ErrorProvider provider = new ErrorProvider();
                provider.SetError(linkAccountGenerator, "Please provide a username before saving.");
            }
            else
            {
                Employee user = new Employee
                {
                    ID = int.Parse(txtID.Text),
                    FirstName = txtFirstName.Text,
                    MiddleName = txtMiddleName.Text,
                    LastName = txtLastName.Text,
                    Gender = (radMale.Checked == true) ? "Male" : "Female",
                    EmailAddress = txtEmail.Text,
                    ContactNumber = txtContactNumber.Text,
                    StreetAddress = txtStreet.Text,
                    City = txtCity.Text,
                    DateOfBirth = dateOfBirth.Text,
                    DateOfApply = DateTime.Now.ToString("d"),
                    Username = lblUserName.Text,
                    Password = lblPassword.Text,
                    Job = new JobPositions
                    {
                        JobID = int.Parse(lblJobID.Text),
                    }
                };

                IUserProcessor empProcessor = new EmployeeProcessor();
                empProcessor.Add(user);
                MessageBox.Show("Employee Information Saved", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetControls();
            }
        }

        private void linkAccountGenerator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txtFirstName.Text == "" && txtLastName.Text == "")
            {
                ErrorProvider provider = new ErrorProvider();
                provider.SetError(linkAccountGenerator, "Please first input first name and last name.");
            }
            else
            {
                lblUserName.Text = HelperClass.UsernameGenerator(txtFirstName.Text, txtLastName.Text);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                FileName = txtID.Text,
                Filter = "JPG Files(*.jpg)|*jpg|PNG Files(*.png)|*.png|JPEG Files(*.jpeg)|*.jpeg"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                employeeImage.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void cmbJobPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJobPosition.Text != cmbJobPosition.Hint)
            {
                JobsProcessor jobProcessor = new JobsProcessor();
                var jobInfo = jobProcessor.FilterJob(cmbJobPosition.Text.ToString());

                lblJobID.Text = jobInfo.JobID.ToString();
                lblMonthlySalary.Text = jobInfo.MonthlySalary.ToString("C", CultureInfo.GetCultureInfo("en-ph"));
                lblHireDate.Text = DateTime.Now.ToShortDateString();                
            }
        }
    }
}
