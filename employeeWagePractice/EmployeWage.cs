using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWagePractice
{
    internal class EmployeWage
    {

       
      
          
            public static void CalculateEmployeeWage(EmployeeDetails employee)
            {
                const int Full_Time = 1;
                const int Part_Time = 2;


                int totalEmployeeWage = 0;
                int totalWorkingHours = 0;
                int day = 1;
                int empWage = 0;
                int empHrs = 0;
                Random random = new Random();
                int randomInput = random.Next(0, 3);
                while (day <= employee.maxWorkingDaysInAmonth && totalWorkingHours < employee.maxWorkingHours)
                {
                    switch (randomInput)
                    {
                        case Full_Time: empHrs = 8; Console.WriteLine("full time employee is present"); break;
                        case Part_Time: empHrs = 4; Console.WriteLine("part time employee is present"); break;
                        default: empHrs = 0; Console.WriteLine("employee is absent"); break;

                    }

                    empWage = empHrs * employee.ratePerHour;

                    totalEmployeeWage += empWage;
                    totalWorkingHours += empHrs;
                    day++;
                }
                Console.WriteLine(employee.CompanyName + "is" + totalEmployeeWage);




            }





        


    }


}
    
    
        
  

