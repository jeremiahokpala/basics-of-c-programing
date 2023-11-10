namespace Exercise013
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number!");
            string userinput = Console.ReadLine();
            double feedback = Convert.ToDouble(userinput);
            Console.WriteLine("You gave " + feedback);
        }
    }
}
