namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Convert Fahrenheit to Celsius");
            Console.WriteLine("2. Convert Celsius to Fahrenheit");

            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Enter the temperature in Fahrenheit:");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());

                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"Temperature in Celsius: {celsius}");
            }
            else if (option == 2)
            {
                Console.WriteLine("Enter the temperature in Celsius:");
                double celsius = Convert.ToDouble(Console.ReadLine());

                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
            }
            else
            {
                Console.WriteLine("Invalid option selected.");
            }
        }
    }
}