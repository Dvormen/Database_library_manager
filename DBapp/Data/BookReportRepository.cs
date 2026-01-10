using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBooks.Data
{
    internal class BookReportRepository : Repository
    {
        public List<Tables.BookReport> GetBookLoanStats()
        {
            var res = new List<Tables.BookReport>();

            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("select BookTitle, Genre, LoanCount, FirstLoan, LastReturn from bookLoanView", conn);

            conn.Open();
            using var reader = query.ExecuteReader();

            while (reader.Read())
            {
                DateTime? firstLoan;

                if (reader.IsDBNull(3))
                {
                    firstLoan = null;
                }
                else
                {
                    firstLoan = reader.GetDateTime(3);
                }

                DateTime? lastReturn;

                if (reader.IsDBNull(4))
                {
                    lastReturn = null;
                }
                else
                {
                    lastReturn = reader.GetDateTime(4);
                }

                res.Add(new Tables.BookReport
                {
                    BookTitle = reader.GetString(0),
                    Genre = reader.GetString(1),
                    LoanCount = reader.GetInt32(2),
                    FirstLoan = firstLoan,
                    LastReturn = lastReturn
                });
            }

            return res;
        }
    }
}
