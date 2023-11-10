namespace Exercise020
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 5, 1, 3, 4, 2 };
            PrintNeatly(array);
        }

        public static void PrintNeatly(int[] array)
        {
            int index = 0;
            while (index < array.Length - 1)
            {
                int number = array[index];
                Console.Write(number + ", ");
                index = index + 1;
            }
            int lastElement = array[array.Length - 1];
            Console.WriteLine(lastElement);
        }
    }
}
