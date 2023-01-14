using MySql.Data.MySqlClient;
using SIMSystem.Model;
using SIMSystem.MsgrForms;
using SIMSystem.NotifSmallForms;
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

namespace SIMSystem.Forms
{
    public partial class CSSDashboard : Form
    {
        User user;
        ConnectionChecker cc;

        string newestRISNumber;

        //monitoring current counts
        int c_ris_count = 0;

        public CSSDashboard(User u)
        {
            InitializeComponent();
            user = u;
            cc = new ConnectionChecker(user);
            c_ris_count = GetRISCount();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (cc.IsConnected())
            {
                cc.changeToOnline();
            }
            else
            {
                LogOut();
            }
        }

        private void CSSDashboard_Load(object sender, EventArgs e)
        {
            panelHeader.BackColor = Color.FromArgb(0x11, 0x46, 0x8f);

            lbl_empName.Text = $"{user.Firstname} {user.Lastname}";
            
            if(user.ProfileImage != null)
            {
                pictureBox2.Image = ConvertSignature.toImage(user.ProfileImage);
            }


            ShowOnlineStatus();
            timer.Start();
            timer_ris_watcher.Start();

            ShowOverview();
        }

        private void ShowOverview()
        {
            Overview overview = new Overview(user);
            panel_cssBody.Controls.Add(overview);
            overview.Show();
        }

        private void ShowOnlineStatus()
        {
            MsgrLayout msgr = new MsgrLayout(user);
            panel_usersOnlineStatus.Controls.Add(msgr);
            msgr.Show();
        }

        private void LogOut()
        {
            cc.changeToOffline();
            DefaultDashboard defaultDashboard = new DefaultDashboard();
            defaultDashboard.Show();
            Close();
        }

        private void CSSDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            cc.changeToOffline();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to logout?", "Logout Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                LogOut();
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to logout?", "Logout Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                LogOut();
            }
        }

        private void btn_overview_Click(object sender, EventArgs e)
        {
            Overview overview = new Overview(user);
            panel_cssBody.Controls.Add(overview);
            overview.BringToFront();
            overview.Show();
        }

        private void btn_bulletin_Click(object sender, EventArgs e)
        {
            Bulletin bulletin = new Bulletin(user);
            panel_cssBody.Controls.Add(bulletin);
            bulletin.BringToFront();
            bulletin.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserProfileCard userProfile = new UserProfileCard(user);
            userProfile.Show();
            
        }

        private void timer_ris_watcher_Tick(object sender, EventArgs e)
        {
            int newCount = GetRISCount();
            if (newCount > c_ris_count)
            {
                GetNEwestRis();
                c_ris_count = newCount;
                NotificationNewRIS notificationNewRIS = new NotificationNewRIS(user, newestRISNumber);
                notificationNewRIS.Show();
            }
        }

        private void GetNEwestRis()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getLatest = new MySqlCommand(@"
                    SELECT * FROM requisitionissueslip ORDER BY ris_date DESC LIMIT 1", connection.connection);
                    MySqlDataReader reader = getLatest.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            newestRISNumber = reader["ris_number"].ToString();
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error getting latest RIS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private int GetRISCount()
        {
            int count = 0;
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getLatest = new MySqlCommand(@"
                    SELECT * FROM requisitionissueslip;", connection.connection);
                    MySqlDataReader reader = getLatest.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            count += 1;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error getting latest RIS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return count;
        }
    }
}
