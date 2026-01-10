using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBooks.Tables
{
    /// <summary>
    /// Represents a loan entity for tracking book loans by users.
    /// </summary>
    internal class Loan
    {
        public int Loan_id { get; set; }
        public DateTime? PickUpDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? User_id { get; set; }
        public int? Book_id { get; set; }
    }
}
