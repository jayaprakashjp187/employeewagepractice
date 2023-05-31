namespace employeeWagePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcomes to the employeeWage calculations !");
            
            List<EmployeeDetails> e=new List<EmployeeDetails> ();
            EmployeeDetails e1=new EmployeeDetails { CompanyName="Infosys",ratePerHour=30,maxWorkingDaysInAmonth=22,maxWorkingHours=160 };
            EmployeeDetails e2 = new EmployeeDetails { CompanyName = "TCS", ratePerHour = 32, maxWorkingDaysInAmonth = 22, maxWorkingHours = 160 };
            EmployeeDetails e3 = new EmployeeDetails { CompanyName = "HCL", ratePerHour = 28, maxWorkingDaysInAmonth = 22, maxWorkingHours = 160 };

            EmployeWage.CalculateEmployeeWage(e1);
            EmployeWage.CalculateEmployeeWage(e2);
            EmployeWage.CalculateEmployeeWage(e3);

        }

    }

}