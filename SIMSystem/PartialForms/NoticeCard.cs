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
    public partial class NoticeCard : UserControl
    {
        Announcement ann;
        public NoticeCard(Announcement a)
        {
            InitializeComponent();
            ann = a;
        }

        private void NoticeCard_Load(object sender, EventArgs e)
        {
            lbl_what.Text = ann.What;
            lbl_when.Text = ann.When.ToString("MMMM dd yyyy hh:mm tt");
            lbl_where.Text = ann.Where;
            lbl_who.Text = ann.Who;
        }
    }
}
