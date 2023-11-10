namespace Exercise019
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                string row = Console.ReadLine();

                if (row == "end")
                {
                    break;
                }
                sum = sum + 1;
            }
            Console.WriteLine(sum);
        }
    }
}
