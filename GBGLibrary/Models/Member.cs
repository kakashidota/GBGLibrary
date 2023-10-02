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

        //12.
        public void ViewTransactionHistory(Library library, Member member)
        {
            List<Transactions> membersTransaction = new List<Transactions>();

            foreach(Transactions transaction in library.Transactions)
            {
                if(transaction.Member.ID == ID)
                {
                    membersTransaction.Add(transaction);
                }
            }

            Console.WriteLine($"Transactions for member {Name}:");
            if(membersTransaction.Count > 0) 
            {
                foreach (Transactions transaction in membersTransaction)
                {
                    string returnDateString;

                    if (transaction.ReturnDate.HasValue)
                    {
                        returnDateString = transaction.ReturnDate.Value.ToString();
                    } else
                    {
                        returnDateString = "Not returned";
                    }
                    Console.WriteLine($"Book: {transaction.Book.Title}, Issue Date: {transaction.IssueDate.ToString()}, Return date: {returnDateString}");
                }
            } else
            {
                Console.WriteLine("No transactions found");
            }

        }


    }
}
