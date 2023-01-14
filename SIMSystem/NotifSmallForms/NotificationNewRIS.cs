using MySql.Data.MySqlClient;
using SIMSystem.Model;
using SIMSystem.SODashboardComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMSystem.NotifSmallForms
{
    public partial class NotificationNewRIS : Form
    {
        User user;
        string risnumber;
        public NotificationNewRIS(User u, string number)
        {
            InitializeComponent();
            user = u;
            risnumber = number;

        }

        private void NotificationNewRIS_Load(object sender, EventArgs e)
        {
            pb_icon.Image = SystemIcons.Information.ToBitmap();
            label2.Text = $"RIS: {risnumber}";

            var screen = Screen.FromPoint(this.Location);
            Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);
            timer.Start();
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 12);
            await Task.Delay(ts);
            Close();
            timer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(GetRIS() != null)
            {
                RISPreview rISPreview = new RISPreview(user, GetRIS());
                rISPreview.Show();
            }
        }

        private RIS? GetRIS()
        {
            RIS? ris = null;
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(@"
                    SELECT * FROM requisitionissueslip WHERE ris_number = @num LIMIT 1;", connection.connection);
                    cmd.Parameters.Add("@num", MySqlDbType.VarChar).Value = risnumber;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ris = new RIS();
                            ris.Number = reader["ris_number"].ToString();
                            ris.RequesterId = reader["ris_requesterId"].ToString();
                            ris.EntityName = reader["ris_entityName"].ToString();
                            ris.Division = reader["ris_division"].ToString();
                            ris.Office = reader["ris_office"].ToString();
                            ris.FundCluster = reader["ris_fundCluster"].ToString();
                            ris.Purpose = reader["ris_purpose"].ToString();
                            ris.Date = DateTime.Parse(reader["ris_date"].ToString());
                            ris.IsApproved = bool.Parse(reader["ris_isApproved"].ToString());
                            ris.IsPending = bool.Parse(reader["ris_isPending"].ToString());
                            ris.Rejectnote = reader["ris_rejectnote"].ToString();
                            ris.Sodate = reader["ris_sodate"].ToString() == "" ? null : DateTime.Parse(reader["ris_sodate"].ToString());
                            ris.Cssdate = reader["ris_cssdate"].ToString() == "" ? null : DateTime.Parse(reader["ris_cssdate"].ToString());
                        }
                    }
                    else
                    {
                        ris = null;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error getting the new RIS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ris = null;
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                ConnectionDB.FailMessage();
                ris = null;
            }


            return ris;
        }
    }
}
