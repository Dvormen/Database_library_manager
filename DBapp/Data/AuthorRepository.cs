using DBBooks.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DBBooks.Data
{
    internal class AuthorRepository : Repository, IRepository<Author>
    {
        public void Add(Author author)
        {
            using var conn = GetConnection();
            using var query = new SqlCommand("insert into BDBauthor(firstName, lastName) values (@firstName, @lastName)", conn);

            query.Parameters.AddWithValue("@firstName", author.FirstName);
            query.Parameters.AddWithValue("@lastName", author.LastName);

            conn.Open();
            query.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = GetConnection();
            using var query = new SqlCommand("delete from BDBauthor where id = @id", conn);

            query.Parameters.AddWithValue("@id", id);

            conn.Open();
            query.ExecuteNonQuery();
        }

        public List<Author> GetAll()
        {
            var authors = new List<Author>();

            using var conn = GetConnection();
            using var query = new SqlCommand("select * from BDBauthor", conn);

            conn.Open();
            using var reader = query.ExecuteReader();

            while (reader.Read())
            {
                authors.Add(new Author
                {
                    Author_id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2)
                });
            }

            return authors;
        }

        public Author? GetById(int id)
        {
            using var conn = GetConnection();
            using var query = new SqlCommand("select * from BDBauthor where id = @id", conn);

            query.Parameters.AddWithValue("@id", id);

            conn.Open();
            using var reader = query.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            var author = new Author
            {
                Author_id = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2)
            };

            return author;
        }

        public void Update(Author author)
        {
            var update = new List<string>();
            var query = new SqlCommand();

            if (!string.IsNullOrWhiteSpace(author.FirstName))
            {
                update.Add("firstName = @firstName");
                query.Parameters.AddWithValue("@firstName", author.FirstName);
            }

            if (!string.IsNullOrWhiteSpace(author.LastName))
            {
                update.Add("lastName = @lastName");
                query.Parameters.AddWithValue("@lastName", author.LastName);
            }

            if (update.Count == 0)
            {
                return;
            }

            query.CommandText = $"update BDBauthor set {string.Join(", ", update)} where id = @id";

            query.Parameters.AddWithValue("@id", author.Author_id);

            using var conn = GetConnection();
            query.Connection = conn;
            conn.Open();
            query.ExecuteNonQuery();
        }

        public void CsvImportAuthors(string filePath)
        {
            using var conn = GetConnection();
            conn.Open();

            using var tran = conn.BeginTransaction();

            try
            {
                var lines = File.ReadAllLines(filePath);

                for (int i = 1; i < lines.Length; i++)
                {
                    var parts = lines[i].Split(',');

                    if (parts.Length != 2)
                    {
                        continue;
                    }

                    var cmd = new SqlCommand("insert into BDBauthor (firstName, lastName) values (@firstName, @lastName)", conn, tran);

                    cmd.Parameters.AddWithValue("@firstName", parts[0].Trim());
                    cmd.Parameters.AddWithValue("@lastName", parts[1].Trim());

                    cmd.ExecuteNonQuery();
                }

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
