namespace employeeWagePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcomes to the employeeWage calculations !");

            EmployeeWageBuilder empWageBuilder = new EmployeeWageBuilder();
            empWageBuilder.AddCompanyEmpWage("Infosys", 20, 20, 100);
            empWageBuilder.AddCompanyEmpWage("Tcs B", 25, 22, 110);
            empWageBuilder.ComputeEmpWage();

        }

    }

}