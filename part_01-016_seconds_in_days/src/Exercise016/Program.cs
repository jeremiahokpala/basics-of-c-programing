namespace Exercise016
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many days?");
            string message = Console.ReadLine();
            int days = Convert.ToInt32(message);
            int value = days * 86400;
            Console.WriteLine(value);





        }
    }
}
