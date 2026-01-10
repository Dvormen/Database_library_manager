using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBooks.Tables
{
    /// <summary>
    /// Represents a report containing loan statistics for an author.
    /// </summary>
    internal class AuthorReport
    {
        public string AuthorName { get; set; }
        public int LoanCount { get; set; }
        public DateTime FirstLoan { get; set; }
        public DateTime LastLoan { get; set; }
    }
}
