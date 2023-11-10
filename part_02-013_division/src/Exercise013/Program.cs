namespace Exercise013
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            //Call your method here
            Division(2, 3);
        }

        //Write your method here

        public static void Division(int numerator, int denominator)
        {
            int first = Convert.ToInt32(numerator);

            int second = Convert.ToInt32(denominator);

            Console.WriteLine((double)first / second);
        }
    }
}
