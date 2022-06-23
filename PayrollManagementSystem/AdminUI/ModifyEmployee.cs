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
        public class Demo
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }


        public ModifyEmployee()
        {
            InitializeComponent();
            List<Demo> list = new List<Demo>();
            list.Add(new Demo { ID = 9123, Name = "Andrei Solero", Department = "Maganaer" });
            list.Add(new Demo { ID = 15123, Name = "Kaeceline Solero", Department = "Supervisor" });
            list.Add(new Demo { ID = 5125, Name = "Francis Solero", Department = "Janitor" });

            ListViewItem item = new ListViewItem();

            foreach (var emp in list)
            {
                item = materialListView1.Items.Add(emp.ID.ToString());
                item.SubItems.Add(emp.Name.ToString());
                item.SubItems.Add(emp.Department.ToString());
            }
        }

        Dashboard main;
        public ModifyEmployee(Dashboard main)
        {
            InitializeComponent();
            List<Demo> list = new List<Demo>();
            list.Add(new Demo { ID = 9123, Name = "Andrei Solero", Department = "Maganaer" });
            list.Add(new Demo { ID = 15123, Name = "Kaeceline Solero", Department = "Supervisor" });
            list.Add(new Demo { ID = 5125, Name = "Francis Solero", Department = "Janitor" });

            ListViewItem item = new ListViewItem();

            foreach (var emp in list)
            {
                item = materialListView1.Items.Add(emp.ID.ToString());
                item.SubItems.Add(emp.Name.ToString());
                item.SubItems.Add(emp.Department.ToString());
            }

            this.main = main;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            main.demo("12345");
        }
    }
}
