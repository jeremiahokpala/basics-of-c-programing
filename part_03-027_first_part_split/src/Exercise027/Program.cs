namespace Exercise027
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
                string[] value = input.Split(" ");
                Console.WriteLine(value[0]);
            }
        }
    }
}
