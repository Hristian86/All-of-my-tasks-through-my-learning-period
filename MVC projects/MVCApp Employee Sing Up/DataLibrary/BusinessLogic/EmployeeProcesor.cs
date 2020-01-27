using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;
using DataLibrary.DataAccess;

namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcesor
    {
        public static int Counter(int counters)
        {
            int count = counters;
            return count;
        }
        public static int CreateEmployee(string firstName, string lastName, string emailAddress)
        {
            var entri = LoadEmployees().ToList();

            EmployeeModel data = new EmployeeModel
            {
                FirstName = firstName,
                Lastname = lastName,
                EmailAddress = emailAddress
            };

            string sql = @"insert into dbo.Employee (FirstName,LastName,EmailAddress) values (@FirstName,@LastName,@EmailAddress);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select Id,FirstName,LastName,EmailAddress from dbo.Employee;";
            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}