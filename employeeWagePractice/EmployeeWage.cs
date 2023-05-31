using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWagePractice
{
    internal class EmployeeWage
    {
        const int Full_Time = 1;
        const int Part_Time = 2;

        const int Rate_Per_Hour = 20;
        const int Max_Working_Days = 20;
        const int Max_Working_Hours = 100;
        public static void CalculatingEmployeeWage()
        {

            int totalEmployeeWage = 0;
            int totalWorkingHours = 0;
            int day = 1;
            int empWage = 0;
            int empHrs = 0;
            Random random = new Random();
            int randomInput = random.Next(0, 3);
            while (day <= Max_Working_Days && totalWorkingHours < Max_Working_Hours)
            {
                switch (randomInput)
                {
                    case Full_Time: empHrs = 8; Console.WriteLine("full time employee is present"); break;
                    case Part_Time: empHrs = 4; Console.WriteLine("part time employee is present"); break;
                    default: empHrs = 0; Console.WriteLine("employee is absent"); break;

                }

                empWage = empHrs * Rate_Per_Hour;
                Console.WriteLine("Employee Wage  Day {0}: {1}", day, empWage);
                totalEmployeeWage += empWage;
                totalWorkingHours += empHrs;
                day++;
            }

            Console.WriteLine("Employee Wage for {0} Days  {1} Hours  {2}", totalEmployeeWage, day - 1, totalWorkingHours);

        }   
        
    }
}
