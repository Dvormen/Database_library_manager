using DBBooks.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBooks.Data
{
    internal class BookRepository : Repository, IRepository<Book>
    {
        public void Add(Book book)
        {
            using var conn = GetConnection();
            using var query = new SqlCommand(
                "insert into BDBbooks(title,price,available,state,genre_id,author_id) values (@title,@price,@available,@state,@genre_id,@author_id)", conn);

            query.Parameters.AddWithValue("@title", book.BookTitle);
            query.Parameters.AddWithValue("@price", book.Price);
            query.Parameters.AddWithValue("@available", book.Available);
            query.Parameters.AddWithValue("@state", book.State!.Value.ToString());
            query.Parameters.AddWithValue("@genre_id", book.Genre_id);
            query.Parameters.AddWithValue("@authorId", book.Author_id);
            conn.Open();

            query.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = GetConnection();
            using var query = new SqlCommand("delete from BDBbooks where id = @id", conn);

            query.Parameters.AddWithValue("@id", id);

            conn.Open();
            query.ExecuteNonQuery();
        }

        public List<Book> GetAll()
        {
            var books = new List<Book>();

            using var conn = GetConnection();
            using var query = new SqlCommand("select * from BDBbooks", conn);

            conn.Open();
            using var reader = query.ExecuteReader();

            while (reader.Read())
            {
                books.Add(new Book
                {
                    Book_id = reader.GetInt32(0),
                    BookTitle = reader.GetString(1),
                    Price = reader.GetDecimal(2),
                    Available = reader.GetBoolean(3),
                    State = Enum.Parse<State>(reader.GetString(4)),
                    Genre_id = reader.GetInt32(5),
                    Author_id = reader.GetInt32(6)

                });
            }

            return books;
        }

        public Book? GetById(int id)
        {
            using var conn = GetConnection();
            using var query = new SqlCommand("select * from BDBbooks where id = @id", conn);

            query.Parameters.AddWithValue("@id", id);
            conn.Open();

            using var reader = query.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            var book = new Book
            {
                Book_id = reader.GetInt32(0),
                BookTitle = reader.GetString(1),
                Price = reader.GetDecimal(2),
                Available = reader.GetBoolean(3),
                State = Enum.Parse<State>(reader.GetString(4)),
                Genre_id = reader.GetInt32(5),
                Author_id = reader.GetInt32(6)
            };

            return book;
        }

        public void Update(Book book)
        {
            var update = new List<string>();
            var query = new SqlCommand();

            if (!string.IsNullOrWhiteSpace(book.BookTitle))
            {
                update.Add("title = @title");
                query.Parameters.AddWithValue("@title", book.BookTitle);
            }

            if (book.Price.HasValue)
            {
                update.Add("price = @price");
                query.Parameters.AddWithValue("@price", book.Price.Value);
            }

            if (book.Available.HasValue)
            {
                update.Add("available = @available");
                query.Parameters.AddWithValue("@available", book.Available.Value);
            }

            if (book.State.HasValue)
            {
                update.Add("state = @state");
                query.Parameters.AddWithValue("@state", book.State.Value.ToString());
            }

            if (book.Genre_id.HasValue)
            {
                update.Add("genre_id = @genre_id");
                query.Parameters.AddWithValue("@genre_id", book.Genre_id.Value);
            }

            if (book.Author_id.HasValue)
            {
                update.Add("author_id = @author_id");
                query.Parameters.AddWithValue("@author_id", book.Author_id.Value);
            }

            if (update.Count == 0)
            {
                return;
            }

            query.CommandText = $"update BDBbooks set {string.Join(", ", update)} where id = @id";

            query.Parameters.AddWithValue("@id", book.Book_id);

            using var conn = GetConnection();
            query.Connection = conn;
            conn.Open();
            query.ExecuteNonQuery();
        }
    }
}
