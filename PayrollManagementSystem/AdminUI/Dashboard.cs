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

namespace PayrollManagementSystem.AdminUI
{
    public partial class Dashboard : MaterialForm
    {
        private PayrollUser adminInformation; 
        public Dashboard()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey800, Primary.BlueGrey500, Accent.LightBlue100, TextShade.WHITE);
        }

        public Dashboard(PayrollUser user) : this()
        {
            adminInformation = user;
        }

        public void employeeModifier(Employee emp)
        {
            AddEmployee addEmp = new AddEmployee(emp);
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(addEmp);
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmp = new AddEmployee();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(addEmp);
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
        }
    }
}
