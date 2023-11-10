namespace Exercise031
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
                string message = Console.ReadLine();
                if (String.IsNullOrEmpty(message))
                {
                    break;
                }
                string[] value = message.Split(',');
                numbers.Add(Convert.ToInt32(value[1]));
                names.Add(value[0]);
            }
            int lowest = numbers[0];
            string name = names[0];
            foreach (int num in numbers)
            {
                if (num < lowest)
                {
                    lowest = num;
                }
            }
            foreach (string val in names)
            {
                if (val.Length > name.Length)
                {
                    name = val;
                }
            }
            Console.WriteLine("Longest name: " + name);
            Console.WriteLine("Highest age: " + (2022 - lowest));
        }
    }
}
