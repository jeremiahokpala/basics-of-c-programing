namespace Exercise018
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            //Call your method here:

            int answer = Smallest(2, 7);
            Console.WriteLine("Smallest: " + answer);
        }

        //Write your method here:
        public static int Smallest(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
    }
}
