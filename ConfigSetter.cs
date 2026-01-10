using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DBBooks
{
    public class AppConfig
    {
        public string ConnectionString { get; set; }
    }

    internal class ConfigSetter
    {
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
