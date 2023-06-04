using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWagePractice
{
    internal class EmployeeWageBuilder
    {

        private EmployeeDetails[] companyEmpWages;
        private int numOfCompanies;

        public EmployeeWageBuilder()
        {
            companyEmpWages = new EmployeeDetails[5];
            numOfCompanies = 0;
        }

        public void AddCompanyEmpWage(string companyName, int wagePerHour, int maxWorkingDays, int maxWorkingHours)
        {
            if (numOfCompanies < 5)
            {
                companyEmpWages[numOfCompanies] = new EmployeeDetails(companyName, wagePerHour, maxWorkingDays, maxWorkingHours);
                numOfCompanies++;
            }
            else
            {
                Console.WriteLine("Maximum number of companies reached!");
            }
        }

        public void ComputeEmpWage()
        {
            foreach (EmployeeDetails companyEmpWage in companyEmpWages)
            {
                if (companyEmpWage != null)
                {
                    int totalEmpHours = 0;
                    int totalWorkingDays = 0;
                    int dailyEmpHours = 0;

                    while (totalEmpHours < companyEmpWage.MaxWorkingHours && totalWorkingDays < companyEmpWage.MaxWorkingDays)
                    {
                        totalWorkingDays++;

                        Random random = new Random();
                        int empCheck = random.Next(0, 3);

                        switch (empCheck)
                        {
                            case 1:
                                dailyEmpHours = 8;
                                break;
                            case 2:
                                dailyEmpHours = 4;
                                break;
                            default:
                                dailyEmpHours = 0;
                                break;
                        }

                        totalEmpHours += dailyEmpHours;
                    }

                    int totalEmpWage = totalEmpHours * companyEmpWage.WagePerHour;
                    Console.WriteLine($"Total wage for {companyEmpWage.CompanyName} company: {totalEmpWage}");
                }
            }
        }
    }


}
