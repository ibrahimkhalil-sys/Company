using sirketiscileri.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sirketiscileri
{
    public partial class Form1 : Form
    {
        List<Employees> employee = new List<Employees>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_name.Text = string.Empty;
            textBox_password.Text = string.Empty;
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            string username, password = "";
            username = textBox_name.Text;
            password = textBox_password.Text;

            bool control = false;

            foreach (Employees employees in employee)
            {
                if (username.ToLower() == employees.getUsername() && password.ToLower()== employees.getPassword()&&employees.getposition()=="manager")
                {
                    Manager manager = new Manager(employee);
                    manager.Show();
                    this.Hide();
                    control = true;
                    break;
                }
                else if (username.ToLower() == employees.getUsername() && password.ToLower() == employees.getPassword() && employees.getposition() == "staff")
                {
                    Staff staff = new Staff();
                    staff.Show();
                    this.Hide();
                    control = true;
                    break;
                }
               
            }
            if (!control)
            {
                MessageBox.Show("password or user name is invalid", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
        }
        //dubul
        private void Form1_Load(object sender, EventArgs e)
        {
            employee.Add(new Employees("musa", "zutov", 456788, "manager","musa","1"));
            employee.Add(new Employees("ibrahim", "osmanov", 1234567, "manager","ibo", "2"));
            employee.Add(new Employees("kamil", "hacilov", 675438, "staff","kamil", "3"));
            employee.Add(new Employees("huseyn", "semedli", 567893, "staff", "huseyn","4"));
            employee.Add(new Employees("abdul", "memmedli", 987654, "staff", "abdul","5"));
            employee.Add(new Employees("maykl", "oven", 456738, "staff", "maykl","6"));
            employee.Add(new Employees("suzuki", "yamanishi", 3546789, "staff","suzuki", "7"));
            employee.Add(new Employees("samir", "qafarov", 345786, "staff", "samir","8"));
            employee.Add(new Employees("azer", "zeynalov", 345787, "staff","azer", "9"));
           
            
        }
    }
}
