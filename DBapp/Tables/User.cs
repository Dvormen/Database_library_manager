using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBooks.Tables
{
    /// <summary>
    /// Represents a user entity.
    /// </summary>
    internal class User
    {
        public int User_id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
    }
}
