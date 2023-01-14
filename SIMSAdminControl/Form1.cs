using MySql.Data.MySqlClient;
using SIMSystem;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace SIMSAdminControl
{
    public partial class Form1 : Form
    {
        string id, username, password, pass, firstName, lastName, email, address;

        private void tb_password_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (tb_password.Text.ToString().Length < 7)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_password, "Password must be atleast 7 characters.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_password, null);
            }
        }

        private void tb_username_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(tb_username.Text.ToString().Length < 7)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_username, "Username must be atleast 7 characters.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_username, null);
            }
        }

        private void tb_id_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_id.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tb_id, "ID must be at maximum of 12 characters.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_id, null);
            }
        }

        private void tb_emailAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string pattern = tb_emailAddress.Text.ToString();
            if(!IsValidEmail(pattern)){
                e.Cancel = true;
                errorProvider.SetError(tb_emailAddress, "Please provide a valid email address.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_emailAddress, null);
            }
        }

        private bool IsValidEmail(string emailAddress)
        {
            try
            {
                if(emailAddress.Length == 0)
                {
                    return false;
                }
                else
                {
                    MailAddress m = new MailAddress(emailAddress);
                    return true;
                }
            }
            catch (FormatException)
            {
                return false;
            }
        }

        const string type = "Admin";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_brgyTown.SelectedIndex = 0;
        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                id = tb_id.Text.ToString();
                username = tb_username.Text.ToString();
                pass = tb_password.Text.ToString();
                firstName = tb_firstName.Text.ToString();
                lastName = tb_lastName.Text.ToString();
                email = tb_emailAddress.Text.ToString();
                address = cb_brgyTown.SelectedItem.ToString() + ", " + tb_province.Text.ToString();

                password = PasswordHashAlgorithm.CalculateMD5Hash(pass);

                ConnectionDB connection = new ConnectionDB();

                if (connection.Open())
                {
                    try
                    {
                        MySqlCommand Insert_admin = new MySqlCommand(@"
                    INSERT INTO User(emp_id, emp_username, emp_password, emp_firstname, emp_lastname, emp_email, emp_address, emp_type, emp_isOnline, emp_isNotifEnabled) VALUES(@id, @username, @password, @firstName, @lastName, @email, @address, @type, FALSE, FALSE)", connection.connection);
                        Insert_admin.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                        Insert_admin.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                        Insert_admin.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                        Insert_admin.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = firstName;
                        Insert_admin.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastName;
                        Insert_admin.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                        Insert_admin.Parameters.Add("@address", MySqlDbType.VarChar).Value = address;
                        Insert_admin.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
                        Insert_admin.ExecuteNonQuery();

                        foreach (TextBox tb in this.Controls.OfType<TextBox>())
                        {
                            tb.Text = string.Empty;
                        }

                        MessageBox.Show("New Adminitrator's account has been created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (MySqlException mex)
                    {
                        if (mex.ErrorCode == -2147467259)
                        {
                            MessageBox.Show("ID is already registered as a user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
        }
    }
}