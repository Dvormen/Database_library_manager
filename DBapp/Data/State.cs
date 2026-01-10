using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBooks.Data
{
    /// <summary>
    /// Represents the condition or state of a book.
    /// </summary>
    internal enum State
    {
        New,
        Damaged,
        Torn,
        Used
    }
}
