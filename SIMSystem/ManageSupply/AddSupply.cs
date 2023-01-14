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
    public partial class AddSupply : Form
    {
        User emp;

        public AddSupply(User u)
        {
            InitializeComponent();
            emp = u;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(label2, @"Adding Supply means you are adding the supply to the inventory for the first time. Adding a quantity to an existing supply can be done in Manage Supply > Update Supply.");
        }

        private void tb_supplyName_Validating(object sender, CancelEventArgs e)
        {
            string supplyName = tb_supplyName.Text.ToString();
            if (supplyName.Length <= 0 || supplyName.Length > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_supplyName, "Supply name must be within 50 characters in length.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_supplyName, null);
            }
        }

        private void tb_poNumber_Validating(object sender, CancelEventArgs e)
        {
            string supplyPoNumber = tb_poNumber.Text.ToString();
            if (supplyPoNumber.Length <= 0 || supplyPoNumber.Length > 50)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_poNumber, "Supply purchase order number must be within 50 characters in length.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_poNumber, null);
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
            else if(n <= 0)
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

        private void tb_supplyCLevel_Validating(object sender, CancelEventArgs e)
        {
            string supplyCLevel = tb_supplyCLevel.Text.ToString();
            int n;
            bool isNumeric = int.TryParse(supplyCLevel, out n);
            if (!isNumeric)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_supplyCLevel, "Supply critical level has an invalid character.");
            }
            else if(n <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_supplyCLevel, "Supply critical level must be higher than zero.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_supplyCLevel, null);
            }

        }

        private void cb_supplyType_Validating(object sender, CancelEventArgs e)
        {
            var supplyType = cb_supplyType.SelectedItem;
            if(supplyType == null)
            {
                e.Cancel = true;
                errorProvider.SetError(cb_supplyType, "Select a valid type for the supply.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_supplyType, null);
            }
        }

        private void cb_supplyUnit_Validating(object sender, CancelEventArgs e)
        {
            var supplyUnit = cb_supplyUnit.SelectedItem;
            if (supplyUnit == null)
            {
                e.Cancel = true;
                errorProvider.SetError(cb_supplyUnit, "Select a valid unit for the supply.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cb_supplyUnit, null);
            }
        }

        private void tb_supplyUnitCost_Validating(object sender, CancelEventArgs e)
        {
            string supplyUnitCost = tb_supplyUnitCost.Text.ToString();
            double n;
            bool isNumeric = double.TryParse(supplyUnitCost, out n);
            if (!isNumeric)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_supplyUnitCost, "Supply unit cost has an invalid character.");
            }
            else if(n <= 0)
            {
                e.Cancel = true;
                errorProvider.SetError(tb_supplyUnitCost, "Supply unit cost must be higher than zero.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tb_supplyUnitCost, null);
                double uc = int.Parse(tb_supplyQuantity.Text.ToString()) * double.Parse(tb_supplyUnitCost.Text.ToString());
                tb_supplyTotalCost.Text = String.Format("{0:0.00}", uc);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                int count = 0;
                ConnectionDB connection = new ConnectionDB();
                if (connection.Open())
                {
                    try
                    {
                        MySqlCommand checkNamePoNumber = new MySqlCommand(@"
                        Select * FROM supply WHERE  supply.supply_name = @name", connection.connection);
                        checkNamePoNumber.Parameters.Add("@name", MySqlDbType.VarChar).Value = tb_supplyName.Text.ToString();
                        //checkNamePoNumber.Parameters.Add("@poNumber", MySqlDbType.VarChar).Value = tb_poNumber.Text.ToString();
                        MySqlDataReader reader = checkNamePoNumber.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                count += 1;
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

                if(count == 0)
                {
                    PasswordConfirmation passwordConfirmation = new PasswordConfirmation(this, emp);
                    passwordConfirmation.ShowDialog();
                }
                else
                {
                    MessageBox.Show("A supply with the same name and PO number is existing in the database.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void AddSupplyToDb()
        {
            string year = DateTime.Now.Year.ToString();

            //get all values into a variable
            string supplyname = tb_supplyName.Text.ToString();
            string poNumber = tb_poNumber.Text.ToString();
            int quantity = int.Parse(tb_supplyQuantity.Text.ToString());
            int clevel = int.Parse(tb_supplyCLevel.Text.ToString());
            string type = cb_supplyType.SelectedItem.ToString();
            string unit = cb_supplyUnit.SelectedItem.ToString();
            double unitCost = double.Parse(tb_supplyUnitCost.Text.ToString());
            double totalCost = double.Parse(tb_supplyTotalCost.Text.ToString());

            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try {
                    using (MySqlCommand addSupply = new MySqlCommand(@"
                        INSERT INTO supply(supply_name, supply_poNumber, supply_quantity, supply_cLevel, supply_type, supply_unit, supply_yearAdded, supply_unitCost, supply_totalCost)
                        VALUES(@name, @poNumber,@quantity, @clevel, @type, @unit, @year, @unitCost, @totalCost)", connection.connection)){
                        addSupply.Parameters.Add("@name", MySqlDbType.VarChar).Value = supplyname;
                        addSupply.Parameters.Add("@poNumber", MySqlDbType.VarChar).Value = poNumber;
                        addSupply.Parameters.Add("@quantity", MySqlDbType.Int32).Value = quantity;
                        addSupply.Parameters.Add("@clevel", MySqlDbType.Int32).Value = clevel;
                        addSupply.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
                        addSupply.Parameters.Add("@unit", MySqlDbType.VarChar).Value = unit;
                        addSupply.Parameters.Add("@year", MySqlDbType.VarChar).Value = year;
                        addSupply.Parameters.Add("@unitCost", MySqlDbType.Int64).Value = unitCost;
                        addSupply.Parameters.Add("@totalCost", MySqlDbType.Int64).Value = totalCost;

                        if (addSupply.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Successfully added a new supply.", "New Supply added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            Log log = new Log(emp.Id, "Added a new supply.");
                            log.Save();

                            Form form = new AdminDashboard(emp);
                            form.Activate();
                            Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
