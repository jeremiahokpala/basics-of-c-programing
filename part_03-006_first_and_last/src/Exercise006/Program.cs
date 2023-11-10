namespace Exercise006
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            int index = 0;
            List<string> list = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                list.Add(input);
                index = list.Count;
            }
            {
                Console.WriteLine(list[0]);
                Console.WriteLine(list[index - 1]);
            }
        }
    }
}
