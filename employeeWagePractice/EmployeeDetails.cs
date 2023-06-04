using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWagePractice
{
    interface ComputeEmpWage
    {
    void AddCompanyEmpWage(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours);
    void ComputeEmpWage();
    }
    internal class EmployeeDetails
    {
        public string CompanyName { get; }
        public int WagePerHour { get; }
        public int MaxWorkingDays { get; }
        public int MaxWorkingHours { get; }

        public EmployeeDetails(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            CompanyName = companyName;
            WagePerHour = wagePerHour;
            MaxWorkingDays = maxWorkingDays;
            MaxWorkingHours = maxWorkingHours;
        }

    }
}
