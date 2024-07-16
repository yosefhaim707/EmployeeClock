using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock.Service
{
    internal interface IEmployeeService
    {
        bool ValidateEmployee(string employeeNat, string password);
        string? GetLastEntry(string employeeNat);
        string? GetLastExit(string employeeNat);
        string? GetEmployeeCode(string employeeNat);
        bool InsertEntry(string employeeNat);
        bool InsertExit(string employeeNat);
        bool ValidateOldPassword(string employeeNat, string password);
        bool ReplacePassword(string employeeNat, string oldPassword, string newPassword);
    }
}
