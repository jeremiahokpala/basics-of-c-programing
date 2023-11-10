namespace Exercise026
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give your year of birth:");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);
            if (age < 1900)
            { Console.WriteLine("You're old"); }
        }
    }
}
