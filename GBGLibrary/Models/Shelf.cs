using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBGLibrary.Models
{

    //5.
    internal class Shelf
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();


        //13.
        public bool IsFull()
        {
            return Books.Count >= 10;
        }
    }
}
