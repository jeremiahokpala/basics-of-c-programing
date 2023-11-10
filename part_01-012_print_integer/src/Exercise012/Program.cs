namespace Exercise012
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a number!");
            string userinput = Console.ReadLine();
            int feedback = Convert.ToInt32(userinput);
            Console.WriteLine("You gave " + feedback);
        }
    }
}
