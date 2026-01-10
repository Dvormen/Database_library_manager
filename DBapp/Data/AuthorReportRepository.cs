using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBooks.Data
{
    /// <summary>
    /// Repository class used for accessing author loan report data.
    /// </summary>
    internal class AuthorReportRepository : Repository
    {
        /// <summary>
        /// Returns loan statistics for each author.
        /// </summary>
        /// <returns>A list of AuthorReport objects containing author loan statistics.</returns>
        public List<Tables.AuthorReport> GetAuthorLoanStats()
        {
            var res = new List<Tables.AuthorReport>();

            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("select AuthorName, LoanCount, FirstLoan, LastLoan from authorLoanView", conn);

            conn.Open();
            using var reader = query.ExecuteReader();

            while (reader.Read())
            {
                res.Add(new Tables.AuthorReport
                {
                    AuthorName = reader.GetString(0),
                    LoanCount = reader.GetInt32(1),
                    FirstLoan = reader.GetDateTime(2),
                    LastLoan = reader.GetDateTime(3)
                });
            }

            return res;
        }
    }
}
