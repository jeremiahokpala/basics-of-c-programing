namespace Exercise023
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
            int Feedback1 = Convert.ToInt32(second);
            Console.WriteLine(feedback + " + " + Feedback1 + " = " + (feedback + Feedback1));
            Console.WriteLine(feedback + " - " + Feedback1 + " = " + (feedback - Feedback1));
            Console.WriteLine(feedback + " * " + Feedback1 + " = " + (feedback * Feedback1));
            Console.WriteLine(feedback + " / " + Feedback1 + " = " + ((double)feedback / Feedback1));

        }
    }
}
