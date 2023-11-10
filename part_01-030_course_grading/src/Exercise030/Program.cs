namespace Exercise030
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give your percent [0 - 100]:");
            string input = Console.ReadLine();
            int score = Convert.ToInt32(input);
            if (score < 0)
            {
                Console.WriteLine("Impossible");
            }
            else if (score < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (score < 60)
            {
                Console.WriteLine("Grade: 1");
            }
            else if (score < 70)
            {
                Console.WriteLine("Grade: 2");
            }
            else if (score < 80)
            {
                Console.WriteLine("Grade: 3");
            }
            else if (score < 90)
            {
                Console.WriteLine("Grade: 4");
            }
            else if (score <= 100)
            {
                Console.WriteLine("Grade: 5");
            }
            else
            {
                Console.WriteLine("Outstanding!");
            }

        }
    }
}
