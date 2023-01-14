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
    public partial class SODashboard : Form
    {
        User user;
        ConnectionChecker cc;

        string newestRISNumber;

        //monitoring current counts
        int c_ris_count = 0;

        public SODashboard(User u)
        {
            InitializeComponent();
            user = u;
            cc = new ConnectionChecker(user);
            c_ris_count = GetRISCount();
        }

        private void SODashboard_Load(object sender, EventArgs e)
        {
            panelHeader.BackColor = Color.FromArgb(0x11, 0x46, 0x8f);

            lbl_empName.Text = $"{user.Firstname} {user.Lastname}";

            if (user.ProfileImage != null)
            {
                pictureBox2.Image = ConvertSignature.toImage(user.ProfileImage);
            }

            ShowOnlineStatus();
            timer.Start();
            timer_ris_watcher.Start();

            ShowOverview();
        }

        private void ShowOnlineStatus()
        {
            MsgrLayout msgr = new MsgrLayout(user);
            panel_usersOnlineStatus.Controls.Add(msgr);
            msgr.Show();
        }

        private void ShowOverview()
        {
            Overview overview = new Overview(user);
            panel_soBody.Controls.Add(overview);
            overview.Show();
        }

        private void ShowInventory()
        {
            Inventory inventory = new Inventory(user);
            panel_soBody.Controls.Add(inventory);
            inventory.Show();
        }

        private void ShowBulletin()
        {
            Bulletin bulletin = new Bulletin(user);
            panel_soBody.Controls.Add(bulletin);
            bulletin.Show();
        }

        private void RemoveControlsFromSOBody()
        {
            panel_soBody.Controls.Clear();
        }

        private void btn_overview_Click(object sender, EventArgs e)
        {
            RemoveControlsFromSOBody();
            ShowOverview();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            RemoveControlsFromSOBody();
            ShowInventory();
        }

        private void btn_bulletin_Click(object sender, EventArgs e)
        {
            RemoveControlsFromSOBody();
            ShowBulletin();
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

        private void LogOut()
        {
            cc.changeToOffline();
            DefaultDashboard defaultDashboard = new DefaultDashboard();
            defaultDashboard.Show();
            Close();
        }

        private void SODashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            cc.changeToOffline();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to logout?", "Logout Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                LogOut();
            }
        }

        private void SODashboard_Activated(object sender, EventArgs e)
        {
            panelHeader.BackColor = Color.FromArgb(0x11, 0x46, 0x8f);

            lbl_empName.Text = $"{user.Firstname} {user.Lastname}";

            ShowOnlineStatus();
            timer.Start();

            ShowOverview();
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
                catch (Exception ex)
                {
                    Console.WriteLine("Error getting latest RIS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Console.WriteLine("Error getting latest RIS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_createNotice_Click(object sender, EventArgs e)
        {
            NoticeCreator noticeCreator = new NoticeCreator();
            noticeCreator.ShowDialog();
        }
    }
}
