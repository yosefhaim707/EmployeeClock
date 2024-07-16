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
    public partial class ClockForm : Form
    {
        private string _employeeNat;
        private EmployeeService _employeeService;
        public ClockForm(string employeeNat)
        {
            _employeeNat = employeeNat;
            _employeeService = new EmployeeService();
            InitializeComponent();
            ClockForm_Load();
        }

        private void ClockForm_Load()
        {
            label_ID.Text = _employeeNat;
            string? lastEntry = _employeeService.GetLastEntry(_employeeNat);
            string? lastExit = _employeeService.GetLastExit(_employeeNat);
            if (lastEntry != null)
            {
                label_LastEntryDate.Text = lastEntry;
            }
            else
            {
                label_LastEntryDate.Text = "No Entries Yet";
            }
            if (lastExit != null)
            {
                label_LastExitDate.Text = lastExit;
            }
            else
            {
                label_LastExitDate.Text = "No Exits Yet";
            }
        }

        private void linkLabel_Cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationService.ShowForm(FormNames.LoginForm, _employeeNat);
        }

        private void button_Entry_Click(object sender, EventArgs e)
        {
            string? lastEntry = _employeeService.GetLastEntry(_employeeNat);
            string? lastExit = _employeeService.GetLastExit(_employeeNat);
            if (!string.IsNullOrEmpty(lastEntry) && string.IsNullOrEmpty(lastExit))
            {
                MessageBox.Show("You have already entered today");
            }
            else
            {
                bool inserted = _employeeService.InsertEntry(_employeeNat);
                if (inserted)
                {
                    MessageBox.Show("Entry Inserted Successfully");
                    ClockForm_Load();
                }
                else
                {
                    MessageBox.Show("Failed to insert entry");
                }
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            string? lastEntry = _employeeService.GetLastEntry(_employeeNat);
            string? lastExit = _employeeService.GetLastExit(_employeeNat);
            if (lastEntry == null)
            {
                MessageBox.Show("You have not entered yet");
            }
            else if (!string.IsNullOrEmpty(lastExit))
            {
                MessageBox.Show("You have already exited today");
            }
            else
            {
                bool inserted = _employeeService.InsertExit(_employeeNat);
                if (inserted)
                {
                    MessageBox.Show("Exit Inserted Successfully");
                    ClockForm_Load();
                }
                else
                {
                    MessageBox.Show("Failed to insert exit");
                }
            }
        }
    }
}
