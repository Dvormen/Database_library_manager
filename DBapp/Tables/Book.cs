using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace DBBooks.Tables
{
    /// <summary>
    /// Represents a book entity.
    /// </summary>
    internal class Book
    {
        
        public int Book_id { get; set; }
        public string? BookTitle { get; set; }
        private float? price;
        public bool? Available { get; set; }
        public Data.State? State { get; set; }
        public int? Genre_id { get; set; }
        public int? Author_id { get; set; }
        public decimal? Price
        {
            get { return (decimal?)price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be lower than 0");
                }
                price = (float?)value;
            }
        }
    }
}
