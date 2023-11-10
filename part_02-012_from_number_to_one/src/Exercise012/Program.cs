namespace Exercise012
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Call your method here:
            PrintFromNumberToOne(5);
        }

        // Write your method here:
        public static void PrintFromNumberToOne(int value)
        {
            for (int i = value; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
