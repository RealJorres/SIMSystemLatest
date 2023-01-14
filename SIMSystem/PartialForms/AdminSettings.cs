using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMSystem.PartialForms
{
    public partial class AdminSettings : Form
    {
        public AdminSettings()
        {
            InitializeComponent();
        }

        private void AdminSettings_Load(object sender, EventArgs e)
        {
            tb_currentCount.Text = GetCurrentRisCount() != "null" ? GetCurrentRisCount() : "0"; 
        }

        private string GetCurrentRisCount()
        {
            string criscount = "";

            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    connection.Open();
                    MySqlCommand getriscount = new MySqlCommand(@"
                    SELECT autodocid.auto_count FROM autodocid WHERE autodocid.auto_type = 'RIS'", connection.connection);
                    MySqlDataReader reader = getriscount.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            criscount = reader["auto_count"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Auto ID is not set yet.", "No CURRENT COUNT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    criscount = "null";
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                ConnectionDB.FailMessage();
                criscount = "null";
            }

            return criscount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Edit")
            {
                tb_currentCount.ReadOnly = false;
                button1.Text = "Save";
            }
            else
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    tb_currentCount.ReadOnly = true;
                    button1.Text = "Edit";
                    ChangeCurrentCount();
                }
            }
        }

        private void ChangeCurrentCount()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand updateCount = new MySqlCommand(@"
                    UPDATE autodocid SET auto_count = @newCount WHERE auto_id = 1", connection.connection);
                    updateCount.Parameters.Add("@newCount", MySqlDbType.Int32).Value = int.Parse(tb_currentCount.Text.ToString());
                    if(updateCount.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("New Count Saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tb_currentCount_Validating(object sender, CancelEventArgs e)
        {
            int num;
            var ok = int.TryParse(tb_currentCount.Text.ToString(), out num);
            if (ok)
            {
                e.Cancel = false;
                errorProvider.SetError(tb_currentCount, null);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(tb_currentCount, "Please provide a valid number.");
            }
        }
    }
}
