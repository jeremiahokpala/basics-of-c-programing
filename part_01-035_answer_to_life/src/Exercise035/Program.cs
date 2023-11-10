namespace Exercise035
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Give a number:");
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                if (number == 42)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
