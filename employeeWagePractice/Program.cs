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
            switch(randomInput)
            {
                case Full_Time: empHrs = 8; break;
                case Part_Time: empHrs = 4; break;
                default: empHrs = 0; break;

            }
       
            empWage = empHrs*Rate_Per_Hour;
            Console.WriteLine(empWage);
            

        }

    }

}