using Microsoft.Extensions.Configuration;
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
    public partial class UpdateConfig : Form
    {
        readonly IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        public UpdateConfig()
        {
            InitializeComponent();
        }

        private void UpdateConfig_Load(object sender, EventArgs e)
        {
            var settings = config.GetRequiredSection("Settings");

            tb_server.Text = settings["SERVER"].ToString();
            tb_db.Text = settings["DATABASE"].ToString();
            tb_username.Text = settings["USERNAME"].ToString();
            tb_password.Text = settings["PASSWORD"].ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string server = tb_server.Text.ToString();
            string database = tb_db.Text.ToString();
            string username = tb_username.Text.ToString();
            string password = tb_password.Text.ToString();

            SettingsController settingsController = new SettingsController();

            if (settingsController.UpdateSettings(server, database, username, password))
            {
                MessageBox.Show("New Configuration saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
                Close();
            }
            else
            {
                MessageBox.Show("Failed saving the new configuration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
