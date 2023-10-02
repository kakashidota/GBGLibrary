using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBGLibrary.Models
{
    //4.
    internal class Transactions
    {
        public int TransactionID { get; set; }
        public Book Book { get; set; }
        public Member Member { get; set; }
        public DateTime IssueData { get; set; }
        public DateTime? ReturnDate { get; set; }

        //7.
        public void CalculateOverdueFees(DateTime dueDate)
        {
            if(ReturnDate.Value > dueDate)
            {
                Member.OverdueFees += 10;
            } 
        }


    }
}
