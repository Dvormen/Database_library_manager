using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBooks.Tables
{
    internal class BookReport
    {
        public string BookTitle { get; set; }
        public string Genre { get; set; }
        public int LoanCount { get; set; }
        public DateTime? FirstLoan { get; set; }
        public DateTime? LastReturn { get; set; }
    }
}
