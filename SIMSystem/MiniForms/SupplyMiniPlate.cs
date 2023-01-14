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

namespace SIMSystem.MiniForms
{
    public partial class SupplyMiniPlate : UserControl
    {
        Supply supply;
        User emp;

        public SupplyMiniPlate(Supply sup, User emp)
        {
            InitializeComponent();
            supply = sup;
            this.emp = emp;
        }

        private void SupplyMiniPlate_Load(object sender, EventArgs e)
        {
            lbl_supplyName.Text = supply.Name;
            lbl_supplyQuantity.Text = supply.Quantity.ToString();
            lbl_supplyUnit.Text = supply.Unit.ToString();
            lbl_supplyCLevel.Text = supply.Clevel.ToString();
            lbl_supplyUnitCost.Text = String.Format("{0:0.00}", supply.Unitcost);
            lbl_supplyTotalCost.Text = supply.Totalcost.ToString();
        }
    }
}
