using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using SIMSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SIMSystem
{
    public class ConnectionChecker
    {
        readonly IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        User user;
        string host;

        public ConnectionChecker(User u)
        {
            user = u;
            var settings = config.GetRequiredSection("Settings");

            string SERVER = settings["SERVER"].ToString();
            host = SERVER;
        }

        public bool IsConnected()
        {
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 8000);
                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
            }
            catch
            {
                return result;
            }
            return result;
        }

        public void changeToOffline()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand changeToOffline = new MySqlCommand(@"
                        UPDATE User SET User.emp_isOnline = FALSE WHERE User.emp_id = '" + user.Id + "'", connection.connection);
                    changeToOffline.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                ConnectionDB.FailMessage();
            }
        }

        public void changeToOnline()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand changeToOnline = new MySqlCommand(@"
                        UPDATE User SET User.emp_isOnline = TRUE WHERE User.emp_id = '" + user.Id + "'", connection.connection);
                    changeToOnline.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                ConnectionDB.FailMessage();
            }
        }

        public int getNumberOfOnline()
        {
            int count = 0;
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getOnline = new MySqlCommand(@"
                        SELECT User.emp_id FROM User WHERE User.emp_IsOnline = TRUE", connection.connection);
                    MySqlDataReader reader = getOnline.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            count++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                ConnectionDB.FailMessage();
            }
            return count;
        }

    }
}
