namespace Exercise030
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<string> names = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    break;
                }
                string[] value = input.Split(',');
                numbers.Add(Convert.ToInt32(value[1]));
                names.Add(value[0]);
            }
            int oldest = 0;
            string words = "";
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > oldest)
                {
                    oldest = numbers[i];
                    words = names[i];
                }
            }
            Console.WriteLine("Name of the oldest: " + words);
        }
    }
}
