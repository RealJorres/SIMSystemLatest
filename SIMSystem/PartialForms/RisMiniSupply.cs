using SIMSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMSystem.PartialForms
{
    public partial class RisMiniSupply : UserControl
    {
        public int supplyId, supplyQuantity;
        public string supplyName, supplyUnit;
        public bool supplyAvailable;

        readonly List<Supply> supplies;
        Supply s;

        public RisMiniSupply(List<Supply> supplies)
        {
            InitializeComponent();
            this.supplies = supplies;
        }

        private void RisMiniSupply_Load(object sender, EventArgs e)
        {
            PopulateSupplyName();
        }

        private void PopulateSupplyName()
        {
            foreach(Supply supply in supplies)
            {
                cb_supply.Items.Add(supply.Name);
            }
        }

        private void tb_quantity_TextChanged(object sender, EventArgs e)
        {
            string quantity = tb_quantity.Text.ToString();
            if (quantity != string.Empty)
            {
                if (Regex.IsMatch(quantity, "^[0-9]*$"))
                {
                    supplyQuantity = int.Parse(quantity);
                    if (supplyQuantity <= s.Quantity)
                    {
                        tb_quantity.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
                        tb_quantity.ForeColor = Color.Black;
                        supplyAvailable = true;
                        lbl_isAvailable.Text = "Yes";
                    }
                    else
                    {
                        tb_quantity.BackColor = Color.Red;
                        tb_quantity.ForeColor = Color.White;
                        supplyAvailable = false;
                        lbl_isAvailable.Text = "No";
                    }
                }
                else
                {
                    tb_quantity.Text = string.Empty;
                    MessageBox.Show("Numeric value only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void cb_supply_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_quantity.Enabled = true;
            supplyName = cb_supply.SelectedItem.ToString();
            s = supplies.Find(x => x.Name == supplyName);
            lbl_currentCount.Text = s.Quantity.ToString();
            lbl_unit.Text = s.Unit;
            supplyUnit = s.Unit;
        }

        public RequestedSupply Requested(RIS ris)
        {
            RequestedSupply requestedSupply = new RequestedSupply();
            requestedSupply.Item = supplyName;
            requestedSupply.Quantity = supplyQuantity;
            requestedSupply.Unit = supplyUnit;
            requestedSupply.RisId = ris.Number;
            requestedSupply.UnitCost = s.Unitcost;
            return requestedSupply;
        }
    }
}
