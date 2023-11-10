namespace Exercise018
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main(string[] args)
        {
            // implement here the program that allows the user to enter 
            // book information and to examine them
            List<Book> list = new List<Book>();
            while(true){
                Console.Write("Name: ");
                string name = Console.ReadLine();
                if (String.IsNullOrEmpty(name)){
                    break;
                }
                Console.Write("Pages: ");
                int pages = Convert.ToInt32(Console.ReadLine());
                Console.Write("Publication year: ");
                int publicationYear = Convert.ToInt32(Console.ReadLine());
                list.Add(new Book(name, pages, publicationYear));
            }
            Console.WriteLine();
            Console.Write("What information will be printed? ");
            string type = Console.ReadLine();
            foreach (Book item in list){
                if(type == "title"){
                    Console.WriteLine(item.name);
                }else if (type == "everything"){
                    Console.WriteLine(item.ToString());
                }
            }

        }
    }
}