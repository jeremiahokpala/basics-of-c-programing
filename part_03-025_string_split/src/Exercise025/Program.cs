namespace Exercise025
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                string[] pieces = input.Split(' ');
                foreach (string message in pieces)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}
