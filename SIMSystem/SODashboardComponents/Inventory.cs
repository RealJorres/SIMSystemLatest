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

namespace SIMSystem.SODashboardComponents
{
    public partial class Inventory : UserControl
    {
        List<Supply> supplies = new List<Supply>();
        List<Supply> inCriticalLevel = new List<Supply>();
        Supply supplyFromDb;

        User employee;

        public Inventory(User u)
        {
            InitializeComponent();
            employee = u;
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

        private void DisplaySupply()
        {
            if (supplies.Count > 0)
            {
                foreach (Supply ss in supplies)
                {
                    SupplyMiniPlate supplyMiniPlate = new SupplyMiniPlate(ss, employee);
                    supplyMiniPlate.Dock = DockStyle.Top;
                    tabPage1.Controls.Add(supplyMiniPlate);
                    supplyMiniPlate.Show();
                }
            }
            SupplyMiniHeader supplyMiniHeader = new SupplyMiniHeader();
            supplyMiniHeader.Dock = DockStyle.Top;
            tabPage1.Controls.Add(supplyMiniHeader);
            supplyMiniHeader.Show();
        }

        private void GetSupplyInCriticalLevel()
        {
            var lowLevel = supplies.FindAll(x => x.Quantity <= x.Clevel);
            foreach(Supply s in lowLevel)
            {
                inCriticalLevel.Add(s);
            }
        }

        private void DisplayInCriticalLevel()
        {
            if(inCriticalLevel.Count > 0)
            {
                foreach(Supply s in inCriticalLevel)
                {
                    CriticalSupplyMiniPlate criticalSupplyMiniPlate = new CriticalSupplyMiniPlate(s);
                    criticalSupplyMiniPlate.Dock = DockStyle.Top;
                    tabPage2.Controls.Add(criticalSupplyMiniPlate);
                    criticalSupplyMiniPlate.Show();
                }
            }
            CriticalSupplyMiniHeader criticalSupplyMiniHeader = new CriticalSupplyMiniHeader();
            criticalSupplyMiniHeader.Dock = DockStyle.Top;
            tabPage2.Controls.Add(criticalSupplyMiniHeader);
            criticalSupplyMiniHeader.Show();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            GetAllSupplies();
            DisplaySupply();

            GetSupplyInCriticalLevel();
            DisplayInCriticalLevel();
        }

    }
}
