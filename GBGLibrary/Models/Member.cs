using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBGLibrary.Models
{
    //2.
    internal class Member : LibraryUser
    {
        public string Adress { get; set; }
        public List<Book> CheckoutBooks { get; set; }
        public int OverdueFees { get; set; }


        //6.
        public void CheckoutBook(Book book)
        {
            if (book.AvailableCopies > 0)
            {
                book.AvailableCopies--;
                CheckoutBooks.Add(book);
            } else
            {
                Console.WriteLine($"Sorry, all the copies of {book.Title} are currently checked out");
            }
        }


        public void ReturnBook(Book book)
        {
            if (CheckoutBooks.Contains(book))
            {
                CheckoutBooks.Remove(book);
                book.AvailableCopies++;
            } else 
            {
                Console.WriteLine($"The book {book.Title} was not checked out by this member");
            }
        }
    }
}
