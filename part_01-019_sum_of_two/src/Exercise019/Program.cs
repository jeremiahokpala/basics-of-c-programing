namespace Exercise019
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            string first = Console.ReadLine();
            int feedback = Convert.ToInt32(first);
            Console.WriteLine("Give the second number!");
            string second = Console.ReadLine();
            int feedback2 = Convert.ToInt32(second);
            Console.WriteLine(feedback + " + " + feedback2 + " = " + (feedback + feedback2));

        }
    }
}
