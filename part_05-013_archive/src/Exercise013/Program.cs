namespace Exercise013
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            // Ask for input as shown in the exercise.
            while (true)
            {
                Console.WriteLine("Identifier? (empty will stop):");
                string identifier = Console.ReadLine();

                if (String.IsNullOrEmpty(identifier))
                {
                    break;
                }
                Console.WriteLine("Name? (empty will stop):");
                string name = Console.ReadLine();

                if (String.IsNullOrEmpty(name))
                {
                    break;
                }
                Item item = new Item(identifier, name);
                if (items.Contains(item))
                {
                    continue;
                }
                items.Add(item);
            }

            // The end printing is ready, don't touch this
            Console.WriteLine("==Items==");
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
