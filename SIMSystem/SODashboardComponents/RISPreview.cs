using MySql.Data.MySqlClient;
using SIMSystem.Forms;
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
    public partial class RISPreview : Form
    {
        User user;

        List<RequestedSupply> requestedSupplies = new List<RequestedSupply>();

        RIS ris;

        Requester requester = new Requester();

        byte[] soSig;

        byte[] cssSig;

        Bitmap bm;

        int origTop = 256;

        public RISPreview(User u, RIS r)
        {
            InitializeComponent();
            user = u;
            ris = r;
        }

        private void RISPreview_Load(object sender, EventArgs e)
        {
            GetAllRequestedSupply();
            GetRequester();
            Populatelabels();
            PopulateRequestedSupply();
            ButtonState();
        }

        private void Populatelabels()
        {
            lbl_entityName.Text = ris.EntityName;
            lbl_fundCluster.Text = ris.FundCluster;
            lbl_division.Text = ris.Division;
            lbl_office.Text = ris.Office;
            lbl_risNumber.Text = ris.Number;
            lbl_purpose.Text = ris.Purpose;

            //requester details
            pb_requesterSignature.Image = ConvertSignature.toImage(requester.Signature);
            lbl_requeterName.Text = requester.Name;
            lbl_requesterDesignation.Text = requester.Designation;
            lbl_requesterDate.Text = ris.Date.ToString("MMM dd yyyy");

            //add to pb_ris control
            pb_ris.Controls.Add(lbl_entityName);
            pb_ris.Controls.Add(lbl_fundCluster);
            pb_ris.Controls.Add(lbl_division);
            pb_ris.Controls.Add(lbl_office);
            pb_ris.Controls.Add(lbl_risNumber);
            pb_ris.Controls.Add(lbl_purpose);
            pb_ris.Controls.Add(pb_requesterSignature);
            pb_ris.Controls.Add(lbl_requeterName);
            pb_ris.Controls.Add(lbl_requesterDesignation);
            pb_ris.Controls.Add(lbl_requesterDate);
            pb_ris.Controls.Add(pb_soSignature);
            pb_ris.Controls.Add(lbl_soDate);
            pb_ris.Controls.Add(pb_cssSignature);
            pb_ris.Controls.Add(lbl_cssDate);

            //add signatures when args met
            if(ris.Sodate != null)
            {
                GetSOSignature();
                pb_soSignature.Image = ConvertSignature.toImage(soSig);
                lbl_soDate.Text = ris.Sodate.Value.ToString("MMM dd yyyy");
            }

            if(ris.Cssdate != null)
            {
                GetCSSSignature();
                pb_cssSignature.Image = ConvertSignature.toImage(cssSig);
                lbl_cssDate.Text = ris.Cssdate.Value.ToString("MMM dd yyyy");
            }
        }


        private void GetAllRequestedSupply()
        {
            requestedSupplies.Clear();

            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getRequested = new MySqlCommand(@"
                    SELECT * FROM supplyrequested WHERE sr_risId= @risNumber", connection.connection);
                    getRequested.Parameters.Add("@risNumber", MySqlDbType.VarChar).Value = ris.Number;
                    MySqlDataReader reader = getRequested.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            RequestedSupply rs = new RequestedSupply();
                            rs.Item = reader["sr_supply"].ToString();
                            rs.Quantity = int.Parse(reader["sr_quantity"].ToString());
                            rs.Unit = reader["sr_unit"].ToString();
                            rs.UnitCost = double.Parse(reader["sr_unitCost"].ToString());
                            requestedSupplies.Add(rs);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error getting requested supplies");
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

        private void PopulateRequestedSupply()
        {
            foreach(RequestedSupply rs in requestedSupplies)
            {
                //create new instance of labels
                Label supplyname = new Label();
                Label quantity = new Label();
                Label available = new Label();
                Label issued = new Label();

                //change fonts for each labels
                supplyname.Font = new Font("Times New Roman", 9f, FontStyle.Regular);
                quantity.Font = new Font("Times New Roman", 9f, FontStyle.Regular);
                available.Font = new Font("Times New Roman", 9f, FontStyle.Regular);
                issued.Font = new Font("Times New Roman", 9f, FontStyle.Regular);

                //set location for each labels
                supplyname.Location = new Point(136, origTop);
                quantity.Location = new Point(275, origTop);
                available.Location = new Point(368, origTop);
                issued.Location = new Point(509, origTop);

                //set label's text to requested supply's values
                supplyname.Text = rs.Item;
                quantity.Text = rs.Quantity.ToString();
                available.Text = "✓";
                issued.Text = quantity.Text.ToString();

                //change bg color to transparent to each labels
                supplyname.BackColor = Color.Transparent;
                quantity.BackColor = Color.Transparent;
                available.BackColor = Color.Transparent;
                issued.BackColor = Color.Transparent;

                //adding the labels to the control
                pb_ris.Controls.Add(supplyname);
                pb_ris.Controls.Add(quantity);
                pb_ris.Controls.Add(available);
                

                //some conditions
                if (ris.Cssdate.HasValue)
                {
                    pb_ris.Controls.Add(issued);
                    lbl_receiverName.Text = requester.Name;
                    lbl_receiverDesignation.Text = requester.Designation;
                    lbl_receivedDate.Text = ris.Cssdate.Value.ToString("MMM dd yyyy");
                    pb_receiverSignature.Image = ConvertSignature.toImage(requester.Signature);
                }


                origTop += 39;
            }
        }

        private void GetRequester()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getRequester = new MySqlCommand(@"
                    SELECT * FROM risrequester WHERE rr_risNumber = @risNumber;", connection.connection);
                    getRequester.Parameters.Add("@risNumber", MySqlDbType.VarChar).Value = ris.Number;
                    MySqlDataReader reader = getRequester.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            requester.Name = reader["rr_name"].ToString();
                            requester.Ris_number = reader["rr_risNumber"].ToString();
                            requester.Designation = reader["rr_designation"].ToString();
                            requester.Signature = (byte[])reader["rr_signature"];
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error getting requester.");
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

        private void ButtonState()
        {
            btn_action.Enabled = false;

            if(user.Type == "Supply Officer" && ris.Sodate == null)
            {
                btn_action.Enabled = true;
            }

            if(user.Type == "Chief Statistical Specialist" && ris.Cssdate == null && ris.Sodate != null)
            {
                btn_action.Enabled= true;
            }

            if (user.Type == "Supply Officer" && ris.IsApproved)
            {
                btn_action.Text = "Print";
                btn_action.Enabled = true;
            }

            if(user.Type == "Regular Employee")
            {
                btn_action.Visible = false;
            }
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            if(btn_action.Text == "Print")
            {
                try
                {
                    bm = new Bitmap(pb_ris.Width, pb_ris.Height);
                    pb_ris.DrawToBitmap(bm, new Rectangle(pb_ris.Bounds.X, pb_ris.Bounds.Y, bm.Width, bm.Height));
                    Graphics g = Graphics.FromImage(bm);
                    printPreviewDialog1.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("Scroll back to the top to Print/Save this RIS Document.", "Ignored Operation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if(user.Type == "Supply Officer")
                {
                    SOSign();
                }
                else
                {
                    CSSSign();
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void SOSign()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand updateRis = new MySqlCommand(@"
                    UPDATE requisitionissueslip SET ris_sodate = @sodate WHERE ris_number = @risNumber", connection.connection);
                    updateRis.Parameters.Add("@sodate", MySqlDbType.Timestamp).Value = DateTime.Now;
                    updateRis.Parameters.Add("@risNumber", MySqlDbType.VarChar).Value = ris.Number;
                    updateRis.ExecuteNonQuery();
                    MessageBox.Show("You have successfully signed the RIS.", "RIS Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error occurred while updating the ris.");
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

        private void CSSSign()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand updateRis = new MySqlCommand(@"
                    UPDATE requisitionissueslip SET ris_cssdate = @cssdate, ris_isApproved = TRUE, ris_isPending = FALSE WHERE ris_number = @risNumber", connection.connection);
                    updateRis.Parameters.Add("@cssdate", MySqlDbType.Timestamp).Value = DateTime.Now;
                    updateRis.Parameters.Add("@risNumber", MySqlDbType.VarChar).Value = ris.Number;
                    updateRis.ExecuteNonQuery();
                    MessageBox.Show("You have successfully signed the RIS.", "RIS Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error occurred while updating the ris.");
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

        private void GetSOSignature()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getSig = new MySqlCommand(@"
                    SELECT emp_signature FROM user WHERE emp_type = 'Supply Officer';", connection.connection);
                    MySqlDataReader reader = getSig.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            soSig = (byte[])reader["emp_signature"];
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error getting supply officer's signature.");
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

        private void GetCSSSignature()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand getSig = new MySqlCommand(@"
                    SELECT emp_signature FROM user WHERE emp_type = 'Chief Statistical Specialist';", connection.connection);
                    MySqlDataReader reader = getSig.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            cssSig = (byte[])reader["emp_signature"];
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error getting chief statistical specialist's signature.");
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
