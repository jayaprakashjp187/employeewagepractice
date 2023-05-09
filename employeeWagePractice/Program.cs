namespace employeeWagePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcomes to the employeeWage calculations !");
            const int Full_Time= 1;
            const int Part_Time = 2;
            int empWage = 0;
            const int Rate_Per_Hour = 20;
            const int EmployeeWagesPerMonth = 20;
            int totalEmployeeWage = 0;
            int empHrs = 0;
            Random random = new Random();
            int randomInput=random.Next(0,3);
            for (int day = 1; day <= EmployeeWagesPerMonth; day++)
            {
                switch (randomInput)
                {
                    case Full_Time: empHrs = 8;Console.WriteLine("full time employee is present"); break;
                    case Part_Time: empHrs = 4; Console.WriteLine("part time employee is present"); break;
                    default: empHrs = 0; Console.WriteLine("employee is absent"); break;

                }

                empWage = empHrs * Rate_Per_Hour;
                Console.WriteLine("Employee Wage  Day {0}: {1}", day, empWage);
                totalEmployeeWage += empWage;
            }
            
            Console.WriteLine("total employee wage per month="+totalEmployeeWage);
            

        }

    }

}