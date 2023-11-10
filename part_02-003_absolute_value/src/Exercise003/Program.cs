namespace Exercise003
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            string value = Console.ReadLine();
            int number = Convert.ToInt32(value);
            if (number < 0)
            {
                Console.WriteLine(number * -1);
            }
            else
            {
                Console.WriteLine(number);
            }

            //Write your code here
        }
    }
}
