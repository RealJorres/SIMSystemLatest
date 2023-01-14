using MySql.Data.MySqlClient;
using SIMSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = SIMSystem.Model.Message;

namespace SIMSystem.MsgrForms
{
    public partial class Msgr : Form
    {
        List<Message> messages = new List<Message>();

        

        public User other;
        public User user;

        private int originalY = 13;
        private int userX = 225;
        private int otherX = 12;


        public Msgr(User u, User o)
        {
            InitializeComponent();
            user = u;
            other = o;
        }

        private void Msgr_Load(object sender, EventArgs e)
        {
            this.Text = $"{other.Firstname} {other.Lastname}";
            panel1.BackColor = Color.FromArgb(0x10,0x31,0x6b);
            panel2.BackColor = Color.FromArgb(0xfb, 0xf9, 0xfa);
            UpdateMessageBody();
            timer.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                btn_send.Enabled = false;
            }
            else
            {
                btn_send.Enabled = true;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string c = textBox1.Text.ToString();
            if (Message.MessageSent(user, other, c))
            {
                UpdateMessageBody();
                textBox1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Message not sent.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetAllMessages()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getMsgs = new MySqlCommand(@"
                    SELECT * FROM message WHERE (message_from = @from AND message_to = @to) OR (message_from = @to AND message_to = @from);", connection.connection);
                    getMsgs.Parameters.Add("@from", MySqlDbType.VarChar).Value = user.Id;
                    getMsgs.Parameters.Add("@to", MySqlDbType.VarChar).Value = other.Id;
                    MySqlDataReader reader = getMsgs.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Message message = new Message();
                            message.Id = int.Parse(reader["message_id"].ToString());
                            message.From = reader["message_from"].ToString();
                            message.To = reader["message_to"].ToString();
                            message.Content = reader["message_content"].ToString();
                            message.Date = DateTime.Parse(reader["message_date"].ToString());
                            messages.Add(message);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Failed to get all messages.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void UpdateMessageBody()
        {
            //clear the message list
            messages.Clear();

            //clear all the controls from the pnale2
            panel2.Controls.Clear();

            //get all messages
            GetAllMessages();

            //set the originalY to its default value
            originalY = 13;

            foreach (var m in messages.OrderBy(x=>x.Date))
            {
                if(m.From == user.Id && m.To == other.Id) 
                {
                    MessageUser userM = new MessageUser(m);
                    userM.Location = new Point(userX, originalY);
                    panel2.Controls.Add(userM);
                    userM.Show();

                }
                
                if(m.From == other.Id && m.To == user.Id)
                {
                    MessageOther otherM = new MessageOther(m);
                    otherM.Location = new Point(otherX, originalY);
                    panel2.Controls.Add(otherM);
                    otherM.Show();
                }
                originalY += 136;
            }
            
            if(panel2.Controls.Count > 0)
            {
                panel2.ScrollControlIntoView(panel2.Controls[panel2.Controls.Count - 1]);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int currentCount = messages.Count;
            int newCount = 0;

            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getMsgs = new MySqlCommand(@"
                    SELECT * FROM message WHERE (message_from = @from AND message_to = @to) OR (message_from = @to AND message_to = @from);", connection.connection);
                    getMsgs.Parameters.Add("@from", MySqlDbType.VarChar).Value = user.Id;
                    getMsgs.Parameters.Add("@to", MySqlDbType.VarChar).Value = other.Id;
                    MySqlDataReader reader = getMsgs.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            newCount += 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to get all messages.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if(currentCount < newCount)
            {
                UpdateMessageBody();
            }
        }
    }
}
