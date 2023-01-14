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
    public partial class MsgrUserPlate : UserControl
    {
        User user;
        User other;
        public MsgrUserPlate(User ow, User o)
        {
            InitializeComponent();
            user = ow;
            other = o;
        }

        private void MsgrUserPlate_Load(object sender, EventArgs e)
        {
            lbl_name.Text = other.Firstname + " " + other.Lastname;
            lbl_position.Text = other.Type;
            pb_userImage.Image = other.ProfileImage == null ? Properties.Resources.user__1_ : ConvertSignature.toImage(other.ProfileImage);
            timer.Start();
        }

        private string CheckSelfStatus()
        {
            string status = "Offline";

            ConnectionChecker cc = new ConnectionChecker(other);
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand check = new MySqlCommand(@"
                    SELECT user.emp_isOnline FROM User WHERE user.emp_id = @id", connection.connection);
                    check.Parameters.Add("@id", MySqlDbType.VarChar).Value = other.Id;
                    MySqlDataReader reader = check.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (bool.Parse(reader["emp_isOnline"].ToString()))
                            {
                                status = "Online";
                            }
                            else
                            {
                                status = "Offline";
                            }
                        }
                    }
                    
                }
                catch
                {
                    status = "Offline";
                }
                finally
                {
                    connection.Close();
                }
            }
            return status;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string status = CheckSelfStatus();
            if(status == "Online")
            {
                pic_color.BackColor = Color.Green;
                //pic_msg.Enabled = true;
            }
            else
            {
                pic_color.BackColor = Color.Gray;
                //pic_msg.Enabled = false;
            }
        }

        private void pic_msg_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.OfType<Msgr>().ToList().FindAll(x => x.other == this.other);
            if(openForms.Count == 1)
            {
                openForms[0].Activate();
            }
            else
            {
                Msgr msgr = new Msgr(user, other);
                msgr.Show();
            }
            
        }
    }
}
