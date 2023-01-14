using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Message = SIMSystem.Model.Message;

namespace SIMSystem.MsgrForms
{
    public partial class MessageOther : UserControl
    {
        Message message;
        public MessageOther(Message m)
        {
            InitializeComponent();
            message = m;
        }

        private void MessageOther_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0x02, 0x2c, 0x43);

            lbl_content.Text = message.Content;
            lbl_date.Text = message.Date.ToString("MMMM dd, yyyy (hh:mm tt)");
        }
    }
}
