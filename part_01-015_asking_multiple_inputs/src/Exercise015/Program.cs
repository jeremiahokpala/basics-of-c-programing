namespace Exercise015
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give a string:");
            string message = Console.ReadLine();
            Console.WriteLine("Give an integer:");
            string userinput = Console.ReadLine();
            int feedback = Convert.ToInt32(userinput);
            Console.WriteLine("Give a double:");
            string userinput1 = Console.ReadLine();
            double feedback1 = Convert.ToDouble(userinput1);
            Console.WriteLine("Give a boolean:");
            string truevalue = Console.ReadLine();
            bool feedback3 = System.Convert.ToBoolean(truevalue);
            Console.WriteLine("Your string: " + message);
            Console.WriteLine("Your integer: " + userinput);
            Console.WriteLine("Your double: " + feedback1);
            Console.WriteLine("Your boolean: " + feedback3);
        }
    }
}
