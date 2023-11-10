namespace Exercise009
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
                if (input == -1)
                {
                    break;
                }
                list.Add(input);
            }
            int result = list[0];
            foreach (int value in list)
            {
                if (value > result)
                {
                    result = value;
                }
            }
            Console.WriteLine("The greatest number: " + result);
        }
    }
}
