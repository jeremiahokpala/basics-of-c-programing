namespace Exercise020
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string row = Console.ReadLine();

                if (row == "end")
                {
                    break;
                }

                int number = Convert.ToInt32(row);
                Console.WriteLine(number * number * number);
            }
        }
    }
}
