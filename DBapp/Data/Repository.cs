using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DBBooks.Data
{
    /// <summary>
    /// Base repository class providing shared functionality for all repositories.
    /// </summary>
    internal abstract class Repository
    {
        protected string connectionString;

        /// <summary>
        /// Loads application configuration from appsettings.json.
        /// </summary>
        /// <returns>An AppConfig object containing the configuration settings.</returns>
        public static AppConfig Load()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");

            if (!File.Exists(path))
            {
                MessageBox.Show("Configuration file appsettings.json not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Environment.Exit(1);
            }

            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<AppConfig>(json);
        }
    }
}
