using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMSystem.Model
{
    public class Log
    {
        private int id;
        private string user;
        private string event_occure;
        private DateTime date;

        public Log()
        {

        }

        public Log(string userId, string event_occured)
        {
            user = userId;
            event_occure = event_occured;
        }

        public void Save()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand saveLog = new MySqlCommand(@"
                    INSERT INTO logFile(log_userId, log_event) VALUES(@user, @event)", connection.connection);
                    saveLog.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
                    saveLog.Parameters.Add("@event", MySqlDbType.VarChar).Value = event_occure;

                    saveLog.ExecuteNonQuery();
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

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public string Event_occure
        {
            get
            {
                return event_occure;
            }

            set
            {
                event_occure = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
    }
}
