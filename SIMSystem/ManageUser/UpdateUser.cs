using MySql.Data.MySqlClient;
using SIMSystem.MiniForms;
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

namespace SIMSystem.ManageUser
{
    public partial class UpdateUser : Form
    {
        User user;

        public UpdateUser(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {

        }

        private void cb_value_Validating(object sender, CancelEventArgs e)
        {
            if(cb_value.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider.SetError(cb_value, "Please select a new status.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_value, null);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                PasswordConfirmation passwordConfirmation = new PasswordConfirmation(this, user);
                passwordConfirmation.ShowDialog();
            }
        }

        private void tb_empId_Validating(object sender, CancelEventArgs e)
        {
            if (tb_empId.Text == String.Empty)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_empId, "Please provide the employee ID.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_empId, null);
            }
        }

        public void SaveUserChanges()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    string idString = tb_empId.Text.ToString();
                    string selectedItem = cb_value.SelectedItem.ToString();
                    bool activate = selectedItem == "Activate";

                    MySqlCommand updateUserCommand = new MySqlCommand(@"
                    UPDATE User SET emp_isActive = "+activate+" WHERE User.emp_id = @id", connection.connection);
                    updateUserCommand.Parameters.Add("@id", MySqlDbType.VarChar).Value = idString;
                    if (updateUserCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show($"Employee with ID \"{idString}\" has been successfully {selectedItem}d.", "Operation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Log log = new Log(user.Id, $"{selectedItem}d a user with ID: {idString}.");
                        log.Save();

                        Owner.Activate();
                        Close();
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
            }
        }
    }
}
