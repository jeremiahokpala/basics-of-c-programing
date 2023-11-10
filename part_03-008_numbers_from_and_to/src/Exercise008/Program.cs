namespace Exercise008
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();

            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == -1)
                {
                    break;
                }
                list.Add(number);
            }
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("From where?");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Where to?");

            foreach (int number in list)
            {
                if (number >= number1 && number <= number2)
                {
                    Console.WriteLine(number);
                }
            }
            //Write your code here
        }
    }
}
