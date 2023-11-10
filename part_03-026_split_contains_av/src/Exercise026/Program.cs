namespace Exercise026
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string inputString = Console.ReadLine();
                string wordtofind = "av";

                if (string.IsNullOrEmpty(inputString))
                {
                    break;
                }
                string[] value = inputString.Split(" ");

                foreach (string item in value)
                {
                    if (item.Contains(wordtofind))
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
