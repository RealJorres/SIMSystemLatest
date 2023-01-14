using MySql.Data.MySqlClient;
using SIMSystem.MiniForms;
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

namespace SIMSystem.PartialForms
{
    public partial class CreateRis : Form
    {
        User employee;

        string entity;
        string requesterId;
        string division;
        string office;
        string fundCluster;
        DateTime date;
        string risNumber;
        string purpose;

        List<Supply> supplies = new List<Supply>();
        Supply supplyFromDb;

        List<RequestedSupply> requestedSupplies = new List<RequestedSupply>();
        RequestedSupply requestedSupply;

        Requester requester;

        RIS ris;

        public CreateRis(User user)
        {
            InitializeComponent();
            employee = user;
        }

        private void CreateRis_Load(object sender, EventArgs e)
        {
            tb_date.Text = DateTime.Now.ToString();

            GetCurrentRisCount();
            GetAllSupplies();

        }

        private void GetAllSupplies()
        {
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(supplies.Count > 0)
            {
                RisMiniSupply risMiniSupply = new RisMiniSupply(supplies);
                risMiniSupply.Dock = DockStyle.Top;
                panel3.Controls.Add(risMiniSupply);
                risMiniSupply.Show();
            }
            else
            {
                MessageBox.Show("No saved supply in the database.", "No Supply", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void GetCurrentRisCount()
        {
            string criscount = "";

            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    connection.Open();
                    MySqlCommand getriscount = new MySqlCommand(@"
                    SELECT autodocid.auto_count FROM autodocid WHERE autodocid.auto_type = 'RIS'", connection.connection);
                    MySqlDataReader reader = getriscount.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            criscount = reader["auto_count"].ToString();
                        }
                    }

                    tb_date.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    tb_risNumber.Text = tb_date.Text.ToString().Split('-')[0] + "-" + tb_date.Text.ToString().Split('-')[1] + "-0" + criscount;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        private void btn_createRis_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var s = panel3.Controls.OfType<RisMiniSupply>().ToList();
                if (s.Count() == 0)
                {
                    MessageBox.Show("No Supply requested.", "Empty RIS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else if (s.FindAll(x => x.cb_supply.SelectedItem == null).Count > 0)
                {
                    MessageBox.Show("Requested supply is empty.", "Empty Supply", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                } 
                else if (s.FindAll(x => x.tb_quantity.Text.ToString() == "").Count > 0)
                {
                    MessageBox.Show("Requested supply quantity is empty.", "Empty Supply quantity", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    entity = tb_entityName.Text.ToString();
                    requesterId = employee.Id;
                    fundCluster = tb_fundCluster.Text.ToString();
                    division = cb_division.SelectedItem.ToString();
                    office = tb_office.Text.ToString();
                    date = DateTime.Parse(tb_date.Text.ToString());
                    purpose = tb_purpose.Text.ToString();
                    risNumber = tb_risNumber.Text.ToString();


                    ris = new RIS();
                    ris.EntityName = entity;
                    ris.RequesterId = requesterId;
                    ris.FundCluster = fundCluster;
                    ris.Division = division;
                    ris.Office = office;
                    ris.Date = date;
                    ris.Purpose = purpose;
                    ris.Number = risNumber;

                    requester = new Requester();
                    requester.Name = employee.Firstname + " " + employee.Lastname;
                    requester.Designation = employee.Type;
                    requester.Ris_number = ris.Number;
                    requester.Signature = employee.Signature;

                    foreach (var ss in s)
                    {
                        requestedSupply = ss.Requested(ris);
                        requestedSupplies.Add(requestedSupply);
                    }

                    PasswordConfirmation passwordConfirmation = new PasswordConfirmation(this, employee);
                    passwordConfirmation.Show();
                }
            }
        }

        public void SaveNewRis()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand saveRis = new MySqlCommand(@"
                    INSERT INTO requisitionIssueSlip(ris_number, ris_requesterId, ris_entityName, ris_division, ris_office, ris_fundCluster, ris_purpose) 
                    VALUES(@ris_number, @ris_requesterId, @ris_entityName, @ris_division, @ris_office, @ris_fundCluster, @ris_purpose)", connection.connection);
                    saveRis.Parameters.Add("@ris_number", MySqlDbType.VarChar).Value = ris.Number;
                    saveRis.Parameters.Add("@ris_requesterId", MySqlDbType.VarChar).Value = employee.Id;
                    saveRis.Parameters.Add("@ris_entityName", MySqlDbType.VarChar).Value = ris.EntityName;
                    saveRis.Parameters.Add("@ris_division", MySqlDbType.VarChar).Value = ris.Division;
                    saveRis.Parameters.Add("@ris_office", MySqlDbType.VarChar).Value = ris.Office;
                    saveRis.Parameters.Add("@ris_fundCluster", MySqlDbType.VarChar).Value = ris.FundCluster;
                    saveRis.Parameters.Add("@ris_purpose", MySqlDbType.VarChar).Value = ris.Purpose;
                    saveRis.ExecuteNonQuery();

                    MySqlCommand saveRequester = new MySqlCommand(@"
                    INSERT INTO risRequester(rr_name, rr_risNumber, rr_designation, rr_signature)
                    VALUES(@name, @risNumber, @designation, @signature)", connection.connection);
                    saveRequester.Parameters.Add("@name", MySqlDbType.VarChar).Value = requester.Name;
                    saveRequester.Parameters.Add("@risNumber", MySqlDbType.VarChar).Value = requester.Ris_number;
                    saveRequester.Parameters.Add("@designation", MySqlDbType.VarChar).Value = requester.Designation;
                    saveRequester.Parameters.Add("@signature", MySqlDbType.MediumBlob).Value = requester.Signature;
                    saveRequester.ExecuteNonQuery();

                    foreach(RequestedSupply rs in requestedSupplies)
                    {
                        rs.Save();
                    }

                    MySqlCommand changeAutoCount = new MySqlCommand(@"
                    UPDATE autodocid SET auto_count= (SELECT auto_count FROM autodocid WHERE auto_type = 'RIS') + 1 WHERE auto_type = 'RIS'", connection.connection);
                    changeAutoCount.ExecuteNonQuery();

                    DeductToDatabase();

                    MessageBox.Show("RIS has been successfully created.", "RIS created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SendMulThread();
                    

                    Log log = new Log(employee.Id, "Created RIS");
                    log.Save();


                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                    Close();
                }
            }
            else
            {
                ConnectionDB.FailMessage();
            }
        }

        private void SendMulThread()
        {
            SendEmail sendEmail = new SendEmail();
            string[] emails = { sendEmail.GetSOEmail(), sendEmail.GetCSSEmail() };
            foreach (string s in emails)
            {
                SendEmail sendEmail1 = new SendEmail();
                Task.Factory.StartNew(() => sendEmail1.SendAfterCreatingRIS(s, $"{employee.Firstname} {employee.Lastname}"));
            }
        }

        private void cb_division_Validating(object sender, CancelEventArgs e)
        {
            if(cb_division.SelectedItem == null)
            {
                e.Cancel = true;
                errorProvider.SetError(cb_division, "Please select a division.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_division, null);
            }
        }

        private void tb_purpose_Validating(object sender, CancelEventArgs e)
        {
            if(tb_purpose.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_purpose, "Please fill-up the purpose field.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_purpose, null);
            }
        }

        private void DeductToDatabase()
        {
            foreach(var r in requestedSupplies)
            {
                ConnectionDB connection = new ConnectionDB();
                if (connection.Open())
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(@"
                        UPDATE supply SET supply.supply_quantity = supply.supply_quantity - @requestQuantity, supply.supply_totalCost = supply.supply_totalCost - (supply.supply_unitCost * @requestQuantity) WHERE supply.supply_name = @requestSupply;", connection.connection);
                        cmd.Parameters.Add("@requestQuantity", MySqlDbType.Int32).Value = r.Quantity;
                        cmd.Parameters.Add("@requestSupply", MySqlDbType.VarChar).Value = r.Item;
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error updating the supply.");
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
}
