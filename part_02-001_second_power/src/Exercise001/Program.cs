namespace Exercise001
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string message = Console.ReadLine();
            int value = Convert.ToInt32(message);
            Console.WriteLine(value * value);
        }
    }
}
