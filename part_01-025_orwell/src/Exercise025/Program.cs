namespace Exercise025
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number:");
            String input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            if (number == 1984)
            { Console.WriteLine("Orwell"); }
        }
    }
}
