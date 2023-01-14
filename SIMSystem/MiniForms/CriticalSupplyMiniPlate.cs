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
    public partial class CriticalSupplyMiniPlate : UserControl
    {
        Supply supply;
        public CriticalSupplyMiniPlate(Supply s)
        {
            InitializeComponent();
            supply = s;
        }

        private void CriticalSupplyMiniPlate_Load(object sender, EventArgs e)
        {
            lbl_supplyName.Text = supply.Name;
            lbl_supplyCriticalLevel.Text = supply.Clevel.ToString();
            lbl_supplyQuantity.Text = supply.Quantity.ToString();

            lbl_supplyQuantity.ForeColor = Color.OrangeRed;
        }
    }
}
