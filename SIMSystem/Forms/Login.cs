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

namespace SIMSystem.Forms
{
    public partial class Login : Form
    {
        User user;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(tb_username.Text.ToString() == String.Empty || tb_password.Text.ToString() == String.Empty)
            {
                lbl_errorMessage.Text = "Empty field is not allowed. Please input your username and password.";
                panel_errorModal.Visible = true;
                return;
            }


            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    string username = tb_username.Text.ToString();
                    string password = PasswordHashAlgorithm.CalculateMD5Hash(tb_password.Text.ToString());

                    MySqlCommand searchUser = new MySqlCommand(@"
                    SELECT * FROM user WHERE user.emp_userName = @username AND user.emp_password = @password", connection.connection);
                    searchUser.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                    searchUser.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                    MySqlDataReader dataReader = searchUser.ExecuteReader();

                    if (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            user = new User();
                            user.Id = dataReader["emp_id"].ToString();
                            user.Firstname = dataReader["emp_firstName"].ToString();
                            user.Lastname = dataReader["emp_lastName"].ToString();
                            user.ProfileImage = dataReader["emp_profileImage"].ToString() == ""? null : (byte[])dataReader["emp_profileImage"];
                            user.Username = dataReader["emp_userName"].ToString();
                            user.Password = dataReader["emp_password"].ToString();
                            user.Address = dataReader["emp_address"].ToString();
                            user.Email = dataReader["emp_email"].ToString();
                            user.Type = dataReader["emp_type"].ToString();
                            if(user.Type != "Admin")
                            {
                                user.Signature = (byte[])dataReader["emp_signature"];
                                
                            }

                        }
                    }
                    else
                    {
                        panel_errorModal.Visible = true;
                        return;
                    }

                    if(user != null)
                    {
                        if(user.Type == "Admin")
                        {
                            AdminDashboard adminDashboard = new AdminDashboard(user);
                            adminDashboard.Show();
                            Owner.Close();
                            Close();
                        }
                        else if(user.Type == "Supply Officer")
                        {
                            SODashboard sODashboard = new SODashboard(user);
                            sODashboard.Show();
                            Owner.Close();
                            Close();
                        }
                        else if(user.Type == "Chief Statistical Specialist")
                        {
                            CSSDashboard cSSDashboard = new CSSDashboard(user);
                            cSSDashboard.Show();
                            Owner.Close();
                            Close();
                        }
                        else if(user.Type == "Regular Employee")
                        {
                            RegularDashboard regularDashboard = new RegularDashboard(user);
                            regularDashboard.Show();
                            Owner.Close();
                            Close();
                        }
                    }
                }
                catch(Exception ex)
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
                return;
            }
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {
            panel_errorModal.Visible = false;
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            panel_errorModal.Visible = false;
        }

        private void cb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showPassword.Checked)
            {
                tb_password.PasswordChar = '\0';
            }
            else
            {
                tb_password.PasswordChar = '•';
            }
        }
    }
}
