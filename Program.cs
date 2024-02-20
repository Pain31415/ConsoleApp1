namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a six-digit number:");
            int number = Convert.ToInt32(Console.ReadLine());

            int reversedNumber = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            Console.WriteLine("Reversed number: " + reversedNumber);
        }
    }
}