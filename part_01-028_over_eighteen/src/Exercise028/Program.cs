﻿namespace Exercise028
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            int age = Convert.ToInt32(input);
            if (age < 18)
            { Console.WriteLine("You're under age!"); }
            else
            { Console.WriteLine("You're an adult!"); }



        }
    }
}
