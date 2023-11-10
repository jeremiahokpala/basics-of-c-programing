namespace Exercise040
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int amount = 0;
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
                    amount = amount + 1;
                }
            }
            Console.WriteLine("Total sum of numbers: " + sum);
            Console.WriteLine("Total amount of numbers: " + amount);
        }
    }
}
