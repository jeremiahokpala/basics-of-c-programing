﻿namespace Exercise017
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the second number!");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum is " + (first + second));
        }
    }
}