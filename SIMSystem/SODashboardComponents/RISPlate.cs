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
    public partial class RISPlate : UserControl
    {
        User user;
        RIS ris;
        public RISPlate(User u, RIS ris_)
        {
            InitializeComponent();
            user = u;
            ris = ris_;
        }

        private void RISPlate_Load(object sender, EventArgs e)
        {
            SetToolTip();

            lbl_requester.Text = ris.RequesterId;
            lbl_risNumber.Text = ris.Number;

            if (ris.IsPending && !ris.IsApproved)
            {
                panel_indicator.BackColor = Color.White;
            }
            
            if(ris.IsApproved)
            {
                panel_indicator.BackColor = Color.ForestGreen;
            }
            
            if(ris.Sodate.HasValue && !ris.Cssdate.HasValue)
            {
                panel_indicator.BackColor = Color.Red;
            }
        }

        private void RISPlate_Click(object sender, EventArgs e)
        {
            RISPreview risPreview = new RISPreview(user, ris);
            risPreview.Show();
        }

        private void SetToolTip()
        {
            string so = ris.Sodate == null ? "No" : "Yes";
            string cs = ris.Cssdate == null ? "No" : "Yes";

            toolTip1.ToolTipTitle = "RIS Status";
            toolTip1.SetToolTip(this, $"Signed By Supply Officer: {so}\nSigned By Chief Statistical Specialist: {cs}");
        }
    }
}
