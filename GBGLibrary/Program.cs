using GBGLibrary.Models;
using System.Diagnostics;

namespace GBGLibrary
{
    internal class Program
    {
        static Library library = new Library();
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Library managment system");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Checkout Book");
                Console.WriteLine("3. Return book");
                Console.WriteLine("4. View library stats");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        // CheckOutBook();
                        break;
                    case 3:
                        //ReturnBook();
                        break;
                    case 4:
                        ShowStats();
                        break;
                }

            }

        }

        static void AddBook()
        {
            Console.WriteLine("Add new book");

            Console.WriteLine("Enter book title");
            string title = Console.ReadLine();

            Console.WriteLine("Enter book author");
            string author = Console.ReadLine();

            Console.WriteLine("Enter ISBN");
            string ISBN = Console.ReadLine();

            Console.WriteLine("Enter total copies");
            int totalcopies = int.Parse(Console.ReadLine());

            Book newBook = new Book()
            {
                Title = title,
                Author = author,
                ISBN = ISBN,
                TotalCopies = totalcopies,
                AvailableCopies = totalcopies
            };

            library.Books.Add(newBook);
            Console.WriteLine("A new book was added!");
        }


        static void ShowStats()
        {
            library.LibraryStats();
        }
    }
}