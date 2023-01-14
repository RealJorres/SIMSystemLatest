using MimeKit;
using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace SIMSystem
{
    class SendEmail
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        MimeMessage message = new MimeMessage();
        SmtpClient client = new SmtpClient();
        string myemail;
        string mypass;
        string host;
        int port;

        public SendEmail()
        {
            var settings = config.GetRequiredSection("Email");

            myemail = settings["EMAIL"].ToString();
            mypass = settings["PASSWORD"].ToString();
            host = settings["HOST"].ToString();
            port = int.Parse(settings["PORT"].ToString());

        }

        public List<string> GetAllEmails(string exemptedEmail)
        {
            List<string> emails = new List<string>();

            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getAllEmails = new MySqlCommand(@"
                    SELECT emp_email FROM User WHERE emp_email != @email;", connection.connection);
                    getAllEmails.Parameters.Add("@email", MySqlDbType.VarChar).Value = exemptedEmail;
                    MySqlDataReader reader = getAllEmails.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                           string email = reader["emp_email"].ToString();
                            emails.Add(email);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error getting css email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            return emails;
        }

        public string GetSOEmail()
        {
            string email = "";
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getSOEmail = new MySqlCommand(@"
                    SELECT emp_email FROM User WHERE emp_type = 'Supply Officer';", connection.connection);
                    MySqlDataReader reader = getSOEmail.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            email = reader["emp_email"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error getting css email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            return email;
        }

        public string GetCSSEmail()
        {
            string email = "";
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getCssEmail = new MySqlCommand(@"
                    SELECT emp_email FROM User WHERE emp_type = 'Chief Statistical Specialist';", connection.connection);
                    MySqlDataReader reader = getCssEmail.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            email = reader["emp_email"].ToString();
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error getting css email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            return email;
        }

        public void SendAfterRegister(string email, string firstname, string username, string password)
        {
            message.From.Add(new MailboxAddress("SIMS Admin", myemail));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = "SIMS Credentials";

            BodyBuilder builder = new BodyBuilder();
            builder.HtmlBody = $@"
            <h3>Hello {firstname},</h3>
            <p><b>You have been registered to PSA-SIMSystem successfully.</b></p>
            <p><b>Your login credentials are provided below.</b></p>
            <br>
            <p><b>Username: </b>{username}</p>
            <p><b>Password: </b>{password}</p>
            <br>
            <p><i>-SIMSystem Automated Email</i></p>";

            message.Body = builder.ToMessageBody();

            try
            {
                client.Connect(host, port, true);
                client.Authenticate(myemail, mypass);
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }

        public void SendAfterUpdate(string email, string firstname, string toUpdate, string oldInfo, string newInfo)
        {
            message.From.Add(new MailboxAddress("SIMS Admin", myemail));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = "SIMS Information Update";
            
            BodyBuilder builder = new BodyBuilder();
            builder.HtmlBody = $@"
                <h3>Hello {firstname},</h3>
                <p><b>Your {toUpdate} has been updated.</b></p>
                <br>
                <p><b>Old data: </b>{oldInfo}</p>
                <p><b>New data: </b>{newInfo}</p>
                <br>
                <p><i>-SIMSystem Automated Email</i></p>";

            message.Body = builder.ToMessageBody();

            try
            {
                client.Connect(host, port, true);
                client.Authenticate(myemail, mypass);
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }

        public void SendAfterCreatingNotice(string email, string body, string createdBy)
        {
            message.From.Add(new MailboxAddress("SIMS Admin", myemail));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = "New Notice";
            
            BodyBuilder builder = new BodyBuilder();
            builder.HtmlBody = $@"
                <h3>Good day,</h3>
                <p><b>A new notice has been posted in SIMS Bulletin by {createdBy}.</b></p>
                <br>
                <p><b>Content:</b></p>
                <p><i>{body}</i></p>
                <br>
                <p><i>-SIMSystem Automated Email</i></p>";

            message.Body = builder.ToMessageBody();

            try
            {
                client.Connect(host, port, true);
                client.Authenticate(myemail, mypass);
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }

        public void SendAfterCreatingRIS(string email, string createdBy)
        {
            message.From.Add(new MailboxAddress("SIMS Admin", myemail));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = "New Requisition and Issue Slip";

            BodyBuilder builder = new BodyBuilder();
            builder.HtmlBody = $@"<h3>Good day,</h3>
                <p><b>A new RIS has been created by {createdBy}.</b></p>
                <br>
                <br>
                <p><i>-SIMSystem Automated Email</i></p>";

            message.Body = builder.ToMessageBody();

            try
            {
                client.Connect(host, port, true);
                client.Authenticate(myemail, mypass);
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally
            {
                client.Disconnect(true);
                client.Dispose();
            }
        }
    }
}
