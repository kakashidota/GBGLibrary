using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBGLibrary.Models
{

    //3.
    internal class Book : Document
    {
        public string ISBN { get; set; }
        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }
    }
}
