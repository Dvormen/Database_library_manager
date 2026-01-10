using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DBBooks
{
    /// <summary>
    /// Represents application configuration settings.
    /// </summary>
    public class AppConfig
    {
        public string ConnectionString { get; set; }
    }
    /// <summary>
    /// Provides methods to create database connections using configuration.
    /// </summary>
    internal class ConfigSetter
    {
        /// <summary>
        /// Creates and returns a new SQL database connection using the connection string from appsettings.json.
        /// </summary>
        /// <returns>A SqlConnection object initialized with the connection string.</returns>
        public static SqlConnection GetConnection()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

            if (!File.Exists(path))
            {
                MessageBox.Show("Configuration file appsettings.json not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Environment.Exit(1);
            }

            var json = File.ReadAllText(path);
            var appConfig = JsonSerializer.Deserialize<AppConfig>(json);
            return new SqlConnection(appConfig.ConnectionString);
        }
    }
}
