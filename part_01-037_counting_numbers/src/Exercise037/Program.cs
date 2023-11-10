namespace Exercise037
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

                amount = amount + 1;
            }
            Console.WriteLine("Total amount of numbers: " + amount);
        }
    }
}
