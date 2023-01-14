using MySql.Data.MySqlClient;
using SIMSystem.Forms;
using SIMSystem.MiniForms;
using SIMSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMSystem.ManageUser
{
    public partial class AddUser : Form
    {
        Point current = new Point();
        Point old = new Point();
        Graphics g;
        Graphics g2;
        Pen p = new Pen(Color.Black, 11);
        Bitmap surface;

        byte[] emptyCanvas;
        byte[] signature;

        User emp;

        List<string> names = new List<string>();
        string name;

        public AddUser(User u)
        {
            InitializeComponent();
            emp = u;

            g = panel_sigCanvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            surface = new Bitmap(panel_sigCanvas.Width, panel_sigCanvas.Height);
            g2 = Graphics.FromImage(surface);
            panel_sigCanvas.BackgroundImage = surface;
            panel_sigCanvas.BackgroundImageLayout = ImageLayout.None;
            p.Width = (float)2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                PasswordConfirmation passwordConfirmation = new PasswordConfirmation(this, emp);
                passwordConfirmation.ShowDialog();

            }
        }

        public void AddUserToDb()
        {
            //get all values into a variable
            string id = tb_empId.Text.ToString();
            string user = tb_username.Text.ToString();
            string password = tb_password.Text.ToString();
            string firstname = tb_firstName.Text.ToString();
            string lastname = tb_lastName.Text.ToString();
            string email = tb_email.Text.ToString();
            string address = cb_address.SelectedItem.ToString();
            string type = cb_empType.SelectedItem.ToString();
            bool notif = cb_notification.SelectedItem.ToString() == "ON";
            string pass = PasswordHashAlgorithm.CalculateMD5Hash(password);

            ConnectionDB connection = new ConnectionDB();
            try
            {
                if (connection.Open())
                {
                    using (MySqlCommand Add_user = new MySqlCommand(@"
                        INSERT INTO User(emp_id, emp_username, emp_password, emp_firstname, emp_lastname, emp_email, emp_address, emp_type, emp_isNotifEnabled, emp_signature) 
                        VALUES('" + id + "', '" + user + "', '" + pass + "', '" + firstname + "', '" + lastname + "', '" + email + "', '" + address + "', '" + type + "', " + notif + ", @sig)", connection.connection))
                    {
                        Add_user.Parameters.Add("@sig", MySqlDbType.MediumBlob).Value = signature;
                        if (Add_user.ExecuteNonQuery() > 0)
                        {
                            SendEmailNotif();
                            MessageBox.Show("Successfully added a new user.", "New User added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Log log = new Log(emp.Id, $"Added a new user with ID: {id}.");
                            log.Save();

                            Form form = new AdminDashboard(emp);
                            form.Activate();
                            Close();
                        }
                    }
                }
                else
                {
                    ConnectionDB.FailMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                connection.Close();
            }
        }

        private void tb_empId_Validating(object sender, CancelEventArgs e)
        {
            if(tb_empId.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_empId, "Please fill-up this field.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_empId, null);
            }
        }

        private void tb_firstName_Validating(object sender, CancelEventArgs e)
        {
            if (tb_firstName.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_firstName, "Please fill-up this field.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_firstName, null);
            }
        }

        private void tb_lastName_Validating(object sender, CancelEventArgs e)
        {
            if (tb_lastName.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_lastName, "Please fill-up this field.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_lastName, null);
            }
        }

        private void cb_address_Validating(object sender, CancelEventArgs e)
        {
            if(cb_address.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider.SetError(cb_address, "Please select an address from the dropdown.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_address, null);
            }
        }

        private void tb_email_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidEmail(tb_email.Text.ToString()) == false)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_email, "Please provide a valid email address.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_email, null);
            }
        }

        private void cb_empType_Validating(object sender, CancelEventArgs e)
        {
            if (cb_empType.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider.SetError(cb_empType, "Please select an employee type from the dropdown.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_empType, null);
            }
        }

        private void cb_notification_Validating(object sender, CancelEventArgs e)
        {
            if (cb_notification.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider.SetError(cb_notification, "Please select an item from the dropdown.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_notification, null);
            }
        }

        private void tb_username_Validating(object sender, CancelEventArgs e)
        {
            if(tb_username.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_username, "Please fill-up this field.");
            }
            else
            {
                if (inNames())
                {
                    e.Cancel = true;
                    errorProvider.SetError(tb_username, "Username is already in use. Please provide a different one.");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(tb_username, null);
                }
            }
        }

        private bool inNames()
        {
            foreach(string n in names)
            {
                if (tb_username.Text.ToString() == n)
                {
                    return true;
                }
            }
            return false;
        }

        private void tb_password_Validating(object sender, CancelEventArgs e)
        {
            if(tb_password.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_password, "Please fill-up this field.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_password, null);
            }
        }

        private void tb_confirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(tb_password.Text != tb_confirmPassword.Text)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_confirmPassword, "Password does not match.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_confirmPassword, null);
            }
        }

        private void panel_sigCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void panel_sigCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(p, old, current);
                g2.DrawLine(p, old, current);

                old = current;
            }
        }

        private void panel_sigCanvas_Validating(object sender, CancelEventArgs e)
        {
            signature = ConvertSignature.toBinaryArray(surface, ImageFormat.Png);
            if(signature.Length == emptyCanvas.Length)
            {
                e.Cancel = true;
                errorProvider.SetError(lbl_signature, "Please provide a signature.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(lbl_signature, null);
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            emptyCanvas = ConvertSignature.toBinaryArray(surface, ImageFormat.Png);

            GetAllNames();
        }

        private void GetAllNames()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getNames = new MySqlCommand(@"
                    SELECT user.emp_userName FROM user", connection.connection);
                    MySqlDataReader reader = getNames.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            name = reader["emp_userName"].ToString();
                            names.Add(name);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ConnectionDB.FailMessage();
            }
        }

        public bool IsValidEmail(string emailaddress)
        {
            try
            {
                if(emailaddress.Length  == 0)
                {
                    return false;
                }
                else
                {
                    MailAddress m = new MailAddress(emailaddress);
                    return true;
                }
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void SendEmailNotif()
        {
            try
            {
                SendEmail email = new SendEmail();
                email.SendAfterRegister(tb_email.Text.Trim(), tb_firstName.Text.Trim(), tb_username.Text.Trim(), tb_password.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
