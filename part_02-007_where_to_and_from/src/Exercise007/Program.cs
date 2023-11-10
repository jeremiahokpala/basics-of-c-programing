namespace Exercise007
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Where to?");

            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Where from?");

            if (number1 > number2)
            {
                for (int i = number2; i <= number1; i++)
                    Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
