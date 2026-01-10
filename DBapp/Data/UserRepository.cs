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
    /// <summary>
    /// Repository class for managing User entities.
    /// </summary>
    internal class UserRepository : Repository, IRepository<User>
    {
        /// <summary>
        /// Adds a new user to the database.
        /// </summary>
        /// <param name="user">User entity to be added.</param>
        public void Add(User user)
        {
            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("insert into BDBuser(username, email) values (@username,@email)", conn);

            query.Parameters.AddWithValue("@username", user.Username);
            query.Parameters.AddWithValue("@email", user.Email);

            conn.Open();
            query.ExecuteNonQuery();
        }

        /// <summary>
        /// Deletes a user from the database by ID.
        /// </summary>
        /// <param name="id">ID of the user to delete.</param>
        public void Delete(int id)
        {
            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("delete from BDBuser where id = @id", conn);

            query.Parameters.AddWithValue("@id", id);

            conn.Open();
            query.ExecuteNonQuery();
        }

        /// <summary>
        /// Retrieves all users from the database.
        /// </summary>
        /// <returns>List of all users.</returns>
        public List<User> GetAll()
        {
            var users = new List<User>();

            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("select * from BDBuser", conn);

            conn.Open();
            using var reader = query.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User
                {
                    User_id = reader.GetInt32(0),
                    Username = reader.GetString(1),
                    Email = reader.GetString(2)
                });
            }

            return users;
        }

        /// <summary>
        /// Retrieves a user by its ID.
        /// </summary>
        /// <param name="id">ID of the user.</param>
        /// <returns>The user if found; otherwise null.</returns>
        public User? GetById(int id)
        {
            using var conn = ConfigSetter.GetConnection();
            using var query = new SqlCommand("select * from BDBuser where id = @id", conn);

            query.Parameters.AddWithValue("@id", id);
            conn.Open();

            using var reader = query.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            var member = new User
            {
                User_id = reader.GetInt32(0),
                Username = reader.GetString(1),
                Email = reader.GetString(2)
            };

            return member;
        }

        /// <summary>
        /// Updates an existing user in the database.
        /// </summary>
        /// <param name="user">User entity containing updated values.</param>
        public void Update(User user)
        {
            var update = new List<string>();
            var query = new SqlCommand();

            if (!string.IsNullOrWhiteSpace(user.Username))
            {
                update.Add("username = @username");
                query.Parameters.AddWithValue("@username", user.Username);
            }

            if (!string.IsNullOrWhiteSpace(user.Email))
            {
                update.Add("email = @email");
                query.Parameters.AddWithValue("@email", user.Email);
            }

            if (update.Count == 0)
            {
                return;
            }

            query.CommandText = $"update BDBuser set {string.Join(", ", update)} where id = @id";

            query.Parameters.AddWithValue("@id", user.User_id);

            using var connection = ConfigSetter.GetConnection();
            query.Connection = connection;
            connection.Open();
            query.ExecuteNonQuery();
        }
    }
}
