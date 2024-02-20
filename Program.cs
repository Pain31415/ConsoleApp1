namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the percentage:");
            double percentage = Convert.ToDouble(Console.ReadLine());

            double result = (percentage / 100) * number;

            Console.WriteLine($"Result: {result}");
        }
    }
}