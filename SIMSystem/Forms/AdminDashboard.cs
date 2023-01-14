using MySql.Data.MySqlClient;
using SIMSystem.ManageSupply;
using SIMSystem.ManageUser;
using SIMSystem.MiniForms;
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
    public partial class AdminDashboard : Form
    {
        User user;

        //users from database
        List<User> users = new List<User>();
        User userFromDb;

        //supplies from database
        List<Supply> supplies = new List<Supply>();
        Supply supplyFromDb;

        //logs from database
        List<Log> logs = new List<Log>();
        Log logFromDb;

        //connection check
        ConnectionChecker cc;

        public AdminDashboard(User u)
        {
            InitializeComponent();
            user = u;
            cc = new ConnectionChecker(user);
        }

        private void btn_manageUser_Click(object sender, EventArgs e)
        {
            if(panel_manageUser.Size == panel_manageUser.MinimumSize)
            {
                panel_manageUser.Size = panel_manageUser.MaximumSize;
            }
            else
            {
                panel_manageUser.Size = panel_manageUser.MinimumSize;
            }
        }

        private void btn_manageSupply_Click(object sender, EventArgs e)
        {
            if (panel_manageSupply.Size == panel_manageSupply.MinimumSize)
            {
                panel_manageSupply.Size = panel_manageSupply.MaximumSize;
            }
            else
            {
                panel_manageSupply.Size = panel_manageSupply.MinimumSize;
            }
        }

        private void GetAllUsers()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getUsers = new MySqlCommand(@"SELECT * FROM user WHERE user.emp_isActive = TRUE", connection.connection);
                    MySqlDataReader reader = getUsers.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            userFromDb = new User();
                            userFromDb.Id = reader["emp_id"].ToString();
                            userFromDb.Firstname = reader["emp_firstName"].ToString();
                            userFromDb.Lastname = reader["emp_lastName"].ToString();
                            userFromDb.Address = reader["emp_address"].ToString();
                            userFromDb.Email = reader["emp_email"].ToString();
                            userFromDb.Type = reader["emp_type"].ToString();
                            userFromDb.IsNotifEnabled = bool.Parse(reader["emp_isNotifEnabled"].ToString());
                            users.Add(userFromDb);
                        }
                    }

                    else
                    {
                        Label label = new Label();
                        label.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                        label.AutoSize = false;
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        int x = (tabPage1.Size.Width - label.Size.Width) / 2;
                        label.Location = new Point(x, 200);
                        label.Text = "No users";
                        tabPage1.Controls.Add(label);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void GetAllSupplies()
        {
            supplies.Clear();

            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getSupplies = new MySqlCommand(@"SELECT * FROM supply", connection.connection);
                    MySqlDataReader reader = getSupplies.ExecuteReader();
                    while (reader.Read())
                    {
                        supplyFromDb = new Supply();
                        supplyFromDb.Name = reader["supply_name"].ToString();
                        supplyFromDb.Ponumber = reader["supply_poNumber"].ToString();
                        supplyFromDb.Unit = reader["supply_unit"].ToString();
                        supplyFromDb.Quantity = int.Parse(reader["supply_quantity"].ToString());
                        supplyFromDb.Clevel = int.Parse(reader["supply_cLevel"].ToString());
                        supplyFromDb.Unitcost = int.Parse(reader["supply_unitCost"].ToString());
                        supplyFromDb.Totalcost = int.Parse(reader["supply_totalCost"].ToString());
                        supplyFromDb.Type = reader["supply_type"].ToString();
                        supplies.Add(supplyFromDb);

                    }

                    if (supplies.Count == 0)
                    {
                        Label label = new Label();
                        label.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                        label.AutoSize = false;
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        int x = (tabPage2.Size.Width - label.Size.Width) / 2;
                        label.Location = new Point(x, 200);
                        label.Text = "No supplies";
                        tabPage2.Controls.Add(label);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void GetAllLogs()
        {
            logs.Clear();

            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getLogs = new MySqlCommand(@"SELECT * FROM logFile", connection.connection);
                    MySqlDataReader reader = getLogs.ExecuteReader();
                    while (reader.Read())
                    {
                        logFromDb = new Log();
                        logFromDb.User = reader["log_userId"].ToString();
                        logFromDb.Event_occure = reader["log_event"].ToString();
                        logFromDb.Date = DateTime.Parse(reader["log_date"].ToString());
                        logs.Add(logFromDb);

                    }

                    if (logs.Count == 0)
                    {
                        Label label = new Label();
                        label.Anchor = AnchorStyles.Left & AnchorStyles.Right;
                        label.AutoSize = false;
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        int x = (tabPage3.Size.Width - label.Size.Width) / 2;
                        label.Location = new Point(x, 200);
                        label.Text = "No logs";
                        tabPage3.Controls.Add(label);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DisplayUsers()
        {
            if(users.Count > 0)
            {
                foreach(User ee in users)
                {
                    UserMiniPlate userMiniPlate = new UserMiniPlate(ee, user);
                    userMiniPlate.Dock = DockStyle.Top;
                    tabPage1.Controls.Add(userMiniPlate);
                    userMiniPlate.Show();
                }

                UserMiniHeader userMiniHeader = new UserMiniHeader();
                userMiniHeader.Dock = DockStyle.Top;
                tabPage1.Controls.Add(userMiniHeader);
                userMiniHeader.Show();
            }
        }

        private void DisplaySupply()
        {
            if(supplies.Count > 0)
            {
                foreach (Supply ss in supplies)
                {
                    SupplyMiniPlate supplyMiniPlate = new SupplyMiniPlate(ss, user);
                    supplyMiniPlate.Dock = DockStyle.Top;
                    tabPage2.Controls.Add(supplyMiniPlate);
                    supplyMiniPlate.Show();
                }
                SupplyMiniHeader supplyMiniHeader = new SupplyMiniHeader();
                supplyMiniHeader.Dock = DockStyle.Top;
                tabPage2.Controls.Add(supplyMiniHeader);
                supplyMiniHeader.Show();
            }
        }

        private void DisplayLog()
        {
            if (logs.Count > 0)
            {
                foreach (Log ll in logs)
                {
                    LogMiniPlate logMiniPlate = new LogMiniPlate(ll, user);
                    logMiniPlate.Dock = DockStyle.Top;
                    tabPage3.Controls.Add(logMiniPlate);
                    logMiniPlate.Show();
                }

                LogMiniHeader logMiniHeader = new LogMiniHeader();
                logMiniHeader.Dock = DockStyle.Top;
                tabPage3.Controls.Add(logMiniHeader);
                logMiniHeader.Show();
            }
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(user);
            addUser.Show(this);
        }

        private void btn_updateUser_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser(user);
            updateUser.Show(this);
        }

        private void btn_addSupply_Click(object sender, EventArgs e)
        {
            AddSupply addSupply = new AddSupply(user);
            addSupply.Show(this);
        }

        private void btn_updateSupply_Click(object sender, EventArgs e)
        {
            UpdateSupply updateSupply = new UpdateSupply(user);
            updateSupply.Show(this);
        }

        private void AdminDashboard_Activated(object sender, EventArgs e)
        {
            panel_manageUser.Size = panel_manageUser.MinimumSize;
            panel_manageSupply.Size = panel_manageSupply.MinimumSize;
            lbl_userName.Text = user.Firstname;

            users.Clear();
            supplies.Clear();
            logs.Clear();

            RemovePreviousList();

            GetAllUsers();
            GetAllSupplies();
            GetAllLogs();

            DisplayUsers();
            DisplaySupply();
            DisplayLog();
        }

        private void RemovePreviousList()
        {
            tabPage1.Controls.Clear();
            tabPage2.Controls.Clear();
            tabPage3.Controls.Clear();

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(0x11, 0x46, 0x8f);
            panelHeader.BackColor = Color.FromArgb(0x11, 0x46, 0x8f);

            timer.Start();

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
            Login login = new Login();
            login.Show();
            Close();
        }

        private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            cc.changeToOffline();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                DefaultDashboard defaultDashboard = new DefaultDashboard();
                defaultDashboard.Show();
                Close();

            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            AdminSettings adminSettings = new AdminSettings();
            adminSettings.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserProfileCard userProfile = new UserProfileCard(user);
            userProfile.Show();
        }
    }
}
