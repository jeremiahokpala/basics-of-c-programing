namespace Exercise010
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
            Console.WriteLine("Search for?");
            string inputSearch = Console.ReadLine();
            int search = Convert.ToInt32(inputSearch);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == search)
                {
                    Console.WriteLine(search + " is at index " + i);
                }
            }
        }
    }
}
