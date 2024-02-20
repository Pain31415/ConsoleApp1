namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the lower and upper bounds of the numerical range:");
            int lowerBound = Convert.ToInt32(Console.ReadLine());
            int upperBound = Convert.ToInt32(Console.ReadLine());

            DisplayFibonacciInRange(lowerBound, upperBound);
        }

        static void DisplayFibonacciInRange(int lowerBound, int upperBound)
        {
            int a = 0, b = 1, c = 0;

            if (lowerBound <= 0)
            {
                Console.Write("0, ");
            }

            while (c <= upperBound)
            {
                c = a + b;
                a = b;
                b = c;
                if (c >= lowerBound && c <= upperBound)
                {
                    Console.Write(c + ", ");
                }
            }
        }
    }
}