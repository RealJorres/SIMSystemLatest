using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.JsonParser;

namespace SIMSystem
{
    public class ConnectionDB
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional:true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();
        public MySqlConnection connection;

        public ConnectionDB()
        {
            var settings = config.GetRequiredSection("Settings");

            string SERVER = settings["SERVER"].ToString();
            string DATABASE = settings["DATABASE"].ToString();
            string USERNAME = settings["USERNAME"].ToString();
            string PASSWORD = settings["PASSWORD"].ToString();


            string string_con = string.Format("server={0};database={1};uid={2};password={3}", SERVER, DATABASE, USERNAME, PASSWORD);
            connection = new MySqlConnection(string_con);
        }

        public bool Open()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Close()
        {
            connection.Close();
        }

        public static void FailMessage()
        {
            MessageBox.Show("Cannot connect to the database.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
