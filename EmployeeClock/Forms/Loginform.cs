using EmployeeClock.Dal;
using EmployeeClock.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClock.Forms
{
    public partial class Loginform : Form
    {
        private EmployeeService _employeeService;
        
        public Loginform()
        {
            _employeeService = new EmployeeService();
            InitializeComponent();
        }

        private void button1_Enter_Click(object sender, EventArgs e)
        {
            string emloyeeNat = textBox_Nat.Text;
            string password = textBox_Password.Text;
            if (string.IsNullOrEmpty(emloyeeNat) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                bool isValid = _employeeService.ValidateEmployee(emloyeeNat, password);
                if (isValid)
                {
                    NavigationService.ShowForm(FormNames.ClockForm, emloyeeNat);
                }
                else
                {
                    MessageBox.Show("Invalid credentials");
                }
            }
        }

        private void button2_ChangePassword_Click(object sender, EventArgs e)
        {
            NavigationService.ShowForm(FormNames.PasswordChangeForm, textBox_Nat.Text);
        }
    }
}
