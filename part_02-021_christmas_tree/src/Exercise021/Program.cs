namespace Exercise021
{
    using System;

    public class Program
    {
        public static void Main(String[] args)
        {
            PrintSpaces(3);
            PrintRightTriangle(4);
            ChristmasTree(4);
        }

        public static void PrintSpaces(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(" ");
            }
        }

        public static void PrintStars(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }

        public static void PrintRightTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                PrintSpaces(size - i);
                PrintStars(i);
            }
        }

        public static void ChristmasTree(int height)
        {
            for (int i = 1; i < height + 1; i++)
            {
                PrintSpaces(height - i);
                PrintStars(2 * i - 1);
            }
            for (int i = 0; i < 2; i++)
            {
                PrintSpaces(height - 2);
                PrintStars(3);
            }
        }
    }
}
