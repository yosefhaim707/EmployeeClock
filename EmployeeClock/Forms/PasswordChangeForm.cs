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
    public partial class PasswordChangeForm : Form
    {
        private EmployeeService _employeeService;
        public PasswordChangeForm()
        { 
            _employeeService = new EmployeeService();
            InitializeComponent();
        }

        private void linkLabel_Cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationService.ShowForm(FormNames.PasswordChangeForm, "");
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (IsFull())
            {
                MessageBox.Show("Not All Fields Are Full");
            }
            else if (!IsNewPasswordConfirm())
            {
                MessageBox.Show("The new password confirm doesn't match");
            }
            else if (!_employeeService.ValidateOldPassword(textBox_ID.Text, textBox_OldPassword.Text))
            {
                MessageBox.Show("Some Details Are Not Valid");
            }
            else
            {
                _employeeService.ReplacePassword(textBox_ID.Text, textBox_OldPassword.Text, textBox_NewPassword.Text)
            }
        }

        private bool IsFull()
        {
            bool isFull = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        isFull = false;
                        break;
                    }
                }
            }
            return isFull;
        }

        private bool IsNewPasswordConfirm()
        {
            if (textBox_NewPassword.Text == textBox_ConfirmNewPassword.Text)
            {
                return true;
            }
            return false;
        }
    }
}
