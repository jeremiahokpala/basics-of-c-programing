namespace Exercise022
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Which file should have its contents printed?");
            string message = Console.ReadLine();

            if (message == "song.txt")
            {
                string text = File.ReadAllText("song.txt");
                Console.WriteLine(text);
            }
            else
            {
                string text = File.ReadAllText("data.txt");
                Console.WriteLine(text);
            }
        }
    }
}
