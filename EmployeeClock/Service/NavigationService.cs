using EmployeeClock.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock.Service
{
    static class NavigationService
    {
        public static void CloseAllForms()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form form in openForms)
            {
                form.Close();
            }
        }
        public static void ShowForm(FormNames formName, string employeeNat)
        {
            CloseAllForms();
            Form form = formName switch
            {
                FormNames.LoginForm => new Loginform(),
                FormNames.PasswordChangeForm => new PasswordChangeForm(),
                FormNames.ClockForm => new ClockForm(employeeNat),
                _ => throw new ArgumentException("Invalid Form Name", nameof(formName))
            };
            form.Show();
        }

        public static void HandleCloseFormEvent(object sender, FormClosingEventArgs e, bool isNavigating)
        {
            if (!isNavigating && e.CloseReason == CloseReason.UserClosing)
            {
                string confirmExitQuestion = "Are you sure you want to exit?";
                string confirmExitTitle = "Confirm exit";
                DialogResult dialogResult = MessageBox.Show(confirmExitQuestion, confirmExitTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                    return;
                }
                e.Cancel = true;
            }
        }
    }
}
