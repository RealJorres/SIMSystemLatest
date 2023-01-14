using MySql.Data.MySqlClient;
using SIMSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMSystem.MiniForms
{
    public partial class UserMiniPlate : UserControl
    {
        User user;
        User emp;

        public UserMiniPlate(User u, User emp)
        {
            InitializeComponent();
            user = u;
            this.emp = emp;
        }

        private void UserMiniPlate_Load(object sender, EventArgs e)
        {
            tb_name.Text = user.Firstname + " " + user.Lastname;
            tb_email.Text = user.Email;
            cb_type.SelectedItem = user.Type;
            cb_isNotifEnabled.SelectedItem = user.IsNotifEnabled ? "Yes" : "No";
        }

        private void link_edit_Click(object sender, EventArgs e)
        {
            if(link_edit.Text == "Edit")
            {
                link_edit.Text = "Cancel";
                btn_save.Visible = true;
                tb_email.ReadOnly = false;
                cb_type.Enabled = true;
                cb_isNotifEnabled.Enabled = true;
            }
            else
            {
                link_edit.Text = "Edit";
                btn_save.Visible = false;
                tb_email.ReadOnly = true;
                cb_type.Enabled = false;
                cb_isNotifEnabled.Enabled = false;

                tb_name.Text = user.Firstname + " " + user.Lastname;
                tb_email.Text = user.Email;
                cb_type.SelectedItem = user.Type;
                cb_isNotifEnabled.SelectedItem = user.IsNotifEnabled ? "Yes" : "No";
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            PasswordConfirmation passwordConfirmation = new PasswordConfirmation(this, emp);
            passwordConfirmation.ShowDialog();
        }

        public void SaveUserChanges()
        {
            Debug.WriteLine($"User: {user.Firstname} has been updated");

            link_edit.Text = "Edit";
            btn_save.Visible = false;
            tb_email.ReadOnly = true;
            cb_type.Enabled = false;
            cb_isNotifEnabled.Enabled = false;

            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    string email = tb_email.Text.ToString();
                    string type = cb_type.SelectedItem.ToString();
                    bool isnotif = cb_isNotifEnabled.SelectedItem.ToString() == "Yes" ? true:false;

                    MySqlCommand saveChanges = new MySqlCommand(@"
                    UPDATE user SET user.emp_email = @email, user.emp_type = @type, user.emp_isNotifEnabled = "+isnotif+" WHERE user.emp_id = @id", connection.connection);
                    saveChanges.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                    saveChanges.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
                    saveChanges.Parameters.Add("@id", MySqlDbType.VarChar).Value = user.Id;
                    saveChanges.ExecuteNonQuery();
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
