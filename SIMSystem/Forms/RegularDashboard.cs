using SIMSystem.Model;
using SIMSystem.MsgrForms;
using SIMSystem.REDashboardComponents;
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
    public partial class RegularDashboard : Form
    {
        User user;
        ConnectionChecker cc;

        public RegularDashboard(User user)
        {
            InitializeComponent();
            this.user = user;
            cc = new ConnectionChecker(user);
        }

        private void RegularDashboard_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(0x11, 0x46, 0x8f);

            lbl_empName.Text = $"{user.Firstname} {user.Lastname}";

            if (user.ProfileImage != null)
            {
                pictureBox2.Image = ConvertSignature.toImage(user.ProfileImage);
            }

            ShowOnlineStatus();
            ShowOverview();
            timer.Start();
        }

        private void ShowOnlineStatus()
        {
            MsgrLayout msgr = new MsgrLayout(user);
            panel_usersOnlineStatus.Controls.Add(msgr);
            msgr.Show();
        }

        private void ShowOverview()
        {
            REOverview overview = new REOverview(user);
            panel_employeeBashboardBody.Controls.Add(overview);
            overview.BringToFront();
            overview.Show();
        }

        private void ShowRequestHistory()
        {
            RequestHistory request = new RequestHistory(user);
            panel_employeeBashboardBody.Controls.Add(request);
            request.BringToFront();
            request.Show();
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

        private void RegularDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            cc.changeToOffline();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                LogOut();
            }
        }

        private void btn_requestHistory_Click(object sender, EventArgs e)
        {
            ShowRequestHistory();
        }

        private void btn_overview_Click(object sender, EventArgs e)
        {
            ShowOverview();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserProfileCard userProfile = new UserProfileCard(user);
            userProfile.Show();
        }
    }
}
