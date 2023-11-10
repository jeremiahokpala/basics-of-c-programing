namespace Exercise029
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string[] parts = input.Split(",");
                numbers.Add(Convert.ToInt32(parts[1]));
            }
            int highest = 0;
            foreach (int num in numbers)
            {
                if (num > highest)
                {
                    highest = num;
                }
            }
            Console.WriteLine("Age of the oldest: " + highest);
        }
    }
}
