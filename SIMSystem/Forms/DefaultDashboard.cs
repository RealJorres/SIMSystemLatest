using MySql.Data.MySqlClient;
using SIMSystem.Model;
using SIMSystem.PartialForms;
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
    public partial class DefaultDashboard : Form
    {
        List<Announcement> announcements = new List<Announcement>();
        Announcement announcement;

        public DefaultDashboard()
        {
            InitializeComponent();
            ShowCurrentDate();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.ShowDialog(this);
            

        }

        private void ShowCurrentDate()
        {
            string date = DateTime.Now.ToString("MMMM dd, yyyy");
            label1.Text = date;
        }

        private void DefaultDashboard_Load(object sender, EventArgs e)
        {
            panelHeader.BackColor = Color.FromArgb(0x11, 0x46, 0x8f);
            pictureBox2.BackColor = Color.FromArgb(0x11, 0x46, 0x8f);
            GetAllAnnouncement();
            DisplayIFrame();
        }

        private void DisplayIFrame()
        {
            WebBrowser webBrowser = new WebBrowser();

            webBrowser.Navigate("https://www.facebook.com/plugins/page.php?href=https%3A%2F%2Fwww.facebook.com%2Fpsa.marinduque&tabs=timeline&width=340&height=500&small_header=true&adapt_container_width=true&hide_cover=true&show_facepile=false&appId");
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.Dock = DockStyle.Fill;
            panel_iFrame.Controls.Add(webBrowser);
            webBrowser.Show();
        }

        private void DisplayLatestAnnouncement()
        {
            Announcement ann = announcements.OrderByDescending(x => x.CreatedDate).ToList()[0];
        }

        private void GetAllAnnouncement()
        {
            announcements.Clear();
            ConnectionDB connection = new ConnectionDB();

            if (connection.Open())
            {
                try
                {
                    MySqlCommand mySqlCommand = new MySqlCommand(@"
                    SELECT * FROM announcement", connection.connection);
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            announcement = new Announcement();
                            announcement.What = reader["ann_what"].ToString();
                            announcement.Who = reader["ann_who"].ToString();
                            announcement.When = DateTime.Parse(reader["ann_when"].ToString());
                            announcement.Where = reader["ann_where"].ToString();
                            announcement.CreatedBy = reader["emp_id"].ToString();
                            announcement.CreatedDate = DateTime.Parse(reader["ann_createdAt"].ToString());
                            announcements.Add(announcement);
                        }

                        DisplayLatestAnnouncement();
                    }
                    else
                    {
                        Label label = new Label();
                        label.Font = new Font("Heebo", 10);
                        label.ForeColor = Color.Black;
                        label.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                        label.AutoSize = true;
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        int x = (panel_announcementBody.Size.Width - label.Size.Width) / 2;
                        label.Location = new Point(x, 200);
                        label.Text = "No announcement";
                        panel_announcementBody.Controls.Add(label);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ConnectionDB.FailMessage();
            }
        }
    }
}
