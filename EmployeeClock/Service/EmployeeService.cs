using EmployeeClock.Dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock.Service
{
    internal class EmployeeService : IEmployeeService
    {
        public string? GetEmployeeCode(string employeeNat)
        {
            DBContext dbContext = new DBContext();
            string query = $"SELECT EmployeeCode FROM EmployeeAttendance JOIN Employees ON EmployeeAttendance.EmployeeCode = Employees.ID WHERE EmployeeNat = {employeeNat} GROUP BY EmployeeCode;";
            DataTable queryResult = dbContext.MakeSelectQuery(query);
            return queryResult.Rows[0]["EmployeeCode"].ToString();
        }

        public string? GetLastEntry(string employeeNat)
        {
            DBContext dbContext = new DBContext();
            string query = $"SELECT * FROM EmployeeAttendance WHERE EntryTime = (SELECT MAX(EntryTime) FROM EmployeeAttendance JOIN Employees ON EmployeeAttendance.EmployeeCode = Employees.ID WHERE EmployeeNat = {employeeNat});";
            DataTable queryResult = dbContext.MakeSelectQuery(query);
            if (queryResult.Rows.Count == 1)
            {
                return queryResult.Rows[0]["EntryTime"].ToString();
            }
            else
            {
                return null;
            }
        }

        public string? GetLastExit(string employeeNat)
        {
            DBContext dbContext = new DBContext();
            string query = $"SELECT * FROM EmployeeAttendance WHERE EntryTime = (SELECT MAX(EntryTime) FROM EmployeeAttendance JOIN Employees ON EmployeeAttendance.EmployeeCode = Employees.ID WHERE EmployeeNat = {employeeNat});";
            DataTable queryResult = dbContext.MakeSelectQuery(query);
            if (queryResult.Rows.Count == 1)
            {
                return queryResult.Rows[0]["ExitTime"].ToString();
            }
            else
            {
                return null;
            }
        }

        public bool InsertEntry(string employeeNat)
        {
            string? employeeCode = GetEmployeeCode(employeeNat);
            DBContext dbContext = new DBContext();
            
            string query = $"INSERT INTO EmployeeAttendance (EmployeeCode, EntryTime) VALUES ({employeeCode}, GETDATE());";
            int res = dbContext.MakeNonQuery(query);
            if (res == 0)
            {
                return false;
            }
            return true;
            
        }

        public bool InsertExit(string employeeNat)
        {
            string? employeeCode = GetEmployeeCode(employeeNat);
            DBContext dbContext = new DBContext();
            string query = $"UPDATE EmployeeAttendance SET ExitTime = GETDATE() WHERE EmployeeCode = {employeeCode} AND EntryTime = (SELECT MAX(EntryTime) FROM EmployeeAttendance WHERE EmployeeCode = {employeeCode});";
            int res = dbContext.MakeNonQuery(query);
            if(res == 0)
            {
                return false;
            }
            return true;
        }

        public bool ReplacePassword(string employeeNat, string oldPassword, string newPassword)
        {
            DBContext dBContext = new DBContext();
            string query = @$"DECLARE @employeeNat VARCHAR(50) = '{employeeNat}';
                                DECLARE @oldPassword VARCHAR(50) = '{oldPassword}';
                                DECLARE @newPassword VARCHAR(50) = '{newPassword}';
                                BEGIN TRANSACTION
                                    IF EXISTS (SELECT * FROM  Passwords p JOIN Employees e ON e.ID = p.EmployeeID WHERE e.EmployeeNat = @employeeNat AND p.EmployeePassword = @oldPassword)
                                    BEGIN
                                        UPDATE Passwords
                                        SET IsActive = 0
                                        WHERE EmployeeID = (SELECT ID FROM Employees WHERE EmployeeNat = @employeeNat)
                                        INSERT INTO Passwords (EmployeeID, EmployeePassword, IsActive)
                                        VALUES ((SELECT ID FROM Employees WHERE EmployeeNat = @employeeNat), @newPassword, 1)
                                    END
                                    ELSE
                                    BEGIN
                                        RAISERROR ('Old password is incorrect', 16, 1)
                                        ROLLBACK TRANSACTION
                                    END
                                COMMIT TRANSACTION";
            int res = dBContext.MakeNonQuery(query);
            if (res == 0)
            {
                return false;
            }
            return true;
        }

        public bool ValidateEmployee(string employeeNat, string password)
        {
            DBContext dbContext = new DBContext();
            string query = $"SELECT EmployeeNat, EmployeePassword, ExpiryDate FROM Employees JOIN Passwords ON Employees.ID = Passwords.EmployeeID WHERE EmployeeNat = '{employeeNat}' AND EmployeePassword = '{password}' AND IsActive = 1;";
            DataTable result = dbContext.MakeSelectQuery(query);
            DateTime expiryDate = (DateTime)result.Rows[0][2];
            if (result.Rows.Count == 1)
            {
                if(expiryDate < DateTime.Now)
                {
                    return false ;
                }
                else
                {
                    return true ;
                }
            }
            return false ;
        }

        public bool ValidateOldPassword(string employeeNat, string password)
        {
            DBContext dbContext = new DBContext();
            string query = $"SELECT EmployeeNat, EmployeePassword, FROM Employees JOIN Passwords ON Employees.ID = Passwords.EmployeeID WHERE EmployeeNat = '{employeeNat}' AND EmployeePassword = '{password}' AND IsActive = 1;";
            DataTable result = dbContext.MakeSelectQuery(query);
            if (result.Rows.Count == 1)
            {
                return true;
            }
            return false ;
        }
    }
}
