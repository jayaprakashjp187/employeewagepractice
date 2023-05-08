namespace employeeWagePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            const int Is_Present = 1;
            Random random = new Random();
            int randomInput=random.Next(0,2);
            if(Is_Present==randomInput)
            {
                Console.WriteLine("employee is Present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }

    }

}