namespace Exercise015
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            // IMPLEMENT YOUR CODE IN HERE!
            List<Item> items = new List<Item>();
            while (true){
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if(String.IsNullOrEmpty(name)){
                    break;
                }
                items.Add(new Item(name));
            }
            Console.WriteLine();
            foreach (Item name in items)
            {
                // Print using ToString
                Console.WriteLine(name.ToString());
            }

        }
    }
}
