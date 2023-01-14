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
    public partial class Overview : UserControl
    {
        User user;

        List<RIS> riss = new List<RIS>();
        RIS risFromDb;
        public Overview(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("MMMM d, yyyy");
            lbl_date.Text = date;

            GetAllRIS();

            lbl_year.Text = riss.FindAll(x => x.Date.Year == DateTime.Now.Year).Count.ToString();
            lbl_month.Text = riss.FindAll(x => x.Date.Year == DateTime.Now.Year && x.Date.Month == DateTime.Now.Month).Count.ToString();
            lbl_pending.Text = riss.FindAll(x => x.IsPending == true).Count.ToString();


            double p;
            double s;
            double a;
            double c;

            if (riss.Count == 0)
            {
                p = 0;
                s = 0;
                a = 0;
                c = 0;
            }
            else
            {
                p = (double)riss.FindAll(x => x.Division == "PhilSys" && x.IsApproved == true).Count / (double)riss.Count;
                s = (double)riss.FindAll(x => x.Division == "Statistical" && x.IsApproved == true).Count / (double)riss.Count;
                a = (double)riss.FindAll(x => x.Division == "Admin" && x.IsApproved == true).Count / (double)riss.Count;
                c = (double)riss.FindAll(x => x.Division == "Civil Registration" && x.IsApproved == true).Count / (double)riss.Count;
            }


            double philsys = p * 100;
            double stats = s * 100;
            double admin = a * 100;
            double civil = c * 100;

            cpb_philsys.Value = (int)philsys;
            cpb_philsys.Text = cpb_philsys.Value.ToString() + "%";

            cpb_statistical.Value = (int)stats;
            cpb_statistical.Text = cpb_statistical.Value.ToString() + "%";

            cpb_admin.Value = (int)admin;
            cpb_admin.Text = cpb_admin.Value.ToString() + "%";

            cpb_civilreg.Value = (int)civil;
            cpb_civilreg.Text = cpb_civilreg.Value.ToString() + "%";


            // creating some tooltip for each progressbar
            int approvedPhilSysCount = riss.FindAll(x => x.Division == "PhilSys" && x.IsApproved == true).Count;
            int pendingPhilSysCount = riss.FindAll(x => x.Division == "PhilSys" && x.IsPending == true).Count;

            int approvedStatisticalCount = riss.FindAll(x => x.Division == "Statistical" && x.IsApproved == true).Count;
            int pendingStatisticalCount = riss.FindAll(x => x.Division == "Statistical" && x.IsPending == true).Count;

            int approvedAdminCount = riss.FindAll(x => x.Division == "Admin" && x.IsApproved == true).Count;
            int pendingAdminCount = riss.FindAll(x => x.Division == "Admin" && x.IsPending == true).Count;

            int approvedCivilRegCount = riss.FindAll(x => x.Division == "Civil Registration" && x.IsApproved == true).Count;
            int pendingCivilRegCount = riss.FindAll(x => x.Division == "Civil Registration" && x.IsPending == true).Count;

            toolTip.ToolTipTitle = "Overall statistics";
            toolTip.SetToolTip(cpb_philsys, $"Approved: {approvedPhilSysCount}\nPending: {pendingPhilSysCount}");
            toolTip.SetToolTip(cpb_statistical, $"Approved: {approvedStatisticalCount}\nPending: {pendingStatisticalCount}");
            toolTip.SetToolTip(cpb_admin, $"Approved: {approvedAdminCount}\nPending: {pendingAdminCount}");
            toolTip.SetToolTip(cpb_civilreg, $"Approved: {approvedCivilRegCount}\nPending: {pendingCivilRegCount}");

            DisplayRecentApprove();
        }

        private void GetAllRIS()
        {
            riss.Clear();

            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getRis = new MySqlCommand(@"SELECT * FROM requisitionIssueSlip", connection.connection);
                    MySqlDataReader reader = getRis.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            risFromDb = new RIS();
                            risFromDb.Number = reader["ris_number"].ToString();
                            risFromDb.RequesterId = reader["ris_requesterId"].ToString();
                            risFromDb.EntityName = reader["ris_entityName"].ToString();
                            risFromDb.Division = reader["ris_division"].ToString();
                            risFromDb.Office = reader["ris_office"].ToString();
                            risFromDb.FundCluster = reader["ris_fundCluster"].ToString();
                            risFromDb.Purpose = reader["ris_purpose"].ToString();
                            risFromDb.Date = DateTime.Parse(reader["ris_date"].ToString());
                            risFromDb.IsApproved = bool.Parse(reader["ris_isApproved"].ToString());
                            risFromDb.IsPending = bool.Parse(reader["ris_isPending"].ToString());
                            risFromDb.Rejectnote = reader["ris_rejectnote"].ToString();
                            if (risFromDb.IsApproved)
                            {
                                risFromDb.Cssdate = DateTime.Parse(reader["ris_cssdate"].ToString());
                                risFromDb.Sodate = DateTime.Parse(reader["ris_sodate"].ToString());
                            }
                            riss.Add(risFromDb);

                        }
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

        private void DisplayRecentApprove()
        {
            var s = riss.FindAll(x => x.IsApproved == true).OrderByDescending(x => x.Date).ToList();
            int num = 0;
            if(s.Count > 5)
            {
                num = 5;
            }
            else
            {
                num = s.Count;
            }
            for(var i=0;i<num;i++)
            {
                RISPlate plate = new RISPlate(user, s[i]);
                flowLayoutPanel1.Controls.Add(plate);
                plate.Show();
            }
        }
    }
}
