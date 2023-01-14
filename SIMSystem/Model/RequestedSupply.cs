using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMSystem.Model
{
    public class RequestedSupply
    {
        private string item;
        private int quantity;
        private string risId;
        private string unit;
        private double unitCost;

        public RequestedSupply()
        {

        }

        public void Save()
        {
            ConnectionDB connection = new ConnectionDB();
            if (connection.Open())
            {
                try
                {
                    MySqlCommand saveThis = new MySqlCommand(@"
                    INSERT INTO supplyRequested(sr_supply, sr_quantity, sr_risId, sr_unit)
                    VALUES(@supply, @quantity, @risId, @unit)", connection.connection);
                    saveThis.Parameters.Add("@supply", MySqlDbType.VarChar).Value = this.Item;
                    saveThis.Parameters.Add("@quantity", MySqlDbType.Int32).Value = this.Quantity;
                    saveThis.Parameters.Add("@risId", MySqlDbType.VarChar).Value = this.RisId;
                    saveThis.Parameters.Add("@unit", MySqlDbType.VarChar).Value = this.Unit;
                    saveThis.ExecuteNonQuery();
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

        public string Item { get => item; set => item = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string RisId { get => risId; set => risId = value; }
        public string Unit { get => unit; set => unit = value; }
        public double UnitCost { get => unitCost; set => unitCost = value; }
    }
}
