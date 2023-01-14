using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMSystem.Model
{
    public class Message
    {
        private int id;
        private string from;
        private string to;
        private string content;
        private DateTime date;

        public Message()
        {

        }

        public static bool MessageSent(User f, User t, string c)
        {
            bool isSent = false;
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand sendMessage = new MySqlCommand(@"
                    INSERT INTO message(message_from, message_to, message_content) VALUES(@from, @to, @content);", connection.connection);
                    sendMessage.Parameters.Add("@from", MySqlDbType.VarChar).Value = f.Id;
                    sendMessage.Parameters.Add("@to", MySqlDbType.VarChar).Value = t.Id;
                    sendMessage.Parameters.Add("@content", MySqlDbType.VarChar).Value = c;
                    sendMessage.ExecuteNonQuery();
                    isSent = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    isSent = false;
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                ConnectionDB.FailMessage();
                isSent = false;
            }
            return isSent;
        }

        public int Id { get => id; set => id = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public string Content { get => content; set => content = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
