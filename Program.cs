namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a six-digit number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 100000 && number <= 999999)
            {
                Console.WriteLine("Enter the positions of digits to swap:");
                int position1 = Convert.ToInt32(Console.ReadLine());
                int position2 = Convert.ToInt32(Console.ReadLine());

                if (position1 >= 1 && position1 <= 6 && position2 >= 1 && position2 <= 6)
                {
                    int[] digits = new int[6];
                    int temp = number;
                    for (int i = 5; i >= 0; i--)
                    {
                        digits[i] = temp % 10;
                        temp /= 10;
                    }

                    int tempDigit = digits[position1 - 1];
                    digits[position1 - 1] = digits[position2 - 1];
                    digits[position2 - 1] = tempDigit;

                    int newNumber = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        newNumber = newNumber * 10 + digits[i];
                    }

                    Console.WriteLine($"Transformed number: {newNumber}");
                }
                else
                {
                    Console.WriteLine("Invalid positions entered.");
                }
            }
            else
            {
                Console.WriteLine("The number is not a six-digit number.");
            }
        }
    }
}