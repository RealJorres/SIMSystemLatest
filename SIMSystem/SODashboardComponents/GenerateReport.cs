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
    public partial class GenerateReport : Form
    {

        List<RequestedSupply> requestedSupplies = new List<RequestedSupply>();
        RequestedSupply rs;

        private Bitmap bm;
        int origTop = 217;

        public GenerateReport()
        {
            InitializeComponent();
        }

        private void GenerateReport_Load(object sender, EventArgs e)
        {
            pb_report.Controls.Add(lbl_en);
            pb_report.Controls.Add(lbl_fc);
            pb_report.Controls.Add(lbl_daterange);

            cb_month.SelectedIndex = 0;
            cb_year.SelectedIndex = 0;
            GetAllRis();
        }

        private void GetAllRis()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getall = new MySqlCommand(@"SELECT * FROM supplyrequested", connection.connection);
                    MySqlDataReader reader = getall.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            rs = new RequestedSupply();
                            rs.Item = reader["sr_supply"].ToString();
                            rs.RisId = reader["sr_risId"].ToString();
                            rs.Quantity = int.Parse(reader["sr_quantity"].ToString());
                            rs.Unit = reader["sr_unit"].ToString();
                            requestedSupplies.Add(rs);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error getting all RIS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private string GetMonth(string m)
        {
            string month = "";

            switch (m)
            {
                case "01":
                    month = "January";
                    break;
                case "02":
                    month = "February";
                    break;
                case "03":
                    month = "March";
                    break;
                case "04":
                    month = "April";
                    break;
                case "05":
                    month = "May";
                    break;
                case "06":
                    month = "June";
                    break;
                case "07":
                    month = "July";
                    break;
                case "08":
                    month = "August";
                    break;
                case "09":
                    month = "September";
                    break;
                case "10":
                    month = "October";
                    break;
                case "11":
                    month = "November";
                    break;
                case "12":
                    month = "December";
                    break;

            }

            return month;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            lbl_daterange.Text = GetMonth(cb_month.SelectedItem.ToString()) + ", " + cb_year.SelectedItem.ToString();
            var collection = requestedSupplies.FindAll(x => x.RisId.Split('-')[0] == cb_year.SelectedItem.ToString() && x.RisId.Split('-')[1] == cb_month.SelectedItem.ToString());

            foreach(var col in collection)
            {
                Label risnumber = new Label();
                Label item = new Label();
                Label unit = new Label();
                Label quanIssued = new Label();
                Label unitCost = new Label();
                Label totalCost = new Label();

                pb_report.Controls.Add(risnumber);
                pb_report.Controls.Add(item);
                pb_report.Controls.Add(unit);
                pb_report.Controls.Add(quanIssued);
                pb_report.Controls.Add(unitCost);
                pb_report.Controls.Add(totalCost);

                risnumber.Text = col.RisId;
                item.Text = col.Item;
                unit.Text = col.Unit;
                quanIssued.Text = col.Quantity.ToString();
                unitCost.Text = col.UnitCost.ToString();
                double n = col.Quantity * col.UnitCost;
                totalCost.Text = n.ToString();

                risnumber.BackColor = Color.White;
                item.BackColor = Color.White;
                unit.BackColor = Color.White;
                quanIssued.BackColor = Color.White;
                unitCost.BackColor = Color.White;
                totalCost.BackColor = Color.White;

                risnumber.AutoSize = true;
                item.AutoSize = true;
                unit.AutoSize = true;
                quanIssued.AutoSize = true;
                unitCost.AutoSize = true;
                totalCost.AutoSize = true;

                risnumber.Location = new Point(27, origTop);
                item.Location = new Point(283, origTop);
                unit.Location = new Point(392, origTop);
                quanIssued.Location = new Point(478, origTop);
                unitCost.Location = new Point(555, origTop);
                totalCost.Location = new Point(675, origTop);

                origTop += 20;
            }

            if (collection.Count > 0)
            {
                btn_save.Visible = true;
            }
            else
            {
                btn_save.Visible = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                bm = new Bitmap(pb_report.Width, pb_report.Height);
                pb_report.DrawToBitmap(bm, new Rectangle(pb_report.Bounds.X, pb_report.Bounds.Y, bm.Width, bm.Height));
                Graphics g = Graphics.FromImage(bm);
                printPreviewDialog.ShowDialog();
                return;
            }
            catch
            {
                MessageBox.Show("Scroll back to the top to Print/Save this PR Document.", "Ignored Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
