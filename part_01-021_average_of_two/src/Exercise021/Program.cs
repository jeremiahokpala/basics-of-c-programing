namespace Exercise021
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
            double average = (feedback + Feedback1) / 2.0;
            Console.WriteLine("The average is " + average);





        }
    }
}
