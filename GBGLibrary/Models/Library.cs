﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBGLibrary.Models
{

    //14.
    internal class Library
    {
        public List<Shelf> Shelves { get; set; }
        public List<Member> Members { get; set; }
        public List<Librarian> Librarians { get; set; }
        public List<Transactions> Transactions { get; set; }
        public List<Book> Books { get; set; }

        public Library()
        {
            Shelves = new List<Shelf>();
            Members = new List<Member>();
            Librarians = new List<Librarian>();
            Transactions = new List<Transactions>();
            Books = new List<Book>();
        }

        public void AddShelf(Shelf shelf)
        {
            Shelves.Add(shelf);
        }

        public void RemoveShelf(Shelf shelf)
        {
            Shelves.Remove(shelf);
        }

        public void RegisterMember(Member member)
        {
            Members.Add(member);
        }

        public void RemoveMember(Member member)
        {
            Members.Remove(member);
        }

        public void HireLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }

        public void FireLibrarian(Librarian librarian)
        {
            Librarians.Remove(librarian);
        }

    }
}