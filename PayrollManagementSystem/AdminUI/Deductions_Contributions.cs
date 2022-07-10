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

namespace PayrollManagementSystem.AdminUI
{
    public partial class Deductions_Contributions : MaterialForm
    {
        private Dashboard dashboard;
        private Payroll payrollModel;
        public Deductions_Contributions(Payroll pModel, Dashboard dashboard)
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue100, TextShade.WHITE);
            this.payrollModel = pModel;
            this.dashboard = dashboard;

            LoadSetDetails();
        }

        decimal netPay;
        private void LoadSetDetails()
        {
            LoadImage(payrollModel.EmpInformation.ID.ToString());
            lblEmployeeID.Text = payrollModel.EmpInformation.ID.ToString();
            lblEmployeeName.Text = $"{payrollModel.EmpInformation.LastName}, {payrollModel.EmpInformation.FirstName}";
            lblJobPosition.Tag = payrollModel.EmpInformation.Job.JobID;
            lblJobPosition.Text = payrollModel.EmpInformation.Job.JobName;
            lblSalary.Text = HelperClass.CurrencyFormat(payrollModel.EmpInformation.Job.MonthlySalary);
            lblLateAmount.Text = HelperClass.CurrencyFormat(payrollModel.TotalLateAmount);
            lblHourlyRate.Text = HelperClass.CurrencyFormat(payrollModel.EmpInformation.Job.SalaryPerHour);
            lblWorkhours.Text = payrollModel.EmpInformation.AttendanceInformation.NumberOfWorkHours.ToString() + " Hours";
            lblOvertime.Text = payrollModel.EmpInformation.AttendanceInformation.Overtime.ToString() + " Hours";

            var totalAmountWorkHours = payrollModel.EmpInformation.Job.SalaryPerHour * payrollModel.EmpInformation.AttendanceInformation.NumberOfWorkHours;

            lblAmountTotalWorkHours.Text = HelperClass.CurrencyFormat(totalAmountWorkHours);
            lblTotalOvertimeAmount.Text = HelperClass.CurrencyFormat(payrollModel.TotalOvertimeAmount);

            var totalPay = totalAmountWorkHours + payrollModel.TotalOvertimeAmount;
            lblTotalAmount.Text = HelperClass.CurrencyFormat(totalPay);

            PayrollDeductionProcessor payProcessor = new PayrollDeductionProcessor(payrollModel.EmpInformation.Job.MonthlySalary);

            var totalDeductions = payrollModel.TotalLateAmount + payProcessor.SSSContribution() + payProcessor.PhilhealthContribution() + payProcessor.PagIBIGContribution();

            lblTotalDeductions.Text = HelperClass.CurrencyFormat(totalDeductions);

            lblSSS.Text = HelperClass.CurrencyFormat(payProcessor.SSSContribution());
            lblPhilHealth.Text = HelperClass.CurrencyFormat(payProcessor.PhilhealthContribution());
            lblPagIBig.Text = HelperClass.CurrencyFormat(payProcessor.PagIBIGContribution());
            lblGrossPay.Text = HelperClass.CurrencyFormat(totalPay);

            netPay = totalPay - (payrollModel.TotalLateAmount + payProcessor.SSSContribution() + payProcessor.PhilhealthContribution() + payProcessor.PagIBIGContribution());

            lblNetPay.Text = HelperClass.CurrencyFormat(netPay);

            payrollModel.TotalWorkHoursAmount = totalAmountWorkHours;
            payrollModel.SSS = payProcessor.SSSContribution();
            payrollModel.PhilHealth = payProcessor.PhilhealthContribution();
            payrollModel.PagIBIG = payProcessor.PagIBIGContribution();
            payrollModel.TotalDeductions = totalDeductions;
            payrollModel.GrossPay = totalPay;
            payrollModel.NetPay = netPay;
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

        private void btnPay_Click(object sender, EventArgs e)
        {
            PayrollProcessor payProcessor = new PayrollProcessor();
            payProcessor.UploadPayroll(payrollModel);

            MessageBox.Show("Employee Paid!", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dashboard.Opacity = 1;
            this.Close();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            dashboard.Opacity = 1;
            this.Close();
        }
    }
}
