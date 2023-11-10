namespace Exercise010
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many times?");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                PrintPhrase();
            } //Write your code here
        }

        //Write your method here

        // Call your method here:

        // Write your method here:
        public static void PrintPhrase()
        {
            Console.WriteLine("In a hole in the ground there lived a method");
        }
    }
}
