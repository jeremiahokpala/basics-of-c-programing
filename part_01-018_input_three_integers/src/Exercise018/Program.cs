﻿namespace Exercise018
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
            int feedback1 = Convert.ToInt32(second);
            Console.WriteLine("Give the third number!");
            string third = Console.ReadLine();
            int feedback2 = Convert.ToInt32(third);
            Console.WriteLine("The sum is " + (feedback + feedback1 + feedback2));
        }
    }
}
