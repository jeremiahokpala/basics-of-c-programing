namespace Exercise039
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int value = 0;
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Give a number:");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                if (number == 0)
                {
                    break;
                }
                else
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine("Total sum of numbers: " + sum);
        }
    }
}
