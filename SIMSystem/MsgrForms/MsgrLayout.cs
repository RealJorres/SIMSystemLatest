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

namespace SIMSystem.MsgrForms
{
    public partial class MsgrLayout : UserControl
    {
        User user, owner;
        List<User> users = new List<User>();

        

        public MsgrLayout(User ow)
        {
            InitializeComponent();
            owner = ow;
        }

        private void MsgrLayout_Load(object sender, EventArgs e)
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getAllUser = new MySqlCommand(@"
                    SELECT * FROM User WHERE User.emp_id != @id AND user.emp_type != 'Admin';", connection.connection);
                    getAllUser.Parameters.Add("@id", MySqlDbType.VarChar).Value = owner.Id;
                    MySqlDataReader reader = getAllUser.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            user = new User();
                            user.Id = reader[0].ToString();
                            user.Firstname = reader["emp_firstName"].ToString();
                            user.Lastname = reader["emp_lastName"].ToString();
                            user.ProfileImage = reader["emp_profileImage"].ToString() == "" ? null : (byte[])reader["emp_profileImage"];
                            user.Type = reader["emp_type"].ToString();
                            users.Add(user);
                        }

                        foreach(User u in users.OrderByDescending(x=>x.Type))
                        {
                            MsgrUserPlate msgrup = new MsgrUserPlate(owner, u);
                            Controls.Add(msgrup);
                            msgrup.Dock = DockStyle.Top;
                            msgrup.Show();
                        }

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ConnectionDB.FailMessage();
            }
        }
    }
}
