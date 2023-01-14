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

namespace SIMSystem.REDashboardComponents
{
    public partial class RequestHistory : UserControl
    {
        List<RIS> risList = new List<RIS>();
        RIS ris;

        User employee;
        public RequestHistory(User u)
        {
            InitializeComponent();
            employee = u;
        }

        private void RequestHistory_Load(object sender, EventArgs e)
        {
            GetAllOwnedRis();

            DisplayOwnedRis();

        }

        private void DisplayOwnedRis()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach(var r in risList)
            {
                RISPlate plate = new RISPlate(employee, r);
                flowLayoutPanel1.Controls.Add(plate);
                plate.Show();
            }
        }

        private void GetAllOwnedRis()
        {
            risList.Clear();

            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getRis = new MySqlCommand(@"
                    SELECT * FROM requisitionIssueSlip WHERE ris_requesterId = @userId", connection.connection);
                    getRis.Parameters.Add("@userId", MySqlDbType.VarChar).Value = employee.Id;
                    MySqlDataReader reader = getRis.ExecuteReader();
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
                            risList.Add(ris);
                        }
                    }
                }
                catch (Exception ex)
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
    }
}
