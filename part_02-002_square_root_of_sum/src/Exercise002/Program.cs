namespace Exercise002
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int value = Convert.ToInt32(input);
            string input1 = Console.ReadLine();
            int value1 = Convert.ToInt32(input1);
            int sum = (value + value1);
            double quareroot = Math.Sqrt(sum);
            Console.WriteLine(quareroot);
        }
    }
}
