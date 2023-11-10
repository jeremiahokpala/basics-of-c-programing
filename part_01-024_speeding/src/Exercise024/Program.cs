namespace Exercise024
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Your speed:");
            String input = Console.ReadLine();
            int speed = Convert.ToInt32(input);
            if (speed > 120)
            { Console.WriteLine("Speeding!"); }
        }
    }
}
