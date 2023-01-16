using MySql.Data.MySqlClient;
using SIMSystem.Forms;
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

namespace SIMSystem.ManageSupply
{
    public partial class UpdateSupply : Form
    {
        User emp;

        List<Supply> supplies = new List<Supply>();
        Supply supplyFromDb, s;

        public UpdateSupply(User u)
        {
            InitializeComponent();
            emp = u;
        }

        private void UpdateSupply_Load(object sender, EventArgs e)
        {
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
                        supplyFromDb.Unitcost = double.Parse(reader["supply_unitCost"].ToString());
                        supplyFromDb.Totalcost = int.Parse(reader["supply_totalCost"].ToString());
                        supplyFromDb.Type = reader["supply_type"].ToString();
                        supplies.Add(supplyFromDb);

                        //add names into cb_supplyName
                        cb_supplyName.Items.Add(supplyFromDb.Name);

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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                PasswordConfirmation passwordConfirmation = new PasswordConfirmation(this, emp);
                passwordConfirmation.ShowDialog();
            }
        }

        public void UpdateToDb()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    s.Quantity += int.Parse(tb_supplyQuantity.Text.ToString());
                    s.Totalcost += double.Parse(tb_supplyTotalCost.Text.ToString());
                    s.Unitcost = s.Totalcost / s.Quantity;
                    s.Ponumber = tb_supplyPONumber.Text.ToString();


                    MySqlCommand updateSuppy = new MySqlCommand(@"
                    UPDATE supply
                    SET supply_quantity = @quantity, supply_totalCost = @totalCost, supply_unitCost = @unitCost, supply_poNumber = @poNumber
                    WHERE supply_name = @supplyName", connection.connection);
                    updateSuppy.Parameters.Add("@quantity", MySqlDbType.Int32).Value = s.Quantity;
                    updateSuppy.Parameters.Add("@totalCost", MySqlDbType.Int32).Value = s.Totalcost;
                    updateSuppy.Parameters.Add("@unitCost", MySqlDbType.Double).Value = s.Unitcost;
                    updateSuppy.Parameters.Add("@poNumber", MySqlDbType.VarChar).Value = s.Ponumber;
                    updateSuppy.Parameters.Add("@supplyName", MySqlDbType.VarChar).Value = s.Name;
                    
                    if(updateSuppy.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Successfully updated a supply.", "Supply updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Log log = new Log(emp.Id, "Updated a supply.");
                        log.Save();

                        Form form = new AdminDashboard(emp);
                        form.Activate();
                        Close();
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

        private void tb_supplyQuantity_Validating(object sender, CancelEventArgs e)
        {
            string supplyQuantity = tb_supplyQuantity.Text.ToString();
            int n;
            bool isNumeric = int.TryParse(supplyQuantity, out n);
            if (!isNumeric)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_supplyQuantity, "Supply quantity has an invalid character.");
            }
            else if (n <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_supplyQuantity, "Supply quantity must be higher than zero.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_supplyQuantity, null);
            }
        }

        private void tb_supplyTotalCost_Validating(object sender, CancelEventArgs e)
        {
            string supplyQuantity = tb_supplyTotalCost.Text.ToString();
            int n;
            bool isNumeric = int.TryParse(supplyQuantity, out n);
            if (!isNumeric)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_supplyTotalCost, "Supply total cost has an invalid character.");
            }
            else if (n <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_supplyTotalCost, "Supply total cost must be higher than zero.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_supplyTotalCost, null);
            }
        }

        private void cb_supplyName_Validating(object sender, CancelEventArgs e)
        {
            string supplyName = cb_supplyName.SelectedIndex == -1 ? "" : cb_supplyName.SelectedItem.ToString();
            if (supplyName.Length <= 0 || supplyName.Length > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(cb_supplyName, "Supply name must be within 50 characters in length.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_supplyName, null);
            }
        }

        private void tb_supplyPONumber_Validating(object sender, CancelEventArgs e)
        {
            string poNumber = tb_supplyPONumber.Text.ToString();
            if(poNumber.Length <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_supplyPONumber, "Please provide a PO Number for this supply.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_supplyPONumber, null);
            }
        }

        private void cb_supplyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sup = cb_supplyName.SelectedItem.ToString();
            s = supplies.Find(x => x.Name == sup);
            cb_supplyType.SelectedItem = s.Type;
            cb_supplyUnit.SelectedItem = s.Unit;
        }
    }
}
