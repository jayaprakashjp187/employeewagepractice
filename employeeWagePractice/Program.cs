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
            int empHrs = 0;
            Random random = new Random();
            int randomInput=random.Next(0,3);
            if(Full_Time==randomInput)
            {
                empHrs = 8;
                Console.WriteLine("employee is Present");
               
            }
            else if(Part_Time==randomInput)
            {
                empHrs = 4;
                Console.WriteLine("part time employee is present");
                
            }
            else
            {
                Console.WriteLine("employee is absent");

            }
            empWage = empHrs*Rate_Per_Hour;
            Console.WriteLine(empWage);
            

        }

    }

}