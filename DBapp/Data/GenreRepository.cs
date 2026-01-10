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
    internal class GenreRepository : Repository, IRepository<Tables.Genre>
    {
        public void Add(Genre genre)
        {
            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("insert into BDBgenre(genre) value (@genre)", conn);

            query.Parameters.AddWithValue("@genre", genre.GenreName);

            conn.Open();
            query.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("delete from BDBgenre where id = @id", conn);

            query.Parameters.AddWithValue("@id", id);

            conn.Open();
            query.ExecuteNonQuery();
        }

        public List<Genre> GetAll()
        {
            var genres = new List<Genre>();

            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("select * from BDBgenre", conn);

            conn.Open();
            using var reader = query.ExecuteReader();

            while (reader.Read())
            {
                genres.Add(new Genre
                {
                    Genre_id = reader.GetInt32(0),
                    GenreName = reader.GetString(1)
                });
            }

            return genres;
        }

        public Genre? GetById(int id)
        {
            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("select * from BDBgenre where id = @id", conn);

            query.Parameters.AddWithValue("@id", id);

            conn.Open();
            using var reader = query.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            var category = new Genre
            {
                Genre_id = reader.GetInt32(0),
                GenreName = reader.GetString(1)
            };

            return category;
        }

        public void Update(Genre genre)
        {
            var update = new List<string>();
            var query = new SqlCommand();

            if (!string.IsNullOrEmpty(genre.GenreName))
            {
                update.Add("genre = @genre");
                query.Parameters.AddWithValue("@genre", genre.GenreName);
            }

            if (update.Count == 0)
            {
                return;
            }

            query.CommandText = $"update BDBgenre set {string.Join(", ", update)} where id = @id";

            query.Parameters.AddWithValue("@id", genre.Genre_id);

            using var connection = ConfigSetter.GetConnection();
            query.Connection = connection;
            connection.Open();
            query.ExecuteNonQuery();
        }

        public void CsvImportGenre(string filePath)
        {
            using var conn = ConfigSetter.GetConnection();
            conn.Open();

            using var tran = conn.BeginTransaction();

            try
            {
                var lines = File.ReadAllLines(filePath);

                for (int i = 1; i < lines.Length; i++)
                {
                    var genre = lines[i].Trim();

                    if (string.IsNullOrWhiteSpace(genre))
                    {
                        continue;
                    }

                    var cmd = new SqlCommand("insert into BDBgenre (genre) values (@genre)", conn, tran);

                    cmd.Parameters.AddWithValue("@genre", genre);
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
