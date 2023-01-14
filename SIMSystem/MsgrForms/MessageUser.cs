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
    public partial class MessageUser : UserControl
    {
        Message message;
        public MessageUser(Message m)
        {
            InitializeComponent();
            message = m;
        }

        private void MessageUser_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0x05,0x3f,0x5e);

            lbl_content.Text = message.Content;
            lbl_date.Text = message.Date.ToString("MMMM dd, yyyy (hh:mm tt)");
        }
    }
}
