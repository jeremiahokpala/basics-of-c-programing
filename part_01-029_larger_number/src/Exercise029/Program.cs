namespace Exercise029
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give the first number!");
            string first = Console.ReadLine();
            int number = Convert.ToInt32(first);
            Console.WriteLine("Give the second number!");
            string second = Console.ReadLine();
            int number1 = Convert.ToInt32(second);
            if (number > number1)
            { Console.WriteLine("The larger number is " + number + "!"); }
            if (number1 > number)
            { Console.WriteLine("The larger number is " + number1 + "!"); }
            if (number == number1)
            { Console.WriteLine("They are equal!"); }
        }
    }
}
