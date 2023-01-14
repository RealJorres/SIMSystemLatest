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
    public partial class Bulletin : UserControl
    {
        User user;

        List<RIS> risList = new List<RIS>();
        RIS risFromDb;

        public Bulletin(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void Bulletin_Load(object sender, EventArgs e)
        {
            GetAllRis();
            DisplayRis();

            if(user.Type == "Supply Officer")
            {
                btn_generateReport.Visible = true;
            }
            else
            {
                btn_generateReport.Visible = false;
            }
        }

        private void DisplayRis()
        {
            //all
            foreach(RIS r in risList.FindAll(x => x.IsPending == true).OrderByDescending(x=>x.Date))
            {
                RISPlate risplate = new RISPlate(user, r);
                flowLayoutPanel1.Controls.Add(risplate);
                risplate.Show();
            }

            //pending
            if(user.Type == "Supply Officer")
            {
                foreach (RIS r in risList.FindAll(x => x.Sodate == null).OrderByDescending(x => x.Date))
                {
                    RISPlate risplate = new RISPlate(user, r);
                    flowLayoutPanel2.Controls.Add(risplate);
                    risplate.Show();
                }
            }
            else
            {
                foreach (RIS r in risList.FindAll(x=>x.Cssdate == null && x.Sodate != null).OrderByDescending(x => x.Date))
                {
                    RISPlate risplate = new RISPlate(user, r);
                    flowLayoutPanel2.Controls.Add(risplate);
                    risplate.Show();
                }
            }

            //approved
            foreach (RIS r in risList.OrderByDescending(x=>x.Date))
            {
                if (r.IsApproved)
                {
                    RISPlate risplate = new RISPlate(user, r);
                    flowLayoutPanel3.Controls.Add(risplate);
                    risplate.Show();
                }
            }
        }

        private void GetAllRis()
        {

            flowLayoutPanel1.Controls.Clear();
            risList.Clear();

            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getAll = new MySqlCommand(@"
                    SELECT * FROM requisitionIssueSlip", connection.connection);
                    MySqlDataReader reader = getAll.ExecuteReader();
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
                            risFromDb.Sodate = reader["ris_sodate"].ToString() == ""? null: DateTime.Parse(reader["ris_sodate"].ToString());
                            risFromDb.Cssdate = reader["ris_cssdate"].ToString() == "" ? null : DateTime.Parse(reader["ris_cssdate"].ToString());

                            risList.Add(risFromDb);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_generateReport_Click(object sender, EventArgs e)
        {
            GenerateReport generateReport = new GenerateReport();
            generateReport.ShowDialog(this);
        }
    }
}
