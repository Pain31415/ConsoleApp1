namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter four digits:");

            int digit1 = Convert.ToInt32(Console.ReadLine());
            int digit2 = Convert.ToInt32(Console.ReadLine());
            int digit3 = Convert.ToInt32(Console.ReadLine());
            int digit4 = Convert.ToInt32(Console.ReadLine());

            int number = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

            Console.WriteLine($"Number composed of the digits: {number}");
        }
    }
}