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

namespace SIMSystem.SODashboardComponents
{
    public partial class NoticeCreator : Form
    {
        User user;

        public NoticeCreator(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void NoticeCreator_Load(object sender, EventArgs e)
        {
            dtp_when.Format = DateTimePickerFormat.Custom;
            dtp_when.CustomFormat = "MMMM dd yyyy HH:mm";
        }

        private void tb_what_Validating(object sender, CancelEventArgs e)
        {
            if(tb_what.Text.ToString().Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_what, "Please fill the field.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_what, null);
            }
        }

        private void tb_who_Validating(object sender, CancelEventArgs e)
        {
            if (tb_who.Text.ToString().Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_who, "Please fill the field.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_who, null);
            }
        }

        private void dtp_when_Validating(object sender, CancelEventArgs e)
        {
            var invalid = DateTime.Now > DateTime.Parse(dtp_when.Value.ToString());
            if (invalid)
            {
                e.Cancel = true;
                errorProvider.SetError(dtp_when, "The date must be in the future.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(dtp_when, null);
            }
        }

        private void tb_where_Validating(object sender, CancelEventArgs e)
        {
            if (tb_where.Text.ToString().Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_where, "Please fill the field.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_where, null);
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {

        }

        private void btn_post_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled)){
                ConnectionDB connection = new ConnectionDB();
                if (connection.Open())
                {
                    try
                    {
                        MySqlCommand saveNotice = new MySqlCommand(@"
                    INSERT INTO announcement(ann_what, ann_who, ann_where, ann_when, emp_id) VALUES(@what, @who, @where, @when, @userId);", connection.connection);
                        saveNotice.Parameters.Add("@what", MySqlDbType.VarChar).Value = tb_what.Text.ToString();
                        saveNotice.Parameters.Add("@who", MySqlDbType.VarChar).Value = tb_who.Text.ToString();
                        saveNotice.Parameters.Add("@where", MySqlDbType.VarChar).Value = tb_where.Text.ToString();
                        saveNotice.Parameters.Add("@when", MySqlDbType.DateTime).Value = DateTime.Parse(dtp_when.Value.ToString());
                        saveNotice.Parameters.Add("@userId", MySqlDbType.VarChar).Value = user.Id;
                        saveNotice.ExecuteNonQuery();
                        MessageBox.Show("New announcement has been posted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving the announcement into the database.\nMessage:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
