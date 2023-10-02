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

        //9.
        public List<Book> SearchBooks(Library library, string keyword)
        {
            List<Book> matchedBooks = new List<Book>();

            foreach (Book book in library.Books)
            {
                if (book.Title.Contains(keyword) || book.Author.Contains(keyword) || book.ISBN.Contains(keyword))
                {
                    matchedBooks.Add(book);
                }
            }

            return matchedBooks;
        }

        //13.B
        public void SearchBookByCategory(Library library, string category)
        {
            bool bookFound = false;
            foreach (Shelf shelf in library.Shelves)
            {
                if(shelf.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                {
                    foreach(Book book in shelf.Books)
                    {
                        bookFound = true;
                        Console.WriteLine($"Book {book.Title}, Author {book.Author}");
                    }
                }
            }
        }

        //10.
        public void AddBookToShelf(Shelf shelf, Book book, Library library)
        {
            if (library.Books.Contains(book))
            {
                shelf.Books.Add(book);
                Console.WriteLine($"The book {book.Title} has been added to the shelf");
            }
        }

        //Kom ihåg library
        public void RemoveBookFromShelf(Shelf shelf, Book book, Library library)
        {
            if (shelf.Books.Contains(book))
            {
                shelf.Books.Remove(book);
                Console.WriteLine($"The book {book.Title} has been removed from the shelf");
            } else
            {
                Console.WriteLine($"The book {book.Title} was not found on this shelf");
            }
        }


        //11.
        public void IssueBook(Library library, Book book, Member member)
        {
            if(book.AvailableCopies > 0)
            {

                Transactions transactions = new Transactions()
                {
                    TransactionID = 1,
                    Book = book,
                    Member = member,
                    IssueDate = DateTime.Now
                };

                library.Transactions.Add(transactions);
                member.CheckoutBook(book);

                Console.WriteLine($"The book {book.Title} has been issued to {member.Name}");
            } else
            {
                Console.WriteLine($"The book {book.Title} is not available");
            }
        }


        public void AcceptReturnedBook(Library library, Book book, Member member)
        {
            bool containsBook = false;

            foreach(Book b in member.CheckoutBooks)
            {
                if(b == book)
                {
                    containsBook = true;
                    break;
                }
            }

            if(containsBook)
            {
                Transactions targetTranscation = null;
                foreach (Transactions transaction in library.Transactions)
                {
                    if(transaction.Book == book && transaction.Member == member)
                    {
                        targetTranscation = transaction;
                        break;
                    }
                }

                if (targetTranscation != null)
                {
                    targetTranscation.ReturnDate = DateTime.Now;
                }

                for(int i = 0; i < member.CheckoutBooks.Count; i++)
                {
                    if (member.CheckoutBooks[i] == book)
                    {
                        member.ReturnBook(book);
                        break;
                    }
                }

            }
        }
    }
}
