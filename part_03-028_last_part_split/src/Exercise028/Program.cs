namespace Exercise028
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    break;
                }
                string[] words = str.Split(' ');
                string myLastWord = words[words.Length - 1];
                Console.WriteLine(myLastWord);
            }
        }
    }
}
