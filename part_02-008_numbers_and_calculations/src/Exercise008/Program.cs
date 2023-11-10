namespace Exercise008
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give numbers:");
            int sum = 0;
            int numbers = 0;
            int even = 0;
            int odd = 0;
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == -1)
                {
                    break;
                }
                if (input != -1)
                {
                    sum = sum + input;
                    numbers = numbers + 1;
                    if ((input % 2) == 1)
                    {
                        odd = odd + 1;
                    }
                    else
                    {
                        even = even + 1;
                    }
                }
            }
            double average = ((double)sum / numbers);
            Console.WriteLine("Thx! Bye!");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Numbers: " + numbers);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Even: " + even);
            Console.WriteLine("Odd: " + odd);
        }
    }
}
