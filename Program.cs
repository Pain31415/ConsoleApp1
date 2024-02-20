namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter five numbers:");

            double[] numbers = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }

            double max = numbers[0];
            double min = numbers[0];
            foreach (double num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            }

            double product = 1;
            foreach (double num in numbers)
            {
                product *= num;
            }

            Console.WriteLine($"Sum of numbers: {sum}");
            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Product of numbers: {product}");

            Console.ReadLine();
        }
    }
}