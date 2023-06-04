using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWagePractice
{
    internal class EmployeWage
    {

        public string CompanyName { get; set; }
        public int ratePerHour { get; set; }
        public int maxWorkingDaysInAmonth { get; set; }
        public int maxWorkingHours { get; set; }
        public int totalEmployeeWage = 0;
        public int totalWorkingHours = 0;
        public int day = 1;
        public int empWage = 0;
        public int empHrs = 0;

        public static void CalculateEmployeeWage()
          {
                const int Full_Time = 1;
                const int Part_Time = 2;
            EmployeWage e1 = new EmployeWage { CompanyName = "Infosys", ratePerHour = 30, maxWorkingDaysInAmonth = 22, maxWorkingHours = 160 };
            EmployeWage e2 = new EmployeWage { CompanyName = "TCS", ratePerHour = 32, maxWorkingDaysInAmonth = 22, maxWorkingHours = 160 };
            EmployeWage e3 = new EmployeWage { CompanyName = "HCL", ratePerHour = 28, maxWorkingDaysInAmonth = 22, maxWorkingHours = 160 };

               
                Random random = new Random();
                int randomInput = random.Next(0, 3);
                while (e1.day <= e1.maxWorkingDaysInAmonth && e1.totalWorkingHours < e1.maxWorkingHours)
                {
                    switch (randomInput)
                    {
                        case Full_Time: e1.empHrs = 8; Console.WriteLine("full time employee is present"); break;
                        case Part_Time: e1.empHrs = 4; Console.WriteLine("part time employee is present"); break;
                        default: e1.empHrs = 0; Console.WriteLine("employee is absent"); break;

                    }

                    e1.empWage = e1.empHrs * e1.ratePerHour;
                   
                    e1.totalEmployeeWage += e1.empWage;
                    e1.totalWorkingHours += e1.empHrs;
                    e1.day++;
                }
            Console.WriteLine(e1.CompanyName + "is" + e1.totalEmployeeWage);
            while (e2.day <= e2.maxWorkingDaysInAmonth && e2.totalWorkingHours < e2.maxWorkingHours)
            {
                switch (randomInput)
                {
                    case Full_Time: e2.empHrs = 8; Console.WriteLine("full time employee is present"); break;
                    case Part_Time: e2.empHrs = 4; Console.WriteLine("part time employee is present"); break;
                    default: e2.empHrs = 0; Console.WriteLine("employee is absent"); break;

                }

                e2.empWage = e2.empHrs * e2.ratePerHour;

                e2.totalEmployeeWage += e2.empWage;
                e2.totalWorkingHours += e2.empHrs;
                e2.day++;
            }
            Console.WriteLine(e2.CompanyName + "is" + e2.totalEmployeeWage);
            while (e3.day <= e3.maxWorkingDaysInAmonth && e3.totalWorkingHours < e3.maxWorkingHours)
            {
                switch (randomInput)
                {
                    case Full_Time: e3.empHrs = 8; Console.WriteLine("full time employee is present"); break;
                    case Part_Time: e3.empHrs = 4; Console.WriteLine("part time employee is present"); break;
                    default: e3.empHrs = 0; Console.WriteLine("employee is absent"); break;

                }

                e3.empWage = e3.empHrs * e3.ratePerHour;

                e3.totalEmployeeWage += e3.empWage;
                e3.totalWorkingHours += e3.empHrs;
                e3.day++;
            }
            Console.WriteLine(e3.CompanyName + "is" + e3.totalEmployeeWage);




        }

      
    }


}
    
    
        
  

