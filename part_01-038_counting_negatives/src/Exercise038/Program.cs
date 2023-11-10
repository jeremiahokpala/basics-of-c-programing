namespace Exercise038
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int amount = 0;
            while (true)
            {
                Console.WriteLine("Give a number:");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                if (number == 0)
                {
                    break;
                }
                if (number < 0)
                {
                    amount = amount + 1;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Total amount of negative numbers: " + amount);
        }
    }
}
