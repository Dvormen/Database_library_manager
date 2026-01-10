using DBBooks.Tables;
using System.Data.SqlClient;

namespace DBBooks.Data
{
    /// <summary>
    /// Repository class for managing Loan entities.
    /// </summary>
    internal class LoanRepository : Repository, IRepository<Loan>
    {
        /// <summary>
        /// Adds a new loan to the database.
        /// </summary>
        /// <param name="loan">Loan entity to be added.</param>
        public void Add(Loan loan)
        {
            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("insert into BDBloan(pickUpDate,returnDate,us_id,book_id) values (@pickUpDate,@returnDate,@us_id,@book_id)", conn);

            query.Parameters.AddWithValue("@pickUpDate", loan.PickUpDate);
            query.Parameters.AddWithValue("@returnDate", loan.ReturnDate);
            query.Parameters.AddWithValue("@us_id", loan.User_id);
            query.Parameters.AddWithValue("@book_id", loan.Book_id);

            conn.Open();
            query.ExecuteNonQuery();
        }

        /// <summary>
        /// Deletes a loan from the database by ID.
        /// </summary>
        /// <param name="id">ID of the loan to delete.</param>
        public void Delete(int id)
        {
            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("delete from BDBloan where id = @id", conn);

            query.Parameters.AddWithValue("@id", id);

            conn.Open();
            query.ExecuteNonQuery();
        }

        /// <summary>
        /// Retrieves all loans from the database.
        /// </summary>
        /// <returns>List of all loans.</returns>
        public List<Loan> GetAll()
        {
            var loans = new List<Loan>();

            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("select * from BDBloan", conn);

            conn.Open();
            using var reader = query.ExecuteReader();

            while (reader.Read())
            {
                loans.Add(new Loan
                {
                    Loan_id = reader.GetInt32(0),
                    PickUpDate = reader.GetDateTime(1),
                    ReturnDate = reader.IsDBNull(2)
                        ? null
                        : reader.GetDateTime(2),
                    User_id = reader.GetInt32(3),
                    Book_id = reader.GetInt32(4)

                });
            }

            return loans;
        }

        /// <summary>
        /// Retrieves a loan by its ID.
        /// </summary>
        /// <param name="id">ID of the loan.</param>
        /// <returns>The loan if found; otherwise null.</returns>
        public Loan? GetById(int id)
        {
            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("select * from BDBloan where id = @id", conn);

            query.Parameters.AddWithValue("@id", id);
            conn.Open();

            using var reader = query.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            var loan = new Loan
            {
                Loan_id = reader.GetInt32(0),
                PickUpDate = reader.GetDateTime(1),
                ReturnDate = reader.GetDateTime(2),
                User_id = reader.GetInt32(3),
                Book_id = reader.GetInt32(4)
            };

            return loan;
        }

        /// <summary>
        /// Updates an existing loan in the database.
        /// </summary>
        /// <param name="loan">Loan entity containing updated values.</param>
        public void Update(Loan loan)
        {
            var update = new List<string>();
            var query = new SqlCommand();

            if (loan.PickUpDate.HasValue)
            {
                update.Add("pickUpDate=@pickUpDate");
                query.Parameters.AddWithValue("@pickUpDate", loan.PickUpDate.Value);
            }

            if (loan.ReturnDate.HasValue)
            {
                update.Add("returnDate=@returnDate");
                query.Parameters.AddWithValue("@returnDate", loan.ReturnDate.Value);
            }

            if (loan.User_id.HasValue)
            {
                update.Add("us_id=@us_id");
                query.Parameters.AddWithValue("@us_id", loan.User_id.Value);
            }

            if (loan.Book_id.HasValue)
            {
                update.Add("book_id=@book_id");
                query.Parameters.AddWithValue("@book_id", loan.Book_id.Value);
            }

            if (update.Count == 0)
            {
                return;
            }

            query.CommandText = $"update BDBloan set {string.Join(", ", update)} where id = @id";

            query.Parameters.AddWithValue("@id", loan.Loan_id);

            using var conn = ConfigSetter.GetConnection();
            query.Connection = conn;
            conn.Open();
            query.ExecuteNonQuery();
        }

        /// <summary>
        /// Creates a new loan for a book and marks the book as unavailable.
        /// </summary>
        /// <param name="book_id">ID of the book to borrow.</param>
        /// <param name="user_id">ID of the user borrowing the book.</param>
        public void BorrowBook(int book_id, int user_id)
        {
            using var conn = ConfigSetter.GetConnection();
            conn.Open();

            using var tran = conn.BeginTransaction();

            try
            {
                var queryCheck = new SqlCommand("select count(*) from BDBloan where book_id = @book_id and returnDate is null",
                    conn, tran);

                queryCheck.Parameters.AddWithValue("@book_id", book_id);

                int currLoans = (int)queryCheck.ExecuteScalar();

                if (currLoans > 0)
                {
                    throw new Exception("Book is being borrowed");
                }


                var queryInsert = new SqlCommand("insert into BDBloan (pickUpDate, us_id, book_id) values (@pickUpDate, @us_id, @book_id)", conn, tran);

                queryInsert.Parameters.AddWithValue("@pickUpDate", DateTime.Now);
                queryInsert.Parameters.AddWithValue("@us_id", user_id);
                queryInsert.Parameters.AddWithValue("@book_id", book_id);
                queryInsert.ExecuteNonQuery();

                var queryUpdate = new SqlCommand("update BDBbooks set available = 0 where id = @id", conn, tran);

                queryUpdate.Parameters.AddWithValue("@id", book_id);
                queryUpdate.ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }

        /// <summary>
        /// Returns a borrowed book and marks it as available.
        /// </summary>
        /// <param name="loan_id">ID of the loan.</param>
        public void ReturnBook(int loan_id)
        {
            using var conn = ConfigSetter.GetConnection();
            conn.Open();

            using var tran = conn.BeginTransaction();

            try
            {
                var queryCheck = new SqlCommand("select book_id from BDBloan where id = @id and returnDate is null", conn, tran);

                queryCheck.Parameters.AddWithValue("@id", loan_id);

                var book_id_obj = queryCheck.ExecuteScalar();

                if (book_id_obj == null)
                {
                    throw new Exception("Loan doesn't exist");
                }

                int book_id = (int)book_id_obj;

                var queryUpdateLoan = new SqlCommand("update BDBloan set returnDate = @returnDate where id = @id", conn, tran);

                queryUpdateLoan.Parameters.AddWithValue("@id", loan_id);
                queryUpdateLoan.Parameters.AddWithValue("@returnDate", DateTime.Now);
                queryUpdateLoan.ExecuteNonQuery();

                var queryUpdateBook = new SqlCommand("update BDBbooks set available = 1 where id = @book_id", conn, tran);

                queryUpdateBook.Parameters.AddWithValue("@book_id", book_id);
                queryUpdateBook.ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }

    }
}
