namespace Exercise014
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give me the truth!");
            string truevalue = Console.ReadLine();
            Boolean feedback = System.Convert.ToBoolean(truevalue);
            Console.WriteLine(feedback);
        }
    }
}
