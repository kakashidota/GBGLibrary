using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBGLibrary.Models
{
    //2.
    internal class Librarian : LibraryUser
    {
        public string Position { get; set; }


        //8.
        public void AddBook(Book book, Library library)
        {
            library.Books.Add(book);
            Console.WriteLine($"The book {book.Title} has been added to the library");
        }

        public void RemoveBook(Book book, Library library)
        {
            if (library.Books.Contains(book))
            {
                library.Books.Remove(book);
                Console.WriteLine($"The book {book.Title} has been removed");
            } else
            {
                Console.WriteLine("The book was not found");
            }
        }


        public List<Book> SearchBooks(Library library, string keyword)
        {
            List<Book> matchedBooks = new List<Book>();

            foreach (Book book in library.Books)
            {
                if (book.Title.Contains(keyword) ||)
                {

                }
            }
        }

    }
}
