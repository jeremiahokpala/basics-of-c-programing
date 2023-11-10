namespace Exercise011
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
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 9999)
                {
                    break;
                }
                list.Add(input);
            }
            int smallest = list[0];
            foreach (int value in list)
            {
                if (value < smallest)
                {
                    smallest = value;
                }
            }
            Console.WriteLine("Smallest number: " + smallest);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == smallest)
                {
                    Console.WriteLine("Found at index: " + (i));
                }
            }
        }
    }
}
