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

namespace PayrollManagementSystem.AdminUI
{
    public partial class Dashboard : MaterialForm
    {
        public Dashboard()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        }

        public void demo(string id)
        {
            AddEmployee addEmp = new AddEmployee(id);
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
                txtGreeting.Text = "Hello, Good Morning! Andrei"; 
            }
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 17)
            {
                txtGreeting.Text = "Hello, Good Afternoon! Andrei";
            }
            else if (DateTime.Now.Hour >= 17 && DateTime.Now.Hour < 12)
            {
                txtGreeting.Text = "Hello, Good Evening! Andrei";
            }
        }



        private void materialButton2_Click(object sender, EventArgs e)
        {
            ModifyEmployee modifyEmp = new ModifyEmployee(this);
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(modifyEmp);
        }
    }
}
